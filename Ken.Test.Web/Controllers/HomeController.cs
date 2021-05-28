using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Ken.Test.Web.Controllers
{
    public class HomeController : Controller
    {
        //使用内置日志组件
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("--------\r\nindex:hello world\r\n--------");
            ViewBag.Title = "Home";
            ViewBag.Message = "Hello world! - weilei'demo";
            return View();
        }
        public IActionResult Time()
        {
            ViewBag.ServerTime = DateTime.Now;
            return View("Time");
        }

        public IActionResult CheckPhone(string phone)
        {
            _logger.LogInformation($"--------\r\ncheck phone:{phone}\r\n--------");
            var result = true;
            var message = "pass";
            if (string.IsNullOrWhiteSpace(phone))
            {
                result = false;
                message = "phone is empty";
                _logger.LogError($"--------\r\ncheck phone:{message}\r\n--------");
            }
            else if (phone.Trim().Length != 11)
            {
                result = false;
                message = "wrong phone length";
                _logger.LogWarning($"--------\r\ncheck phone:{message}\r\n--------");
            }
            return Json(new { result = result, phone = phone, message = message });
        }
    }
}
