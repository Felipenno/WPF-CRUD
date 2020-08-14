using Dominio;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    class ProdutoRepositorio : IRepositorio<Produto>
    {

        private readonly Context _context;

        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public async void Add(Produto produto)
        {
           await  _context.Produtos.AddAsync(produto);
        }

        public void Delete(Produto produto)
        {
            _context.Produtos.Remove(produto);
        }

        public void Update(Produto entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> SaveChangesAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto[]> GetAll()
        {
            return await _context.Produtos.ToArrayAsync();
        }

        public async Task<Produto> GetById(int ProdutoId)
        {
            return await _context.Produtos.Where(P => P.Id == ProdutoId).FirstOrDefaultAsync();
        }


    }
}
