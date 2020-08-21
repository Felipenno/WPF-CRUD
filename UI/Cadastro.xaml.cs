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
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private async void btnCadastro(object sender, RoutedEventArgs e)
        {
            IsEnabled = false;
            UsuarioModel uModel = new UsuarioModel();

            if (boxPass.Password == boxReptPass.Password && boxEmail.Text != string.Empty && boxNome.Text != string.Empty && boxPass.Password != string.Empty)
            {
                bool emailValido = await uModel.CriarUsuario(boxNome.Text, boxEmail.Text, boxPass.Password);

                if(emailValido)
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Email já cadastrado!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("As senhas são diferentes ou existem campos vazios", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            IsEnabled = true;

        }
    }
}
