using Ninject;
using NinjectInterceptorSample.Logic;
using Ninject.Extensions.Interception;
using System;

namespace NinjectInterceptorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<SomeClass>().ToSelf();

            var someClass = kernel.Get<SomeClass>();
            someClass.SomeMethod();

            Console.ReadKey();
        }
    }
}
