using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Ken.Test.Web.Middlewares
{
    public class TokenCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenCheckMiddleware(RequestDelegate requestDelegate)
        {
            this._next = requestDelegate;
        }

        public Task Invoke(HttpContext context)
        {
            //先从url取token，如取不到就从form表单中取token
            var token = context.Request.Query["token"].ToString() ?? context.Request.Form["token"].ToString();
            if (string.IsNullOrWhiteSpace(token))
            {
                //如果没有token信息则返回
                return context.Response.WriteAsync("token missing");
            }
            //把当前分钟进行MD5验证，测试方法
            var minute0 = DateTime.Now.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm");
            var minute = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            if (token == MD5Hash(minute) || token == MD5Hash(minute0))
            {
                return _next.Invoke(context);
            }
            //token未验证通过
            return context.Response.WriteAsync("token error");
        }

        public string MD5Hash(string value)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
                var strResult = BitConverter.ToString(result);
                // var a= strResult.Replace("-", "");
                return strResult.Replace("-", "");
            }
        }
    }
}
