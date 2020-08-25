using Dominio;
using System;
using System.Collections.Generic;
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
    public partial class Principal : Window
    {


        public Principal(string usuarioAtual)
        {

            InitializeComponent();

            BoxUsuarioAtual.Text = usuarioAtual;
        }

        private void BtnCadastroProduto(object sender, RoutedEventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto();

            novoProduto.ShowDialog();
        }

        private void btnEditarProduto(object sender, RoutedEventArgs e)
        {
           Produto produto = (Produto)gridProdutos.SelectedItem;

            if(produto != null)
            {
                NovoProduto novoProduto = new NovoProduto(produto);

                novoProduto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item");
            }
        }

        private async void BtnConsultarProduto(object sender, RoutedEventArgs e)
        {
            ProdutoModel _pModel = new ProdutoModel();
            gridProdutos.ItemsSource = await _pModel.ListarProdutos();
        }

        private void BtnNovaVendaDialog(object sender, RoutedEventArgs e)
        {
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

        private async void BtnConsultarVenda(object sender, RoutedEventArgs e)
        {
            VendaModel _vModel = new VendaModel();

            gridVendas.ItemsSource = await _vModel.ListarVendas();
        }

        private void BtnFecharSistema(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
