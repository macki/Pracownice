using System.Collections.Generic;

namespace Pracownice.Models
{
    public class Pracownica
    {
        public int PracownicaID { get; set; }
        public string Name { get; set; }

        public string TelephoneNumber{ get; set; }
        public bool ShowTelephoneNumber { get; set; }

        public string SkypeNumber { get; set; }
        public bool ShowSkypeNumber { get; set; }

        public string Email { get; set; }
        public bool ShowEmail { get; set; }

        public string City { get; set; }
        public string Region { get; set; }

        public int Age { get; set; }
        public bool ShowAge { get; set; }

        public string Hair { get; set; }
        public bool ShowHair { get; set; }

        public string Eye { get; set; }
        public bool ShowEye { get; set; }

        public int Height { get; set; }
        public bool ShowHeight { get; set; }

        public string Boobs { get; set; }
        public bool ShowBoobs { get; set; }

        public string WorkingHours { get; set; }
        public bool ShowWorkingHours { get; set; }

        public string MainPhotoUrl { get; set; }
        public string HeaderDescription { get; set; }
        public string OfertaDescription { get; set; }
       
        public virtual List<File> Files { get; set; }
        public virtual List<Usluga> Uslugi { get; set; }
    }
}