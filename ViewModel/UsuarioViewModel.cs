using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ViewModel
{
    public class UsuarioViewModel : BaseNotifyPropertyChanged
    {
        private readonly UsuarioRepositorio _userContext;
        private Usuario _usuario = new Usuario();

        public string ttttttt; 
        public string Nome
        {
            get { return ttttttt; }
            set
            {
                ttttttt = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _usuario.Email;
            set 
            {
                _usuario.Email = value;
                OnPropertyChanged();
            }
        }

        public string Senha
        {
            get => _usuario.Senha;
            set
            {
                _usuario.Senha = value;
                OnPropertyChanged();
            }
        }

        public static string Codificar(string texto)
        {
            var md5 = MD5.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

    }
}

