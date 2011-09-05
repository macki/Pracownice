using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracownice.Controllers
{
    public class PracownicaController : Controller
    {
        Pracownice.Models.PracowniceEntities storeDb = new Models.PracowniceEntities();

 
        // GET: /Pracownica/
        public ActionResult Index(int id)
        {
            var dziewczyna = storeDb.Pracownice.Find(id);

            return View(dziewczyna);
        }

        //
        // GET: /Pracownica/OfertaPolaDisplay
        [ChildActionOnly]
        public ActionResult OfertaPolaDisply(int id)
        {
            var pola = storeDb.Oferta.ToList();
            var dziewczyna = storeDb.Pracownice.Find(id);

            AttachViewData(dziewczyna);

            return PartialView(pola);
        }

        private void AttachViewData(Models.Pracownica dziewczyna)
        {
            //TODO change null
            ViewData["Miasto"] = dziewczyna.City;
            ViewData["Wiek"] = dziewczyna.Age;
            ViewData["Wzrost"] = dziewczyna.Height;
            ViewData["Biust"] = dziewczyna.Boobs;
            ViewData["Znane języki"] = null;
            ViewData["Telefon"] = dziewczyna.TelephoneNumber;
            ViewData["Email"] = dziewczyna.Email;
            ViewData["Skype"] = dziewczyna.SkypeNumber;
            ViewData["Godziny"] = null;

        }


    }
}
