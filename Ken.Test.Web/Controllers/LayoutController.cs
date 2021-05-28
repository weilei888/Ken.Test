using System;
using Microsoft.AspNetCore.Mvc;


namespace Ken.Test.Web.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult SectionDemo()
        {
            return View();
        }
    }
}