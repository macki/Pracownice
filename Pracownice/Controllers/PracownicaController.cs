using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.IO;
using Pracownice.DBHelper;
using Pracownice.ViewModels;
using Pracownice.Models;

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

        // GET: /Pracownica/
        [HttpGet]
        public ActionResult Imie(String id)
        {
            var dziewczyna = this.dbHelper.GetPracownica(id);
            return View("Index",dziewczyna);
        }

        // GET: /Pracownica/OfertaPolaDisplay
        public ActionResult Dane(int id)
        {
            var pracownica = dbHelper.GetPracownica(id);
            var twojeDaneModel = Utils.UtilHelper.InitializeTwojeDane(pracownica);
            return PartialView(twojeDaneModel);
        }

        // GET: /Pracownica/OfertaPolaDisplay
        public ActionResult UslugiDisplay(int id)
        {
            var dziewczynaUslugi = storeDb.Pracownice.Find(id).Uslugi;
            return PartialView(dziewczynaUslugi.ToList());
        }

        /// <summary>
        /// Account Manager
        /// </summary>
        [HttpGet]
        public ActionResult AccountManager(string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var pracownica = this.dbHelper.GetPracownica(id);
                return View(pracownica); 
            }
            else
            {
                return View("Index");
            }

        }

        // POST: /Pracownica/EditPracownica
        [HttpPost]
        public ActionResult EditPracownica(Pracownice.Models.Pracownica pracownicaEdited)
        {
            if (User.Identity.IsAuthenticated)
            {
                var pracownica = dbHelper.UpdatePracownica(pracownicaEdited);
                return View("AccountManager", pracownica);
            }

            return View("Index");
        }

        // GET: /Pracownica/UslugiEdit
        public ActionResult UslugiEdit(Usluga usluga)
        {
            return PartialView("../AccountMenager/_EditTwojeUslugi", usluga);
        }

        [HttpPost]
        public ActionResult EditPracownicaTwojeUslugi(Usluga usluga)
        {
            try
            {
                dbHelper.UpdateUsluga(usluga);
            }
            catch (Exception e)
            {
                new Exception(e.Message);
            }

            return View("AccountManager", dbHelper.GetPracownica(usluga.PracownicaID));
        }

        // GET: /Pracownica/GetUslugi
        public ActionResult BazoweUslugi()
        {
           //TODO what is going on here?
            return PartialView();
        }

        #region Twoje Zdjecia 

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
                    dbHelper.SaveChange();
                    return View("AccountManager", pracownica); 
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

                if (pracownica.Files.Count <= 5)
                {
                    // Verify that the user selected a file
                    if (Utils.UtilHelper.SaveFile(file, Server, pracownica, Utils.EnumHelper.photoDestination.galleryPhoto))
                    {
                        dbHelper.SaveChange();
                        return View("AccountManager", pracownica);
                    }

                    return View("AccountManager_ErrorFile", pracownica);
                }

                return View("AccountMenager_ErrorFile", pracownica);
            }
            return View("Index");
        }

        // Removing photo from gallery
        [HttpPost]
        public ActionResult RemoveGalleryImage(int pracownicaId, int photoId)
        {
            //TODO removing photo from the server
            dbHelper.RemovePhotoGallery(dbHelper.GetPracownica(pracownicaId), photoId);
            return View();
        }

        #endregion
    }
}
