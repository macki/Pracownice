using System.Collections.Generic;

namespace Pracownice.Models
{
    public class Pracownica
    {
        public int PracownicaID { get; set; }
        public string Name { get; set; }

        public string TelephoneNumber{ get; set; }
        public string SkypeNumber { get; set; }
        public string Email { get; set; }

        public string City { get; set; }
        public string Region { get; set; }

        public int Age { get; set; }
        public string Hair { get; set; }
        public string Eye { get; set; }
        public int Height { get; set; }
        public string Boobs { get; set; }
        public string workingHours { get; set; }

        public string MainPhotoUrl { get; set; }
        public string HeaderDescription { get; set; }
        public string OfertaDescription { get; set; }
       
        public virtual ICollection<File> Files { get; set; }
    }
}