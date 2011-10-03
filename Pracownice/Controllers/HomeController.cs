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
        DBHelper.DbHelper dbHelper = new DBHelper.DbHelper();

        public HomeController()
        {
            //storeDb = new PracowniceEntities();
        }

        // GET: /Index/
        public ActionResult Index(int id = 0)
        {
            var pracownice = dbHelper.GetPracownica(20, id);

            return View(pracownice);
        }
    }
}
