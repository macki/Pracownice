using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using Pracownice.Models;
using Pracownice;

namespace Pracownice.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<PracowniceEntities>
    {
        protected override void Seed(PracowniceEntities context)
        {
            var baseUrlMainPhoto = MyConfig.baseUrl + "/Files/images/";
            var thumbPhoto = MyConfig.baseUrl + "/Files/miniaturki/";

            #region Pola Oferty

            var PolaOferty = new List<PolaOferty>
            { 
               new PolaOferty { NameOfYellowField = "Miasto", IdOfYellowField = 1},
               new PolaOferty { NameOfYellowField = "Wiek", IdOfYellowField = 3},
               new PolaOferty { NameOfYellowField = "Wzrost", IdOfYellowField = 4},
               new PolaOferty { NameOfYellowField = "Biust", IdOfYellowField = 5},
               new PolaOferty { NameOfYellowField =  "Znane języki", IdOfYellowField = 6},
               new PolaOferty { NameOfYellowField = "Telefon", IdOfYellowField = 7},
               new PolaOferty { NameOfYellowField =  "Email", IdOfYellowField = 8},
               new PolaOferty { NameOfYellowField =  "Skype", IdOfYellowField = 9},
               new PolaOferty { NameOfYellowField =  "Godziny pracy", IdOfYellowField = 10}
            };

            PolaOferty.ForEach(d => context.Oferta.Add(d));

            context.SaveChanges();

            #endregion

            #region Pracownice Data

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
                                   
                                    MainPhotoUrl = baseUrlMainPhoto + "1.jpg",
                                    HeaderDescription = "Zapraszamy Państwa do urozmaicenia swojego pobytu na Mazurach. Proponujemy miejsocowość Ruciane Nida jako 'wrota mazur' w Porcie U FARYJA. Organizujemy rejsy statkami FARYJ I, FARYJ II oraz statkiem BĄBEL po Wielkich Jeziorach Mazurskich, a także organizujemy dla Państwa indywidualną ofertę podróży po akwenach Mazur."
                },
                                    
            

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
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "2.jpg",
                                        HeaderDescription = "Zapraszamy Państwa do urozmaicenia swojego pobytu na Mazurach. Proponujemy miejsocowość Ruciane Nida jako 'wrota mazur' w Porcie U FARYJA. Organizujemy rejsy statkami FARYJ I, FARYJ II oraz statkiem BĄBEL po Wielkich Jeziorach Mazurskich, a także organizujemy dla Państwa indywidualną ofertę podróży po akwenach Mazur."
                },
            
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
            context.SaveChanges();

            #endregion

            #region Files 

            var files1 = new List<File>
            {
                new File { PracownicaId = 1,
                           Description = "a1",
                           thumbUrl = thumbPhoto + "1.jpg",
                           Url = baseUrlMainPhoto + "1.jpg",
                           pracownica = pracownice.Single( p => p.PracownicaID == 1)
                },

                new File { PracownicaId = 1,
                           Description = "a1",
                           thumbUrl = thumbPhoto + "1.jpg",
                           Url = baseUrlMainPhoto + "2.jpg",
                           pracownica = pracownice.Single( p => p.PracownicaID == 1)
                },

                new File { PracownicaId = 1,
                           Description = "a2",
                           thumbUrl = thumbPhoto + "1.jpg",
                           Url = baseUrlMainPhoto + "3.jpg",
                           pracownica = pracownice.Single( p => p.PracownicaID == 1)
                },

                new File { PracownicaId = 2,
                           Description = "a2",
                           pracownica = pracownice.Single( p => p.PracownicaID == 2)
                },

                new File { PracownicaId = 3,
                           Description = "a3",
                           pracownica = pracownice.Single( p => p.PracownicaID == 3)
                }

            };

            files1.ForEach(a => context.Files.Add(a));

            context.SaveChanges();

            #endregion Files


        }
    }
}