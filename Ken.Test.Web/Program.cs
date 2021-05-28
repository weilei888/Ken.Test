using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Ken.Test.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                //应用程序启动时配置日志
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders(); //清除日志提供程序
                    logging.SetMinimumLevel(LogLevel.Information); //设置日志级别，information可以减少控制台输出
                    logging.AddConsole(); //添加日志提供程序--控制台
                })
                .UseNLog(); //引入第三方NLog，注释掉得话则引用自带Logging
    }
}
