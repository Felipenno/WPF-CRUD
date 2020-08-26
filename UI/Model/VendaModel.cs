using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UI.Model
{
    public class VendaModel
    {
        private VendaProdutoRepositorio _vendaProdutoRepositorio = new VendaProdutoRepositorio();
        private ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();
        private VendaRepositorio _vendaRepositorio = new VendaRepositorio();

        public async Task<Produto> ProcurarProduto(int id)
        {
            return await _produtoRepositorio.GetByIdAsync(id);
        }

        public async Task<Venda[]> ListarVendas()
        {
            return await _vendaRepositorio.GetAllAsync();
        }

        public async Task<bool> NovaVenda(string clienteDocumento, string clienteNome, decimal total, string obs, List<Produto> produtos)
        {
            List<VendaProduto> vendaProdutos = new List<VendaProduto>();
            Venda venda = new Venda(clienteDocumento, clienteNome, total, obs, DateTime.Now);

            _vendaRepositorio.Add(venda);
            await _vendaRepositorio.SaveChangesAsync();

            foreach (Produto produto in produtos)
            {
                vendaProdutos.Add(
                    new VendaProduto { PrecoVenda = venda.Total, ProdutoId = produto.Id, VendaId = venda.Id }
                    );
            }

            _vendaProdutoRepositorio.AddRange(vendaProdutos);

            return await _vendaProdutoRepositorio.SaveChangesAsync();
        }
    }
}