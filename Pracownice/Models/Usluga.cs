using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracownice.Models
{
    public class Usluga
    {
        public int UslugaID { get; set; }
        public int PracownicaUslugiID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int Prize { get; set; }
        public string Time { get; set; }

        public bool Active { get; set; }
        public bool Active2 { get; set; }

        public virtual PracownicaUslugi pracownicaUslugi { get; set; }
    }
}