using System.Windows;
using UI.Model;

namespace UI
{
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

            if (usuarioAutenticado != string.Empty)
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
