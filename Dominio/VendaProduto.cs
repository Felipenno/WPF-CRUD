using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class VendaProduto
    {
        public int Id { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Quantidade { get; set; }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public VendaProduto()
        {

        }
    }
}
