using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pracownice.Utils;
using Pracownice.Models;
using System.Data;

namespace Pracownice.DBHelper
{
    public partial class DbHelper : IDbHelper
    {
        public void SaveImageFile(EnumHelper.photoDestination photoDestination, string baseFolder,string filename, Pracownice.Models.Pracownica pracownica)
        {
            if (photoDestination == EnumHelper.photoDestination.mainPhoto)
            {
                ChangeMainPhoto(pracownica,baseFolder, filename);  
            }
            else if (photoDestination == EnumHelper.photoDestination.galleryPhoto)
            {
                AddPhotoGallery(pracownica, baseFolder, filename);   
            }
            else
            {
                throw new Exception("Problem with Saving File || DbHelperUtils");
            }
        }

        public void ChangeMainPhoto(Pracownica pracownica, string url, string filename)
        {
            pracownica.MainPhotoUrl = url + "/" + filename;
            //DbStore.ChangeTracker.DetectChanges();
            DbStore.SaveChanges();    
        }

        public void AddPhotoGallery(Pracownica pracownica, string url, string filename)
        {

            pracownica.Files.Add(new File { Url = url + "/" + filename,
                                        thumbUrl = "",
                                        Description = "",
                                        PracownicaId = pracownica.PracownicaID
                            });

           // DbStore.ChangeTracker.DetectChanges();
            DbStore.SaveChanges();
        }
    }
}