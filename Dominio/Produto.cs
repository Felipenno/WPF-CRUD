using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeDeMedida { get; set; }
        public string CodBarras { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public bool Ativo { get; set; }
        public ProdutoGrupo ProdutoGrupo { get; set; }
        

        public List<VendaProduto> VendaProdutos { get; set; }


    }
}
