using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pracownice.Models;


// Testowanie Metod zapewniających dostep do bazy danych
//
//  1. GetPracownica(int id)
//

namespace Pracownice.Tests.Db
{
    [TestClass]
    public class DbTest
    {
        DBHelper.DbHelper dbHelper = new DBHelper.DbHelper();

        [TestMethod]
        public void GetPracownica_Test1()
        {
            int id = 1;

            var PracownicaList = new List<Pracownica>() { new Pracownica { Name = "asd" } };
            

            var pracownicaDbHelper = dbHelper.GetPracownica(id);

           // Assert.AreEqual(pracownicaDb, pracownicaDbHelper);
        }
    }
}
