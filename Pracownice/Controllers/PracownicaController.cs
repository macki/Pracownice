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
            ViewData["Telefon"] = dziewczyna.TelephoneNumber;
            ViewData["Email"] = dziewczyna.Email;
            ViewData["Skype"] = dziewczyna.SkypeNumber;
            ViewData["Oczy"] = dziewczyna.Eye;
            ViewData["Hair"] = dziewczyna.Hair;
            ViewData["Godziny"] = dziewczyna.workingHours;

        }

        // GET: /Pracownica/OfertaPolaDisplay
        public ActionResult UslugiDisplay(int id)
        {
            var dziewczynaUslugi = storeDb.Pracownice.Find(id).Uslugi;

            return PartialView(dziewczynaUslugi.ToList());
        }

        public ActionResult AccountMenager()
        {
            if (User.Identity.IsAuthenticated)
            {
                //TODO get pracownica
                var pracownica = storeDb.Pracownice.Where(m => m.Name == User.Identity.Name)
                            .Single();

                return View(pracownica); 
            }
            else
            {
                return View("Index");
            }

        }

    }
}
