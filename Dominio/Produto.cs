using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Produto : BaseNotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { SetField(ref _descricao, value); }
        }

        private UnidadeMedida _unidadeDeMedida;
        public UnidadeMedida UnidadeDeMedida
        {
            get { return _unidadeDeMedida; }
            set { SetField(ref _unidadeDeMedida, value); }
        }

        private string _codBarra;
        public string CodBarra
        {
            get { return _codBarra; }
            set { SetField(ref _codBarra, value); }
        }

        private decimal _precoCusto;
        public decimal PrecoCusto
        {
            get { return _precoCusto; }
            set { SetField(ref _precoCusto, value); }
        }

        private decimal _precoVenda;
        public decimal PrecoVenda
        {
            get { return _precoVenda; }
            set { SetField(ref _precoVenda, value); }
        }

        private DateTime _dataHoraCadastro;
        public DateTime DataHoraCadastro
        {
            get { return _dataHoraCadastro; }
            set { SetField(ref _dataHoraCadastro, value); }
        }

        private bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set { SetField(ref _ativo, value); }
        }

        private ProdutoGrupo _grupo;
        public ProdutoGrupo Grupo
        {
            get { return _grupo; }
            set { SetField(ref _grupo, value); }
        }

        public List<VendaProduto> VendaProdutos { get; set; }
    }
}
