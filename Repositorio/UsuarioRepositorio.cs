using Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class UsuarioRepositorio : IRepositorio<Usuario>
    {
        private readonly Context _context;

        public UsuarioRepositorio(Context context)
        {
            _context = context;
        }

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario[]> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
