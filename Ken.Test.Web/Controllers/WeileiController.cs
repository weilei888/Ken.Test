using System;
using Microsoft.AspNetCore.Mvc;

namespace Ken.Test.Web.Controllers
{
    public class WeileiController : Controller
    {
        public IActionResult Index()
        {
            return Content("欢迎使用 ASP.Net Core");
        }

        public IActionResult Welcome(string name, string age)
        {
            return Content($"欢迎{name}(年龄{age})");
        }
    }
}
