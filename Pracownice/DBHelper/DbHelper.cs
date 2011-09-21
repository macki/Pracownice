using System;
using System.Collections.Generic;
using System.Linq;
using Pracownice.Models;
using Pracownice.DBHelper;

namespace Pracownice.DBHelper
{
    public partial class DbHelper : IDbHelper
    {
        Pracownice.Models.PracowniceEntities DbStore = new Models.PracowniceEntities();

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
