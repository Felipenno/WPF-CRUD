using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Dominio
{
    public class Usuario : BaseNotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetField(ref _email, value); }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { SetField(ref _senha, value); }
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
