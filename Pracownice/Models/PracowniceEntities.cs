using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

using Pracownice.Models;

namespace Pracownice.Models
{
    public class PracowniceEntities : DbContext
    {
        public DbSet<Pracownica> Pracownice { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<WyswietloneDane> Oferta { get; set; }
        public DbSet<Usluga> Usluga { set; get; }
        public DbSet<BazowaListaUslug> BazoweUslugi { set; get; }
            
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}