using System;
using Microsoft.AspNetCore.Builder;

namespace Ken.Test.Web.Middlewares
{
    public static class MIddlewareExdtension
    {
        //创建扩展方法。将TokenCheckMiddleware挂到接口IApplicationBuilder上
        public static IApplicationBuilder UseTokenCheck(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenCheckMiddleware>();
        }
    }
}
