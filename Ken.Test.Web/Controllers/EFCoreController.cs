using System;
using Microsoft.AspNetCore.Mvc;
using Ken.Test.Web.Models;
using Ken.Test.Web.Respositories;

namespace Ken.Test.Web.Controllers
{
    public class EFCoreController : Controller
    {
        public TestRepository Repository { get; set; }

        public EFCoreController(TestRepository repository)
        {
            this.Repository = repository;
        }

        public IActionResult Add(UserEntity user)
        {
            var message = Repository.Add(user) > 0 ? "success" : "failed";
            return Json(new { message = message, User = user });
        }

        public IActionResult Delete(int id)
        {
            var message = Repository.Delete(id) > 0 ? "success" : "failed";
            return Json(new { message = message });
        }

        public IActionResult Update(UserEntity user)
        {
            var message = Repository.Update(user) > 0 ? "success" : "failed";
            return Json(new { message = message, User = user });
        }

        public IActionResult QUeryById(int id)
        {
            var user = Repository.QueryById(id);
            return Json(new { User = user });
        }

        public IActionResult QUeryByAge(int age)
        {
            var users = Repository.QueryByAge(age);
            return Json(new { Users = users });
        }

        public IActionResult QUeryNameByAge(int age)
        {
            var names = Repository.QueryNameByAge(age);
            return Json(new { Names = names });
        }

        public IActionResult QUeryUserPaging(int pagesize, int page)
        {
            var users = Repository.QueryUserPaging(pagesize, page);
            return Json(new { Users = users });
        }

        public IActionResult FixAge()
        {
            var count = Repository.FixAge();
            return Json(new { FixCount = count });
        }
    }
}
