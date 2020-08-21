using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class ProdutoModel
    {
        private ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();

        public async Task<Produto[]> ListarProdutos()
        {
            return await _produtoRepositorio.GetAllAsync();
        }
    }
}
