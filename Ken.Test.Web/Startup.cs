using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Ken.Test.Web.Respositories;
using Ken.Test.Web.Middlewares;

namespace Ken.Test.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //引入MVC模块,3.
            services.AddMvc(options => { options.EnableEndpointRouting = false; });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //配置DbContext注入
            services.AddTransient<TestDbContext>();

            //配置Repossitity注入
            services.AddTransient<TestRepository>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //引用中间件
            // app.UseTokenCheck();

            //MVC应用一定把MVC中间件引用放到最后一个注册
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" }

                // //     配置 参数映射 测试 专用路由
                //    name:"ParamsMappingTest",
                //    template:"pmt/{action}/{id?}",
                //    defaults:new {controller="ParamsMappingTest",action="GetId"}
                );
            });
        }
    }
}
