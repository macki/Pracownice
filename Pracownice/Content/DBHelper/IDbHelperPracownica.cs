using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pracownice.Models;

namespace Pracownice.Content.DBHelper
{
    interface IDbHelperPracownica
    {
        /// <summary>
        /// Changes main photo
        /// </summary>
        /// <param name="pracownicaId"></param>
        void ChangeMainPhoto(Pracownica pracownica, string url, string filename);

        /// <summary>
        /// Gets praconwica by Id
        /// </summary>
        /// <param name="pracownicaId"></param>
        Pracownica GetPracownica(int pracownicaId);

        /// <summary>
        /// Gets praconwica by Name
        /// </summary>
        /// <param name="pracownicaId"></param>
        Pracownica GetPracownica(string pracownicaName);


    }
}
