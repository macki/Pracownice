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
        #region Uniwersalne

        int SaveChange();
        /// <summary>
        /// Edit 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Attach<T>(T entity) where T : class;
        T Add<T>(T entity) where T : class;
        T Delete<T>(T entity) where T : class;

        #endregion
        #region Pracownica

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
        /// Gets number of Pracownica from specified city
        /// </summary>
        /// <param name="numberOfRecords"></param>
        /// <param name="cityIndex"></param>
        /// <returns></returns>
        IEnumerable<Pracownica> GetPracownica(int numberOfRecords, int cityIndex);

        /// <summary>
        /// Sets additional enitites in updated model [HACK::]
        /// </summary>
        /// <param name="pracownicaEdited"></param>
        /// <returns></returns>
        Pracownica UpdatePracownica(Pracownica pracownicaEdited);

        /// <summary>
        /// Update Usluga entity [HACK:: SHIT]
        /// </summary>
        /// <param name="uslugaEdited"></param>
        /// <returns></returns>
        Usluga UpdateUsluga(Usluga uslugaEdited);

        #endregion
        #region Photo / PhotoGallery     
        /// <summary>
        /// Gets photo files of given pracownica
        /// </summary>
        /// <param name="pracownicaId"></param>
        /// <returns></returns>
        IEnumerable<File> GetPhotoFiles(int pracownicaId);

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
        /// Changes main photo
        /// </summary>
        /// <param name="pracownicaId"></param>
        void ChangeMainPhoto(Pracownica pracownica, string url, string filename);
        #endregion
        #region Bazowe Uslugo
        /// <summary>
        /// Gets all Bazowe Uslugi
        /// </summary>
        /// <returns></returns>
        IEnumerable<BazowaListaUslug> GetAllBazoweUslugi();
        #endregion

    }
}
