using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pracownice.DBHelper;

namespace Pracownice.ViewModels
{
    public class TwojeUslugiViewModel : Controller
    {
        //
        // GET: /YerasViewModel/
        public string Name { get; set; }
        public IEnumerable<SelectListItem> Names
        {
            get
            {
                var dbstore = new DbHelper();
                var uslugi = dbstore.GetAllBazoweUslugi();

                var selectList = new SelectList(uslugi.ToList()
                    .Select(x => new SelectListItem
                    {
                        Value = x.ToString(),
                        Text = x.ToString()
                    }
                ), "Value", "Text");

                return selectList;
            }
        }

        
    }
}
