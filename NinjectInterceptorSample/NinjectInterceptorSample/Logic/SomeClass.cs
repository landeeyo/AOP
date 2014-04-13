using NinjectInterceptorSample.InterceptorAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectInterceptorSample.Logic
{
    public class SomeClass
    {
        [Transaction]
        [Log]
        public virtual void SomeMethod()
        {
            Console.WriteLine("SomeClass SomeMethod body");
        }
    }
}
