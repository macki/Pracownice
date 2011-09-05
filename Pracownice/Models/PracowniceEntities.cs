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
        public DbSet<PolaOferty> Oferta { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}