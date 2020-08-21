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
        private readonly ProdutoModel _pModel = new ProdutoModel();
        private readonly VendaModel _vModel = new VendaModel();
        public Principal()
        {
            Login login = (Login)Application.Current.MainWindow;

            InitializeComponent();
            
            BoxUsuarioAtual.Text = login.UsuarioAtual;
        }

        private void BtnCadastroProduto(object sender, RoutedEventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto();

            novoProduto.ShowDialog();
        }

        private async void BtnConsultarProduto(object sender, RoutedEventArgs e)
        {
            gridProdutos.ItemsSource = await _pModel.ListarProdutos();
        }

       private void BtnNomeCpfDialog(object sender, RoutedEventArgs e)
        {
            NomeCpf nomeCpf = new NomeCpf();
            nomeCpf.ShowDialog();
        }

        private void BtnConsultarVenda(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnFecharSistema(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
