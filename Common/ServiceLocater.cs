using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todomaui.Common
{
    public class ServiceLocater
    {
        public static void Init(IServiceProvider intance)
        {
            ServiceLocater.intance = intance;
        }
        private static IServiceProvider intance = null;

        public static  T GetService<T>()
        {
            return intance.GetService<T>();
        }

        public static object GetService(Type t)
        {
            return intance.GetService(t);
        } 
    }
}
