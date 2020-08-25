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

        public NovoProduto()
        {
            InitializeComponent();

            boxGrupo.ItemsSource = Enum.GetValues(typeof(ProdutoGrupo)).Cast<ProdutoGrupo>();
            boxUnMedida.ItemsSource = Enum.GetValues(typeof(UnidadeMedida)).Cast<UnidadeMedida>();
        }

        private void btnConfirmarProduto(object sender, RoutedEventArgs e)
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
    }
}
