using System;
using System.Collections.Generic;
using System.Linq;
using Pracownice.Models;
using Pracownice.DBHelper;

namespace Pracownice.DBHelper
{
    public partial class DbHelper : IDbHelper
    {
        Pracownice.Models.PracowniceEntities DbStore = new Models.PracowniceEntities();

        public PracowniceEntities Database
        {
            get { return DbStore; }
        }

        public Pracownica GetPracownica(int pracownicaId)
        {
            return DbStore.Pracownice.Single(p => p.PracownicaID == pracownicaId);
        }

        public Pracownica GetPracownica(string pracownicaName)
        {
            return DbStore.Pracownice.Single(p => p.Name == pracownicaName);
        }

        public void RemovePhotoGallery(Pracownica pracownica, int photoId)
        {
            DbStore.Files.Remove((from p in pracownica.Files
                                     where p.FileID == photoId
                                     select p).Single());

            DbStore.SaveChanges();

        }

        public IEnumerable<File> GetPhotoFiles(int pracownicaId)
        {
            var pracownica = GetPracownica(pracownicaId);

            return from p in pracownica.Files select p;
        }

        public Pracownica UpdateModel(Pracownica pracownicaEdited)
        {
            var pracownica = GetPracownica(pracownicaEdited.PracownicaID);

            pracownica.Age = pracownicaEdited.Age;
            pracownica.Boobs = pracownicaEdited.Boobs;
            pracownica.City = pracownicaEdited.City;
            pracownica.Email = pracownicaEdited.Email;
            pracownica.Eye= pracownicaEdited.Eye;
            pracownica.Hair = pracownicaEdited.Hair;
            pracownica.HeaderDescription= pracownicaEdited.HeaderDescription;
            pracownica.Height= pracownicaEdited.Height;
            pracownica.OfertaDescription= pracownicaEdited.OfertaDescription;
            pracownica.Region = pracownicaEdited.Region;
            pracownica.ShowAge = pracownicaEdited.ShowAge;
            pracownica.ShowBoobs = pracownicaEdited.ShowBoobs;
            pracownica.ShowEmail = pracownicaEdited.ShowEmail;
            pracownica.ShowEye = pracownicaEdited.ShowEye;
            pracownica.ShowHair = pracownicaEdited.ShowHair;
            pracownica.ShowHeight = pracownicaEdited.ShowHeight;
            pracownica.ShowSkypeNumber = pracownicaEdited.ShowSkypeNumber;
            pracownica.ShowTelephoneNumber = pracownicaEdited.ShowTelephoneNumber;
            pracownica.TelephoneNumber = pracownicaEdited.TelephoneNumber;
            pracownica.SkypeNumber = pracownicaEdited.SkypeNumber;

            DbStore.SaveChanges();

            return pracownica;
        }
    }
}
