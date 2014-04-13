using Ninject.Extensions.Interception;
using System;

namespace NinjectInterceptorSample.Interceptors
{
    public class LogInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Method started");

            invocation.Proceed();

            Console.WriteLine("Method stopped");
        }
    }
}
