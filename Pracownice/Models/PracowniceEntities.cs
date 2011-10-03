using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

using Pracownice.Models;

namespace Pracownice.Models
{
    public class PracowniceEntities : DbContext, IDbContext
    {
        public DbSet<Pracownica> Pracownice { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<WyswietloneDane> Oferta { get; set; }
        public DbSet<Usluga> Usluga { set; get; }
        public DbSet<BazowaListaUslug> BazoweUslugi { set; get; }
        public DbSet<BazowaListaMiast> BazowaListaMiast { set; get; }
            
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public IQueryable<Pracownica> Pracownica
        {
            get { return Pracownice; }
        }

        IQueryable<File> IDbContext.Files
        {
            get { return Files; }
        }

        IQueryable<WyswietloneDane> IDbContext.Oferta
        {
            get { return Oferta; }
        }

        IQueryable<Usluga> IDbContext.Usluga
        {
            get { return Usluga; }
        }

        IQueryable<BazowaListaUslug> IDbContext.BazoweUslugi
        {
            get { return BazoweUslugi; }
        }

        IQueryable<BazowaListaMiast> IDbContext.BazowaListaMiast
        {
            get { return BazowaListaMiast; }
        }

        public int SaveChange()
        {
            return SaveChanges();
        }

        public T Add<T>(T entity) where T : class
        {
            return Set<T>().Add(entity);
        }

        public T Delete<T>(T entity) where T : class
        {
            return Set<T>().Remove(entity);
        }

        public T Attach<T>(T entity) where T : class
        {
            var entry = Entry(entity);
            entry.State = System.Data.EntityState.Modified;
            return entity;
        }
    }
}