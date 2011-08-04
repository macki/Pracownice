using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Pracownice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";


            var list = new List<SelectListItem>();

            for (int i = 0; i < 10; i++)
            {
                var item = new SelectListItem();
                item.Text = "cos" + i;

                list.Add(item);
            }


            IEnumerable<SelectListItem> items = list;

            ViewBag.items = items;

            var list2 = new ListBox();

            //list2.
            
                 
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
