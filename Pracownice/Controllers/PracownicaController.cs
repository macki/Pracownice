using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.IO;
using Pracownice.DBHelper;

namespace Pracownice.Controllers
{
    public class PracownicaController : Controller
    {
        Pracownice.Models.PracowniceEntities storeDb = new Models.PracowniceEntities();
        DbHelper dbHelper = new DbHelper();
 
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

        // GET: /Pracownica/OfertaPolaDisplay
        public ActionResult UslugiDisplay(int id)
        {
            var dziewczynaUslugi = storeDb.Pracownice.Find(id).Uslugi;

            return PartialView(dziewczynaUslugi.ToList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// HACK:: Could work better
        public ActionResult AccountMenager(Pracownice.Models.Pracownica pracownicaEdited)
        {
            if (User.Identity.IsAuthenticated)
            {
                CheckForUpdatedModel(pracownicaEdited);
                var pracownica = storeDb.Pracownice.Where(m => m.Name == User.Identity.Name).Single();

                return View(pracownica); 
            }
            else
            {
                return View("Index");
            }

        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult SaveProfileImage(HttpPostedFileBase file)
        {
            if (User.Identity.IsAuthenticated)
            {
                var pracownica = dbHelper.GetPracownica(User.Identity.Name); 

                // Verify that the user selected a file
                if (Utils.UtilHelper.SaveFile(file,Server, pracownica, Utils.EnumHelper.photoDestination.mainPhoto))
                {
                    return View("AccountMenager", pracownica); 
                }

                return View("AccountMenager_ErrorFile", pracownica); 
            }

            return View("Index");
        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult SaveGalleryImage(HttpPostedFileBase file)
        {
            if (User.Identity.IsAuthenticated)
            {
                var pracownica = dbHelper.GetPracownica(User.Identity.Name);

                // Verify that the user selected a file
                if (Utils.UtilHelper.SaveFile(file, Server, pracownica, Utils.EnumHelper.photoDestination.galleryPhoto))
                {
                    return View("AccountMenager", pracownica);
                }

                return View("AccountMenager_ErrorFile", pracownica);
            }

            return View("Index");
        }

        #region helpers methods

        /// <summary>
        /// Check if model was changed by the user
        /// </summary>
        /// <param name="pracownicaEdited"></param>
        private void CheckForUpdatedModel(Models.Pracownica pracownicaEdited)
        {
            if (pracownicaEdited.Uslugi != null && pracownicaEdited.Name != null)   // Pracownica was edited
            {
                try
                {
                    storeDb.Entry(pracownicaEdited).State = EntityState.Modified;
                    storeDb.SaveChanges();
                }
                catch (DataException)
                {
                    //Log the error (add a variable name after DataException)
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                } 
            }
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
            ViewData["Godziny"] = dziewczyna.WorkingHours;

        }

        #endregion
    }
}
