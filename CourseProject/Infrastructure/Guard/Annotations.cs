using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Guard
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public sealed class InvokerParameterNameAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Delegate | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class NotNullAttribute : Attribute { }
}
