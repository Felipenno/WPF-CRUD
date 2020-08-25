using Dominio;
using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UI.Model;

namespace UI
{
    /// <summary>
    /// Lógica interna para NovoProduto.xaml
    /// </summary>
    public partial class NovoProduto : Window
    {
        ProdutoModel _pModel = new ProdutoModel();
        private Produto _produto;

        public NovoProduto()
        {
            InitializeComponent();

            boxGrupo.ItemsSource = Enum.GetValues(typeof(ProdutoGrupo)).Cast<ProdutoGrupo>();
            boxUnMedida.ItemsSource = Enum.GetValues(typeof(UnidadeMedida)).Cast<UnidadeMedida>();
            
        }
        public NovoProduto(Produto produto) : this()
        {

            _produto = produto;


            if (_produto != null)
            {
                boxDescricao.Text = _produto.Descricao;
                boxUnMedida.Text = _produto.UnidadeDeMedida.ToString();
                boxCodBarras.Text = _produto.CodBarras;
                boxPrecoCusto.Text = _produto.PrecoCusto.ToString();
                boxPrecoVenda.Text = _produto.PrecoVenda.ToString();
                boxAtivo.IsEnabled = _produto.Ativo;
                boxGrupo.Text = _produto.ProdutoGrupo.ToString();
            }
        }


        private void btnConfirmarProduto(object sender, RoutedEventArgs e)
        {
            if (_produto == null)
            {
                _pModel.AdicionarProduto
                    (
                        boxDescricao.Text,
                        Enum.Parse<UnidadeMedida>(boxUnMedida.Text),
                        boxCodBarras.Text,
                        decimal.Parse(boxPrecoCusto.Text),
                        decimal.Parse(boxPrecoVenda.Text),
                        boxAtivo.IsEnabled,
                        Enum.Parse<ProdutoGrupo>(boxGrupo.Text)
                    );

                MessageBox.Show("Produto Adicionado com sucesso!");

            }
            else
            {
                _pModel.EditarProduto
                    (
                        _produto.Id,
                        boxDescricao.Text,
                        Enum.Parse<UnidadeMedida>(boxUnMedida.Text),
                        boxCodBarras.Text,
                        decimal.Parse(boxPrecoCusto.Text),
                        decimal.Parse(boxPrecoVenda.Text),
                        boxAtivo.IsEnabled,
                        Enum.Parse<ProdutoGrupo>(boxGrupo.Text)
                    );

                MessageBox.Show("Produto Atualizado com sucesso!");
            }
        }
    }
}
