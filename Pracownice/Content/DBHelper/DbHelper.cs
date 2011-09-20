using System;
using System.Collections.Generic;
using System.Linq;

using Pracownice.Models;

namespace Pracownice.Content.DBHelper
{
    public class DbHelper : IDbHelperPracownica
    {
        Pracownice.Models.PracowniceEntities DbStore = new Models.PracowniceEntities();

        public void ChangeMainPhoto(Pracownica pracownica, string url, string filename)
        {
            pracownica.MainPhotoUrl = url + "/" + filename;

            DbStore.SaveChanges();
        }

        public Pracownica GetPracownica(int pracownicaId)
        {
            return DbStore.Pracownice.Single(p => p.PracownicaID == pracownicaId);
        }

        public Pracownica GetPracownica(string pracownicaName)
        {
            return DbStore.Pracownice.Single(p => p.Name == pracownicaName);
        }


    }
}
