using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracownice.Models
{
    public class PracownicaUslugi
    {
        public int PracownicaUslugiID {get; set;}
        public int PracownicaID { get; set; }

        public virtual List<Usluga> Uslugi { get; set; }
    }
}