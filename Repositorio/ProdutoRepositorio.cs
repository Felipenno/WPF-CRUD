using Dominio;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private readonly Context _context = new Context();

        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Delete(Produto produto)
        {
            _context.Produtos.Remove(produto);
        }

        public void Update(Produto produto)
        {
            _context.Produtos.Update(produto);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Produto[]> GetAllAsync()
        {
            return await _context.Produtos.ToArrayAsync();
        }

        public async Task<Produto> GetByIdAsync(int ProdutoId)
        {
            return await _context.Produtos.Where(P => P.Id == ProdutoId).FirstOrDefaultAsync();
        }
    }
}
