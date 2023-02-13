using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todomaui.Common
{
    public class InstanceBase2<T> where T : class, new()
    {
        public static T Instance = new T();
       
    }
}
