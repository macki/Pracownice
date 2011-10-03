using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pracownice.Models
{
    public interface IDbContext
    {
        IQueryable<Pracownica> Pracownica { get; }
        IQueryable<File> Files { get;  }
        IQueryable<WyswietloneDane> Oferta { get; }
        IQueryable<Usluga> Usluga { get; }
        IQueryable<BazowaListaUslug> BazoweUslugi { get; }
        IQueryable<BazowaListaMiast> BazowaListaMiast { get; }
        int SaveChange();
        T Attach<T>(T entity) where T : class;
        T Add<T>(T entity) where T : class;
        T Delete<T>(T entity) where T : class;
    }
}
