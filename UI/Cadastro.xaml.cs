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

        private void btnCadastro(object sender, RoutedEventArgs e)
        {
            UsuarioModel uModel = new UsuarioModel();

            try
            {
                if(boxPass.Password == boxReptPass.Password && boxEmail.Text != string.Empty && boxNome.Text != string.Empty && boxPass.Password != string.Empty)
                {
                    uModel.CriarUsuario(boxNome.Text, boxEmail.Text, boxPass.Password);
                }
                else
                {
                    MessageBox.Show("As senhas são diferentes ou existem campos vazios");
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
    }
}
