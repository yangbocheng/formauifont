using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace todomaui.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseChanged([CallerMemberName]string propname="")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }

        protected void SetProperty<T>(ref T field,T value, [CallerMemberName] string? propertyName = null)
        {
            field = value;
            RaiseChanged(propertyName);
        }
    }
}
