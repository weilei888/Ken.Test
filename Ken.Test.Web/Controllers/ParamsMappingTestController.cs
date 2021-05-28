using System;
using Microsoft.AspNetCore.Mvc;
using Ken.Test.Web.Models;
using System.Collections.Generic;

namespace Ken.Test.Web.Controllers
{
    public class ParamsMappingTestController : Controller
    {
        public IActionResult GetId(int id)
        {
            return Content($"Action params mapping test by weilei,id:{id}");
        }

        public IActionResult GetArray(string[] id)
        {
            var message = "Action params mapping test2 by weilei,id:";
            if (id != null)
            {
                message += string.Join(",", id);
            }
            return Content(message);
            //调用:http://localhost:5001/pmt/getarray?id=1,2,3
            //返回：Action params mapping test2 by weilei,id:1,2,3
        }

        public IActionResult GetPerson(Person person)
        {
            return Json(new { messgae = "Action params mapping test", Data = person });
            //调用：http://localhost:5001/pmt/getperson?name=weilei&age=29
            //返回：{"messgae":"Action params mapping test","data":{"name":"weilei","age":29}}
        }

        public IActionResult GetPersonList(List<Person> person)
        {
            return Json(new { messgae = "Action params mapping test", Data = person });
            //调用：http://localhost:5001/pmt/getpersonlist?person[0].name=weilei&person[0]age=29&person[1].name=weilei2&person[1]age=32
            //返回：{"messgae":"Action params mapping test","data":[{"name":"weilei","age":0},{"name":"weilei2","age":0}]}
        }

        public IActionResult GetByHand()
        {
            return Json(new { Id = RouteData.Values["id"], Name = Request.Query["name"] });
            //调用：http://localhost:5001/pmt/getbyhand/1024?name=ken&name=weilei&age=29
            //返回：{"id":"1024","name":["ken","weilei"]}
        }
    }
}
