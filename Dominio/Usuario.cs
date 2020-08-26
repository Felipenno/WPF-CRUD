using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
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
