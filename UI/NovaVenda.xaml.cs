using Dominio;
using Dominio.Enum;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using UI.Model;

namespace UI
{
    public partial class NovaVenda : Window
    {
        VendaModel vModel = new VendaModel();
        List<Produto> produtos = new List<Produto>();

        public NovaVenda(string nomeCliente, string cpfCliente)
        {
            InitializeComponent();
            blockNomeCliente.Text = nomeCliente;
            blockCpfCliente.Text = cpfCliente;

        }

        private async void boxCodProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var produto = await vModel.ProcurarProduto(int.Parse(boxCodProduto.Text));
                if (produto != null)
                {
                    blockNomeProduto.Text = produto.Descricao;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                }
            }
        }

        private async void boxQuantidade_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                int codigoProduto = int.Parse(boxCodProduto.Text);
                Produto produto = await vModel.ProcurarProduto(codigoProduto);
                produtos.Add(produto);

                NovaVendaCollection vendas = new NovaVendaCollection(produto.Id, produto.Descricao, produto.UnidadeDeMedida, produto.PrecoVenda, int.Parse(boxQuantidade.Text));

                gridVendaProduto.Items.Add(vendas);

                blockTotal.Text = (decimal.Parse(blockTotal.Text) + vendas.Total).ToString();
            }
        }

        private async void btnConfirmarVenda(object sender, RoutedEventArgs e)
        {
            bool status = await vModel.NovaVenda(blockCpfCliente.Text, blockNomeCliente.Text, decimal.Parse(blockTotal.Text), boxObs.Text, produtos);

            if (status == true)
            {
                MessageBox.Show("Venda cadastrada com sucesso!");
                Close();

                MessageBoxResult result = MessageBox.Show("Deseja incluir nome e cpf do cliente?", "Nome e CPF do Cliente", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        NomeCpf nomeCpf = new NomeCpf();
                        nomeCpf.ShowDialog();
                        break;

                    case MessageBoxResult.No:
                        NovaVenda novaVenda = new NovaVenda("Não informado", "Não informado");
                        novaVenda.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar venda!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    class NovaVendaCollection
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public UnidadeMedida UnidadeDeMedida { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal Total { get; set; }

        public NovaVendaCollection(int produtoId, string produtoNome, UnidadeMedida unidadeDeMedida, decimal precoVenda, int quantidadeProduto)
        {
            ProdutoId = produtoId;
            ProdutoNome = produtoNome;
            UnidadeDeMedida = unidadeDeMedida;
            PrecoVenda = precoVenda;
            QuantidadeProduto = quantidadeProduto;
            Total = quantidadeProduto * precoVenda;
        }
    }
}
