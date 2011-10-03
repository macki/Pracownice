using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web;
using Pracownice.DBHelper;
using System.Drawing;
using System.Data;
using System.Web.WebPages.Html;

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

        /// <summary>
        /// Check if model was update if yes, update model in database
        /// </summary>
        /// <param name="pracownicaEdited"></param>
        public static void CheckForUpdatedModel(Models.Pracownica pracownicaEdited)
        {
            try
            {
                dbHelper.Attach(pracownicaEdited);
                dbHelper.SaveChange();
            }
            catch (DataException)
            {
                throw new DataException("Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
        }

        /// <summary>
        /// Save file 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="server"></param>
        /// <param name="pracownica"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
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

                    //Creteate Thumb
                    CreateThumb(folderPath, fileName, server);
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

        /// <summary>
        /// Create Thumb from the picture
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="fileName"></param>
        private static void CreateThumb(string folderPath, string fileName, HttpServerUtilityBase server)
        {
            string mainPhotoUrl = "http://" +  HttpContext.Current.Request.Url.Authority + folderPath +  "/" + fileName;
            Image image = null;

            try
            {
                image = DownloadImage(mainPhotoUrl);

                Point resizeParameters = ResizeImage(image);

                var imgThumb = image.GetThumbnailImage(resizeParameters.X,
                                                       resizeParameters.Y,
                                                       null,
                                                       new IntPtr());

                var fileNameThumb = "thumb_" + fileName;
                var path = Path.Combine(server.MapPath(folderPath), fileNameThumb);

                imgThumb.Save(path);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
                 
        }

        /// <summary>
        /// Return image size as point x.width , y.height
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private static Point ResizeImage(Image image)
        {
            var scaleFactor = new Point();

            if (image.Width > image.Height)
            {
                double scale = image.Width / 100;

                scaleFactor.X = 100;
                scaleFactor.Y = (int)(image.Height / scale);
            }
            else
            {
                double scale = image.Height/ 155;

                scaleFactor.Y = 155;
                scaleFactor.X = (int)(image.Width / scale);

            }

            return scaleFactor;
        }

        /// <summary>
        /// Function to download Image from website
        /// </summary>
        /// <param name="_URL">URL address to download image</param>
        /// <returns>Image</returns>
        public static Image DownloadImage(string _URL)
        {
            Image _tmpImage = null;

            try
            {
                // Open a connection
                System.Net.HttpWebRequest _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_URL);

                _HttpWebRequest.AllowWriteStreamBuffering = true;

                // You can also specify additional header values like the user agent or the referer: (Optional)
                _HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                _HttpWebRequest.Referer = "http://www.google.com/";

                // set timeout for 20 seconds (Optional)
                _HttpWebRequest.Timeout = 20000;

                // Request response:
                System.Net.WebResponse _WebResponse = _HttpWebRequest.GetResponse();

                // Open data stream:
                System.IO.Stream _WebStream = _WebResponse.GetResponseStream();

                // convert webstream to image
                _tmpImage = Image.FromStream(_WebStream);

                // Cleanup
                _WebResponse.Close();
                _WebResponse.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
                return null;
            }

            return _tmpImage;
        }

        /// <summary>
        /// Connect pracownica properties
        /// </summary>
        /// <param name="pracownica"></param>
        /// <returns></returns>
        public static Pracownice.ViewModels.TwojeDaneModel InitializeTwojeDane(Pracownice.Models.Pracownica pracownica)
        {
            var twojeDane = new Pracownice.ViewModels.TwojeDaneModel();

            twojeDane.Names = new List<string>();
            twojeDane.Names.Add("Wiek");
            twojeDane.Names.Add("Wzrost");
            twojeDane.Names.Add("Włosy");
            twojeDane.Names.Add("Oczy");
            twojeDane.Names.Add("Biust");
            twojeDane.Names.Add("Numer Telefonu");
            twojeDane.Names.Add("Skype");
            twojeDane.Names.Add("Email");

            twojeDane.Properties = new List<string>();
            twojeDane.Properties.Add(pracownica.Age.ToString());
            twojeDane.Properties.Add(pracownica.Height.ToString());
            twojeDane.Properties.Add(pracownica.Hair);
            twojeDane.Properties.Add(pracownica.Eye);
            twojeDane.Properties.Add(pracownica.Boobs);
            twojeDane.Properties.Add(pracownica.TelephoneNumber);
            twojeDane.Properties.Add(pracownica.SkypeNumber);
            twojeDane.Properties.Add(pracownica.Email);

            twojeDane.ShowStatus = new List<bool>();
            twojeDane.ShowStatus.Add(pracownica.ShowAge);
            twojeDane.ShowStatus.Add(pracownica.ShowHeight);
            twojeDane.ShowStatus.Add(pracownica.ShowHair);
            twojeDane.ShowStatus.Add(pracownica.ShowEye);
            twojeDane.ShowStatus.Add(pracownica.ShowBoobs);
            twojeDane.ShowStatus.Add(pracownica.ShowTelephoneNumber);
            twojeDane.ShowStatus.Add(pracownica.ShowSkypeNumber);
            twojeDane.ShowStatus.Add(pracownica.ShowEmail);

            return twojeDane;
        }

    }
}