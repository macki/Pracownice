using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Pracownice.Utils
{
    public static class ImageHelper
    {
        private static bool ThumbnailCallback()
        {
            return true;
        }

        public static Image CreateThumbnails(string inputFile)
        {
            Image pThumbnail = null;

            try
            {
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Image image = new Bitmap(inputFile);

                //TODO Resize function
                pThumbnail = image.GetThumbnailImage(100, 150, callback, new IntPtr());
            }
            catch (Exception e)
            {
                return pThumbnail;
            }

            return pThumbnail;
        }
    }
}