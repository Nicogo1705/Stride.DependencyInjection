using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride.DepInjection
{
    internal class InjectionService
    {

        private Dictionary<Type, object> ToInject = new();

        public void Register(object instance)
        {
            ToInject.Add(instance.GetType(), instance);
        }

    }
}
