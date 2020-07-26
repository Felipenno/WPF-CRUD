using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Venda
    {
        public int Id { get; set; }
        public string ClienteDocumento { get; set; }
        public string ClienteNome { get; set; }
        public string Obs { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; }
    }
}
