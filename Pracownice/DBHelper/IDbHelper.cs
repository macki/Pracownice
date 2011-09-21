using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pracownice.Models;
using Pracownice.Utils;

namespace Pracownice.DBHelper
{
    interface IDbHelper
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

        /// <summary>
        /// Saves photo 
        /// </summary>
        /// <param name="photoDestination"></param>
        void SaveImageFile(EnumHelper.photoDestination photoDestination, string baseFolder, string filename, Pracownice.Models.Pracownica pracownica);

        /// <summary>
        /// Adds photo to gallery
        /// </summary>
        /// <param name="pracownica"></param>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        void AddPhotoGallery(Pracownica pracownica, string url, string filename);
    }
}
