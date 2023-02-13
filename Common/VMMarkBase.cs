using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todomaui.ViewModels;

namespace todomaui.Common
{
    public class VMMarkBase<T> : IMarkupExtension<T> where T : class
    {
        public T ProvideValue(IServiceProvider serviceProvider)
        {
            return Activator.CreateInstance(typeof(T)) as T;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<T>).ProvideValue(serviceProvider);
        }
    }

    class TodoListPageVM_design: VMMarkBase<TodoListPageVM> { }
}
