using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Attributes;
using Ninject.Extensions.Interception.Request;
using Ninject;
using NinjectInterceptorSample.Interceptors;

namespace NinjectInterceptorSample.InterceptorAttributes
{
    public class LogAttribute : InterceptAttribute
    {
        public override IInterceptor CreateInterceptor(IProxyRequest request)
        {
            return request.Context.Kernel.Get<LogInterceptor>();
        }
    }
}
