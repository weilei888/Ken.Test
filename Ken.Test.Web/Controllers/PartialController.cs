using System;
using Microsoft.AspNetCore.Mvc;

namespace Ken.Test.Web.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Demo()
        {
            return View();
        }

        public IActionResult DemowithParams()
        {
            return View();
        }
    }
}
