using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string Descricao { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public UnidadeMedida UnidadeDeMedida { get; set; }

        [MaxLength(150)]
        public string CodBarras { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal PrecoCusto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal PrecoVenda { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        [Required]
        public DateTime DataHoraCadastro { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public ProdutoGrupo ProdutoGrupo { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; }

        public Produto() { }

        public Produto(string descricao, UnidadeMedida unidadeDeMedida, string codBarras, decimal precoCusto, decimal precoVenda, DateTime dataHoraCadastro, bool ativo, ProdutoGrupo produtoGrupo)
        {
            Descricao = descricao;
            UnidadeDeMedida = unidadeDeMedida;
            CodBarras = codBarras;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            DataHoraCadastro = dataHoraCadastro;
            Ativo = ativo;
            ProdutoGrupo = produtoGrupo;
        }

        public Produto(int id, string descricao, UnidadeMedida unidadeDeMedida, string codBarras, decimal precoCusto, decimal precoVenda, DateTime dataHoraCadastro, bool ativo, ProdutoGrupo produtoGrupo) : this(descricao, unidadeDeMedida, codBarras, precoCusto, precoVenda, dataHoraCadastro, ativo, produtoGrupo)
        {
            Id = id;
        }
    }
}
