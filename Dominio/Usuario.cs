using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public Usuario(string nome, string email, string senha) : this(email, senha)
        {
            Nome = nome;
        }
    }
}
