using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Venda : BaseNotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _clienteDocumento;
        public string ClienteDocumento
        {
            get { return _clienteDocumento; }
            set { SetField(ref _clienteDocumento, value); }
        }

        private string _clienteNome;
        public string ClienteNome
        {
            get { return _clienteNome; }
            set { SetField(ref _clienteNome, value); }
        }

        private string _obs;
        public string Obs
        {
            get { return _obs; }
            set { SetField(ref _obs, value); }
        }

        private decimal _total;
        public decimal Total
        {
            get { return _total; }
            set { SetField(ref _total, value); }
        }

        private DateTime _dataHora;
        public DateTime DataHora
        {
            get { return _dataHora; }
            set { SetField(ref _dataHora, value); }
        }

        public List<VendaProduto> VendaProdutos { get; set; }
    }
}
