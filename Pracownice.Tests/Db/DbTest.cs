using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pracownice.Models;


// Testowanie Metod zapewniających dostep do bazy danych
//
//  1. GetPracownica(int id)
//  2. Updated Data Pracownica
//  3. Add new Pracownica
//  4. Remove Pracownica

namespace Pracownice.Tests.Db
{
    [TestClass]
    public class DbTest
    {
        DBHelper.DbHelper dbHelper = new DBHelper.DbHelper();
        int id = 1;

        [TestMethod]
        public void GetPracownica_Test1()
        {
            var pracownicaDb = dbHelper.GetPracownica(id);
            Assert.AreEqual(pracownicaDb.PracownicaID, id);
        }

        [TestMethod]
        public void UpdatedPracownica_Test2()
        {
            var name = dbHelper.GetPracownica(id).Name;
            var pracownicaDbEdited = dbHelper.GetPracownica(id);
            pracownicaDbEdited.Name = "new Name_" + DateTime.Now;

            dbHelper.SaveChange();
            Assert.AreNotEqual(name, pracownicaDbEdited.Name);
        }

        [TestMethod]
        public void AddPracownica_Test3()
        {
            var countRecords = DBHelper.DbHelper.DbStore.Pracownica.Count();

            dbHelper.Add(new Pracownica());
            dbHelper.SaveChange();
            Assert.AreNotEqual(countRecords, DBHelper.DbHelper.DbStore.Pracownica.Count());
        }

        [TestMethod]
        public void DeletePracownica_Test4()
        {
            int countRecords = DBHelper.DbHelper.DbStore.Pracownica.Count();

            dbHelper.Delete(dbHelper.GetPracownica(5));
            dbHelper.SaveChange();
            Assert.AreNotEqual(countRecords, DBHelper.DbHelper.DbStore.Pracownica.Count());
        }
    }
}
