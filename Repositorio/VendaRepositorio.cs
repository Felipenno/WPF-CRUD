using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class VendaRepositorio : IRepositorio<Venda>
    {
        private readonly Context _context = new Context();

        public void Add(Venda venda)
        {
            _context.Vendas.Add(venda);
        }

        public void Delete(Venda venda)
        {
            _context.Vendas.Remove(venda);
        }
        public void Update(Venda venda)
        {
            _context.Vendas.Update(venda);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Venda[]> GetAllAsync()
        {
            return await _context.Vendas.ToArrayAsync();
        }

        public async Task<Venda> GetByIdAsync(int vendaId)
        {
            return await _context.Vendas.Where(V => V.Id == vendaId).FirstOrDefaultAsync();
        }


    }
}
