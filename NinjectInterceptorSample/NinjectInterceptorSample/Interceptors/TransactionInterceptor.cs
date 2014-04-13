using Ninject.Extensions.Interception;
using System;

namespace NinjectInterceptorSample.Interceptors
{
    public class TransactionInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Transaction started");

            invocation.Proceed();

            Console.WriteLine("Transaction stopped");
        }
    }
}
