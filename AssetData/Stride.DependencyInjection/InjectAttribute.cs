using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride.DepInjection
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class InjectAttribute : Attribute
    {
        public InjectionType InjectionType { get; }

        public InjectAttribute(InjectionType injectionType = InjectionType.Static)
        {
            InjectionType = injectionType;
        }

    }

    public enum InjectionType
    {
        Static,
        dynamic
    }

}
