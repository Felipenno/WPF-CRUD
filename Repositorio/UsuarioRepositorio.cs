using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        private Context _context = new Context();

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public void Delete(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }

        public async void SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario[]> GetAllAsync()
        {
            return await _context.Usuarios.ToArrayAsync();
        }

        public async Task<Usuario> GetByIdAsync(int usuarioId)
        {
            return await _context.Usuarios.Where(U => U.Id == usuarioId).FirstOrDefaultAsync();
        }

        public async Task<Usuario> Entrar(Usuario usuario)
        {
            Usuario user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email && u.Senha == usuario.Senha);

            return user;
        }


    }
}
