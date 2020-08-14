using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class VendaRepositorio : IRepositorio<Venda>
    {
        private readonly Context _context;

        public VendaRepositorio(Context context)
        {
            _context = context;
        }

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
        public async void SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
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
