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

        /// <summary>
        /// Removing photo from gallery
        /// </summary>
        /// <param name="pracownica"></param>
        void RemovePhotoGallery(Pracownica pracownica, int photoId);

        /// <summary>
        /// Gets photo files of given pracownica
        /// </summary>
        /// <param name="pracownicaId"></param>
        /// <returns></returns>
        IEnumerable<File> GetPhotoFiles(int pracownicaId);

        /// <summary>
        /// Sets additional enitites in updated model [HACK::]
        /// </summary>
        /// <param name="pracownicaEdited"></param>
        /// <returns></returns>
        Pracownica UpdateModel(Pracownica pracownicaEdited);

    }
}
