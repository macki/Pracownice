using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web;
using Pracownice.DBHelper;

namespace Pracownice.Utils
{
    public static class UtilHelper
    {
        private static Random rand = new Random();
        private static DbHelper dbHelper = new DbHelper();

        public static bool ValidateImageFile(HttpPostedFileBase file)
        {
            if (file.ContentLength > 1500000) //1.5mb
            {
                return false;
            }
            if (file.ContentType == "image/jpg" ||
               file.ContentType == "image/jpeg" ||
               file.ContentType == "image/png")
            {
                return true;
            }

            return false;
        }

        public static bool SaveFile(HttpPostedFileBase file,HttpServerUtilityBase server, Pracownice.Models.Pracownica pracownica, EnumHelper.photoDestination destination )
        {
            if(ValidateImageFile(file))
            {
                //create file
                var fileName = pracownica.Name + rand.Next(0,999999) + "_" +  file.FileName;

                string folderPath;

                if(destination == EnumHelper.photoDestination.mainPhoto)
                {
                    folderPath = MyConfig.mainPhotoUrl;
                }
                else if (destination == EnumHelper.photoDestination.galleryPhoto)
                {
                    folderPath = MyConfig.mainPhotoUrl;
                }
                else
                {
                    throw new Exception("Problem with Config File || SaveFile");
                }

                //gets path
                var path = Path.Combine(server.MapPath(folderPath), fileName);

                try
                {
                    file.SaveAs(path);
                    dbHelper.SaveImageFile(destination,folderPath, fileName, pracownica);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}