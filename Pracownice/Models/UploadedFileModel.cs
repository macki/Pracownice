using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Pracownice.Utils;

namespace Pracownice.Models
{
    public class UploadedFileModel
    {
        public int UploadedFileModelId { get; set; }

        //[Display(Name = "Upload Proof of Address")]
        //[FileAttribute(AllowedFileExtensions = new string[] { ".jpg", ".gif", ".tiff", ".png" }, MaxContentLength = 5, ErrorMessage = "Invalid File")]
        //public HttpPostedFileBase AddressProof { get; set; }
    }
}