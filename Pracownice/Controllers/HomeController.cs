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

        // GET: /Index/
        public ActionResult Index(int id = -1)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            if (id == -1)
            {
                var pracowniceAll = GetMainPagePracownice(20);
                return View(pracowniceAll);
            }

            var pracownice = GetMainPagePracowniceMiasto(20, id + 1);
            return View(pracownice);
        }

        /// <summary>
        /// Taking picture on the main page TODO::Wrzucic do DbHelpera
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private List<Pracownica> GetMainPagePracownice(int count)
        {
            return storeDb.Pracownice
                .Take(count)
                .ToList();
        }

        /// <summary>
        /// Taking picture on the main page TODOLL wrzuci do DBHelper
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private List<Pracownica> GetMainPagePracowniceMiasto(int count, int indexCity)
        {
            var city = storeDb.BazowaListaMiast.Find(indexCity);

            return storeDb.Pracownice
                .Where(m => m.City == city.NazwaMiasta)
                .Take(count)
                .ToList();
        }
    }
}
