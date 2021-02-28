using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Intercepors
{
    //              classlara veya metodlara uygulanabilir, birden fazla uygulanabilir, inherit edilebilir
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }//Öncelik demek önce validation sonra loglama gibi gibi


        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
