using System;
using Microsoft.AspNetCore.Mvc;
using Ken.Test.Web.Models;

namespace Ken.Test.Web.Controllers
{
    public class RenderDataController : Controller
    {
        public IActionResult ViewDataDemo()
        {
            ViewData["title"] = "ViewData传值示例";
            ViewData["name"] = "weilei";
            ViewData["birthday"] = new DateTime(2000, 1, 1);
            ViewData["hobby"] = new string[] { "跑步", "阅读", "Coding" };
            return View();
        }

        public IActionResult ViewBagDemo()
        {
            ViewBag.Title = "VIewBag传值示例";
            ViewBag.Name = "weilei";
            ViewBag.Birthday = new DateTime(2000, 1, 1);
            ViewBag.Hobby = new string[] { "跑步", "阅读", "Coding" };
            return View();
        }

        public IActionResult ViewModelDemo()
        {
            ViewBag.Title = "ViewModel传值示例";
            var person = new Person { Name = "weilei", Birthday = new DateTime(2000, 1, 1), hobby = new string[] { "跑步", "阅读", "Coding" } };
            return View(person);
        }
    }
}
