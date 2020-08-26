using System.Windows;

namespace UI
{
    public partial class NomeCpf : Window
    {
        public NomeCpf()
        {
            InitializeComponent();
        }

        private void BtnContinuarVenda(object sender, RoutedEventArgs e)
        {
            Close();
            NovaVenda novaVenda = new NovaVenda(boxNomeCliente.Text, boxCpfCliente.Text);
            novaVenda.ShowDialog();
        }
    }
}
