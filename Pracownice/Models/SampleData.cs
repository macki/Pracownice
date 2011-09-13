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

            #region Miasta

            var listaMiast = new List<BazowaListaMiast>
            {
                new BazowaListaMiast{NazwaMiasta = "Andrychów"},
                new BazowaListaMiast{NazwaMiasta = "Bielsko-Biała"},
                new BazowaListaMiast{NazwaMiasta = "Cieszyn" },
                new BazowaListaMiast{NazwaMiasta = "Chorzów"},
                new BazowaListaMiast{NazwaMiasta = "Warszawa"},
                new BazowaListaMiast{NazwaMiasta = "Kraków"},
                new BazowaListaMiast{NazwaMiasta = "Augustów"},
                new BazowaListaMiast{NazwaMiasta = "Bełchatów"},
                new BazowaListaMiast{NazwaMiasta = "Białystok"},
                new BazowaListaMiast{NazwaMiasta = "Chrzanów"},
                new BazowaListaMiast{NazwaMiasta = "Elbląg"},
                new BazowaListaMiast{NazwaMiasta = "Gdańsk"},
                new BazowaListaMiast{NazwaMiasta = "Jelenia Góra" },
                new BazowaListaMiast{NazwaMiasta = "Kalisz"},
                new BazowaListaMiast{NazwaMiasta = "Łódź"},
                new BazowaListaMiast{NazwaMiasta = "Opole"},
                new BazowaListaMiast{NazwaMiasta = "Olsztyn"},
                new BazowaListaMiast{NazwaMiasta = "Pszczyna"},
                new BazowaListaMiast{NazwaMiasta = "Piła"},
                new BazowaListaMiast{NazwaMiasta = "Sopot"}
            };

            listaMiast.ForEach(m => context.BazowaListaMiast.Add(m));
            context.SaveChanges();

            #endregion

            #region Pola Oferty

            var PolaOferty = new List<WyswietloneDane>
            { 
               new WyswietloneDane { NameOfYellowField = "Miasto", IdOfYellowField = 1},
               new WyswietloneDane { NameOfYellowField = "Wiek", IdOfYellowField = 3},
               new WyswietloneDane { NameOfYellowField = "Wzrost", IdOfYellowField = 4},
               new WyswietloneDane { NameOfYellowField = "Biust", IdOfYellowField = 5},
               new WyswietloneDane { NameOfYellowField =  "Znane języki", IdOfYellowField = 6},
               new WyswietloneDane { NameOfYellowField = "Telefon", IdOfYellowField = 7},
               new WyswietloneDane { NameOfYellowField =  "Email", IdOfYellowField = 8},
               new WyswietloneDane { NameOfYellowField =  "Skype", IdOfYellowField = 9},
               new WyswietloneDane { NameOfYellowField =  "Godziny pracy", IdOfYellowField = 10}
            };

            PolaOferty.ForEach(d => context.Oferta.Add(d));

            context.SaveChanges();

            #endregion

            #region Pracownice Data

            var pracownice = new List<Pracownica>
            {
                new Pracownica {Name = "Anita sadsa dsadassadasdsa ",
                                    City = "Andrychów",  
                                    Region = "Slask",
                                    TelephoneNumber = "604 43 24 54",
                                    SkypeNumber = "Anita56",
                                    Age = 18,
                                    Boobs = "B",
                                    Eye = "Zielone",
                                    Hair = "Blond",
                                    Height = 160,
                                   
                                    workingHours ="10-12,15-18,19-22",

                                    MainPhotoUrl = baseUrlMainPhoto + "1.jpg",
                                    HeaderDescription = "Zapraszamy Państwa do urozmaicenia swojego pobytu na Mazurach. Proponujemy miejsocowość Ruciane Nida jako 'wrota mazur' w Porcie U FARYJA. Organizujemy rejsy statkami FARYJ I, FARYJ II oraz statkiem BĄBEL po Wielkich Jeziorach Mazurskich, a także organizujemy dla Państwa indywidualną ofertę podróży po akwenach Mazur.",
                                    OfertaDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque at nisl sit amet nulla tristique varius nec nec sem. Praesent lacus nisi, pulvinar in aliquet sed, sagittis sed nunc. Fusce a lobortis eros. Cras condimentum nibh vitae ipsum cursus suscipit. Nam eget lorem lorem. Vivamus ullamcorper vulputate cursus. Phasellus sed ullamcorper leo. Suspendisse accumsan diam in nisl tristique placerat. Nulla nec eleifend nulla. Cras tincidunt mi nec quam pulvinar elementum."
                },
                                    
            

                new Pracownica {Name = "Zosias sdsdsdsdd",
                                        City = "Andrychów",  
                                        Region = "Slask",
                                    
                                        TelephoneNumber = "604 43 24 54",
                                        SkypeNumber = "Anita56",
                                    
                                        Age = 18,
                                        Boobs = "B",
                                        Eye = "Zielone",
                                        Hair = "Blond",
                                        Height = 160,
                                    
                                        MainPhotoUrl = baseUrlMainPhoto+ "2.jpg",
                                        HeaderDescription = "Zapraszamy Państwa do urozmaicenia swojego pobytu na Mazurach. Proponujemy miejsocowość Ruciane Nida jako 'wrota mazur' w Porcie U FARYJA. Organizujemy rejsy statkami FARYJ I, FARYJ II oraz statkiem BĄBEL po Wielkich Jeziorach Mazurskich, a także organizujemy dla Państwa indywidualną ofertę podróży po akwenach Mazur.",
                                        OfertaDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque at nisl sit amet nulla tristique varius nec nec sem. Praesent lacus nisi, pulvinar in aliquet sed, sagittis sed nunc. Fusce a lobortis eros. Cras condimentum nibh vitae ipsum cursus suscipit. Nam eget lorem lorem. Vivamus ullamcorper vulputate cursus. Phasellus sed ullamcorper leo. Suspendisse accumsan diam in nisl tristique placerat. Nulla nec eleifend nulla. Cras tincidunt mi nec quam pulvinar elementum."
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
                                    
                                        MainPhotoUrl = baseUrlMainPhoto + "4.jpg" },

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

            foreach (var item in pracownice)
            {
                var files1 = new List<File>
                {
                    new File { PracownicaId = item.PracownicaID,
                               Description = "a1",
                               thumbUrl = thumbPhoto + "1.jpg",
                               Url = baseUrlMainPhoto + "1.jpg",
                               pracownica = pracownice.Single( p => p.PracownicaID == item.PracownicaID)
                    },

                    new File { PracownicaId = item.PracownicaID,
                               Description = "a1",
                               thumbUrl = thumbPhoto + "1.jpg",
                               Url = baseUrlMainPhoto + "2.jpg",
                               pracownica = pracownice.Single( p => p.PracownicaID == item.PracownicaID)
                    },

                    new File { PracownicaId = item.PracownicaID,
                               Description = "a2",
                               thumbUrl = thumbPhoto + "1.jpg",
                               Url = baseUrlMainPhoto + "3.jpg",
                               pracownica = pracownice.Single( p => p.PracownicaID == item.PracownicaID)
                    },

                    new File { PracownicaId = item.PracownicaID,
                               Description = "a2",
                               pracownica = pracownice.Single( p => p.PracownicaID == item.PracownicaID)
                    },

                    new File { PracownicaId = item.PracownicaID,
                               Description = "a3",
                               pracownica = pracownice.Single( p => p.PracownicaID == item.PracownicaID)
                    }
                };

                files1.ForEach(m => context.Files.Add(m));
            };

            //context.SaveChanges();

            #endregion Files

            #region Utworzenie Bazowych uslug

            var bazoweUslugi = new List<BazowaListaUslug>
            {
                new BazowaListaUslug { nazwaUslugi="Sprzątanie w bieliźnie"},
                new BazowaListaUslug { nazwaUslugi="Sprzątanie nago"},
                new BazowaListaUslug { nazwaUslugi="Mycie samochodu w bieliźnie"},
                new BazowaListaUslug { nazwaUslugi="Wyjście do kina"},
                new BazowaListaUslug { nazwaUslugi="Dziewczyna na imprezę"},
                new BazowaListaUslug { nazwaUslugi="Rozmowa na Skypie"},
                new BazowaListaUslug { nazwaUslugi="Śniadanie do łóżka"}
            };

            bazoweUslugi.ForEach(a => context.BazoweUslugi.Add(a));
            context.SaveChanges();

            #endregion

            #region

            foreach (var item in pracownice)
            {
                item.Uslugi = new List<Usluga>();

                foreach (var bU in bazoweUslugi)
                {  
                    item.Uslugi.Add( new Usluga { Name = bU.nazwaUslugi, Description = "Gotowy Text", Prize = 0, Time = null, Active = true, PracownicaID = item.PracownicaID });
                }
            }

            //pracownice.ForEach(u => context.Pracownice.Add(u));
            //context.SaveChanges();

            #endregion

            context.SaveChanges();
        }
    }
}