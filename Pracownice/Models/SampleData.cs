using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using Pracownice.Models.pracownica;
using Pracownice;

namespace Pracownice.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<PracowniceEntities>
    {
        protected override void Seed(PracowniceEntities context)
        {
            var baseUrlMainPhoto = MyConfig.baseUrl + "/Files/images/";

            var pracownice = new List<Pracownica>
            {
                new Pracownica {Name = "Anita sadsa dsadassadasdsa ",
                                    City = "Cieszyn",  
                                    Region = "Slask",
                                    
                                    TelephoneNumber = "604 43 24 54",
                                    SkypeNumber = "Anita56",
                                    
                                    Age = 18,
                                    Boobs = "B",
                                    Eye = "Zielone",
                                    Hair = "Blond",
                                    Height = 160,
                                    
                                    MainPhotoUrl = baseUrlMainPhoto + "1.jpg" },
            

                new Pracownica {Name = "Zosias sdsdsdsdd",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "2.jpg" },
            
               new Pracownica {Name = "Basia",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "3.jpg" },

                new Pracownica {Name = "Basiassss",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "4.jpg" },

                new Pracownica {Name = "Basia dddddddddddddddddddd",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "5.jpg" },

                new Pracownica {Name = "Basia",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "6.jpg" },

               new Pracownica {Name = "seksowan asia",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "7.jpg" },

                new Pracownica {Name = "napalaona",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "8.jpg" },

                new Pracownica {Name = "NIezastapiona",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "9.jpg" },

                   new Pracownica {Name = "Ciza",
                                        City = "Cieszyn",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "10.jpg" },
            };


            pracownice.ForEach(d => context.Pracownice.Add(d));
        }
    }
}