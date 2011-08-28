using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

using Pracownice.Models.pracownica;

namespace Pracownice.Controllers
{
    public class HomeController : Controller
    {
        Pracownice.Models.PracowniceEntities storeDb = new Models.PracowniceEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var laski = storeDb.Pracownice.ToList();
                 
            return View(laski);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
