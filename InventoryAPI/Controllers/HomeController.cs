using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Description;

namespace InventoryAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [Route("")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ActionResult LoadSwaggerUI()
        {
            return Redirect("/swagger/ui/index");
        }
    }
}
