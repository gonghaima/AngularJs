using System.Collections.Generic;
using System.Web.Mvc;
using MvcWithAngularJs.Models;

namespace MvcWithAngularJs.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var response = new List<TestObj>();
            TestObj obj = new TestObj
            {
                Description = "Initial Value",
                Id = 1
            };
            response.Add(obj);
            return View(response);
        }

        [HttpPost]
        public ActionResult UpdateVwMdl()
        {
            var response = new List<Models.TestObj>();
            var obj = new TestObj
            {
                Description="Call back value 1",
                Id=1
            };
            var obj2 = new TestObj
            {
                Description = "Call back value 2",
                Id = 2
            };
            response.Add(obj);
            response.Add(obj2);
            return Json(response);
        }

    }
}
