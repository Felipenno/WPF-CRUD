using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.Model;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnEntrar(object sender, RoutedEventArgs e)
        {
            IsEnabled = false;
            UsuarioModel uModel = new UsuarioModel();
            string usuarioAutenticado = await uModel.Entrar(emailBox.Text, passBox.Password);

            if(usuarioAutenticado != string.Empty)
            {  
                Principal principalWindow = new Principal(usuarioAutenticado);
                principalWindow.Show();
                Close();
            }
            else
            {   
                MessageBox.Show("Email ou Senha inválido");
                IsEnabled = true;
            }
        }

        private void btnNovo(object sender, RoutedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }
    }
}
