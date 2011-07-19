using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracownice.Models.pracownica
{
    public class PracownicaModel
    {
        public int PracownicaModelID { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string Miasto { get; set; }
        public string Wojewodztwo { get; set; }

        public int Wiek { get; set; }
        public string Wlosy { get; set; }
        public string Oczy { get; set; }
        public int Wzrost { get; set; }
        public string Biust { get; set; }
        


    }
}