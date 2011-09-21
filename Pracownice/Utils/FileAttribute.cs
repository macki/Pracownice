using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pracownice.Utils
{
    public class FileAttribute : ValidationAttribute
    {
        public FileAttribute(): base(@"^.+\.((jpg)|(gif)|(png)|(jpeg))$")
        {
            this.ErrorMessage = "Please provide a valid Extension";
        }
    }
}