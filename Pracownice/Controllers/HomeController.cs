using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

using Pracownice.Models;

namespace Pracownice.Controllers
{
    public class HomeController : Controller
    {
        Pracownice.Models.PracowniceEntities storeDb = new Models.PracowniceEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var pracownice = GetMainPagePracownice(20);

            return View(pracownice);
        }

        /// <summary>
        /// Taking picture on the main page
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private List<Pracownica> GetMainPagePracownice(int count)
        {
            return storeDb.Pracownice
                .Take(count)
                .ToList();
        }
    }
}
