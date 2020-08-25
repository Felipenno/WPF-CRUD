using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Venda
    {
        public int Id { get; set; }
        public string ClienteDocumento { get; set; }
        public string ClienteNome { get; set; }
        public string Obs { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; }

        public Venda()
        {

        }

        public Venda(string clienteDocumento, string clienteNome, decimal total, string obs, DateTime dataHora)
        {
            ClienteDocumento = clienteDocumento;
            ClienteNome = clienteNome;
            Total = total;
            Obs = obs;
            DataHora = dataHora;
        }
    }
}
