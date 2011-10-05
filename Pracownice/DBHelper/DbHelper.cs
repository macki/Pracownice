using System;
using System.Collections.Generic;
using System.Linq;
using Pracownice.Models;
using Pracownice.DBHelper;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace Pracownice.DBHelper
{
    public partial class DbHelper : IDbHelper
    {
        //Pracownice.Models.PracowniceEntities DbStore = new Models.PracowniceEntities();
        static public IDbContext DbStore = new PracowniceEntities();

        #region Uniwersalne
        public int SaveChange()
        {
            return DbStore.SaveChange();
        }

        public T Attach<T>(T entity) where T : class
        {
            return DbStore.Attach(entity);
        }

        public T Add<T>(T entity) where T : class
        {
            return DbStore.Add(entity);
        }

        public T Delete<T>(T entity) where T : class
        {
            return DbStore.Delete(entity);
        }
        #endregion
        #region Pracownica Entities

        public Pracownica GetPracownica(int pracownicaId)
        {
            return DbStore.Pracownica.Single(p => p.PracownicaID == pracownicaId);
        }

        public Pracownica GetPracownica(string pracownicaName)
        {
            return DbStore.Pracownica.Single(p => p.Name == pracownicaName);
        }

        public IEnumerable<Pracownica> GetPracownica(int numberOfRecords, int cityIndex)
        {
            //var city = DbStore.BazowaListaMiast.Single(m => m.BazowaListaMiastId == cityIndex);
            var city = from p in DbStore.BazowaListaMiast
                        where p.BazowaListaMiastId == cityIndex
                        select p;

            if (city.Count() == 0)
            {
                return from p in DbStore.Pracownica select p;
            }

            return DbStore.Pracownica
                .Where(m => m.City == city.FirstOrDefault().NazwaMiasta)
                .Take(numberOfRecords)
                .ToList();        
        }

        public Pracownica UpdatePracownica(Pracownica pracownicaEdited)
        {
            var pracownica = GetPracownica(pracownicaEdited.PracownicaID);

            pracownica.Age = pracownicaEdited.Age;
            pracownica.Boobs = pracownicaEdited.Boobs;
            pracownica.City = pracownicaEdited.City;
            pracownica.Email = pracownicaEdited.Email;
            pracownica.Eye = pracownicaEdited.Eye;
            pracownica.Hair = pracownicaEdited.Hair;
            pracownica.HeaderDescription = pracownicaEdited.HeaderDescription;
            pracownica.Height = pracownicaEdited.Height;
            pracownica.OfertaDescription = pracownicaEdited.OfertaDescription;
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

            DbStore.SaveChange();

            return pracownica;
        }

        public Usluga UpdateUsluga(Usluga uslugaEdited)
        {
            var usluga = DbStore.Usluga.Single( u => u.UslugaID == uslugaEdited.UslugaID);

            usluga.Name = uslugaEdited.Name;
            usluga.PracownicaID = uslugaEdited.PracownicaID;
            usluga.Prize = uslugaEdited.Prize;
            usluga.Time = uslugaEdited.Time;
            usluga.Description = uslugaEdited.Description;
            usluga.Active = false;
            DbStore.SaveChange();

            return usluga;
        }

        #endregion
        #region  Photo / PhotoGallery

        public void RemovePhotoGallery(Pracownica pracownica, int photoId)
        {
            DbStore.Delete(from p in pracownica.Files
                           where p.FileID == photoId
                           select p).Single();

            DbStore.SaveChange();

        }

        public IEnumerable<File> GetPhotoFiles(int pracownicaId)
        {
            var pracownica = GetPracownica(pracownicaId);

            return from p in pracownica.Files select p;
        }

        #endregion
        #region bazowe Uslugi
        public IEnumerable<BazowaListaUslug> GetAllBazoweUslugi()
        {
            return from p in DbStore.BazoweUslugi select p;
        }
        #endregion
    }
}
