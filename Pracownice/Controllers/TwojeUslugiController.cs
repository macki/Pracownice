using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pracownice.ViewModels;

namespace Pracownice.Controllers
{
    public class TwojeUslugiController : Controller
    {
        public ActionResult Index()
        {
            return View(new TwojeUslugiViewModel());
        }

        [HttpPost]
        public ActionResult Index(string uslugaName)
        {
            // TODO: do something with the selected year
            return new EmptyResult();
        }     
    }
}
