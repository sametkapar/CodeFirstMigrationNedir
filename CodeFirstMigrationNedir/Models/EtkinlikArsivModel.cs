using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstMigrationNedir.Models
{
    public partial class EtkinlikArsivModel : DbContext
    {
        public EtkinlikArsivModel()
            : base("name=EtkinlikArsivModel")
        {
        }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Soru> Sorular { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
//package manager console dan kullan�caz.
//entity framworku update etmen gerekir.

//package manager console'dan yaz�ca��m�z kodlar
//enable-migrations

//S�n�f olu�turulduktan sonra dbset yaz�lmal�d�r.
//tablo olu�turmak i�in update-database yaz�lmal�d�r.