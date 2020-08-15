using Dominio;
using Repositorio;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class UsuarioModel
    {
        private UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
       
        public void CriarUsuario(string nome, string email, string senha)
        {
            Usuario novoUsuario = new Usuario(nome, email, Codificar(senha));
            _usuarioRepositorio.Add(novoUsuario);
            _usuarioRepositorio.SaveChangesAsync();
        }

        public async Task<bool> Entrar(string email, string senha)
        {
            Usuario login = new Usuario(email, Codificar(senha));
            Usuario usuario = await _usuarioRepositorio.Entrar(login);

            if(usuario == null)
            {
                return false;
            }

            return true;
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
