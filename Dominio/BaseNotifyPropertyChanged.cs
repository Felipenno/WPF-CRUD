using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dominio
{
    public class BaseNotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetField<T>(ref T campo, T value, [CallerMemberName] string nomePropriedade = null)
        {
            if (!EqualityComparer<T>.Default.Equals(campo, value))
            {
                campo = value;
                OnPropertyChanged(nomePropriedade);
            }
        }
        protected void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }
    }
}
