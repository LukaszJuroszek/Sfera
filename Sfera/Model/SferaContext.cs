using System.Data.Entity;

namespace Sfera.Model
{
    public class SferaContext :DbContext
    {
        public DbSet<Obiekt> Obiekty { get; set; }
        public DbSet<Korytarz> Korytarze { get; set; }
        public DbSet<ObiektDoWynajecia> ObiektyDoWynajecia { get; set; }
        public DbSet<Parking> Parkingi { get; set; }
        public DbSet<Pomieszczenie> Pomieszczenia { get; set; }
        public DbSet<PomieszczenieTechniczne> PomieszczeniaTechniczne { get; set; }
        public DbSet<Poziom> Poziomy { get; set; }
        public DbSet<Stand> Standy { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Obiekt>().HasMany(o => o.Parkingi).WithOptional(p => p.Obiekt);
            modelBuilder.Entity<Obiekt>().HasMany(o => o.Poziomy).WithOptional(p=>p.Obiekt);
            modelBuilder.Entity<Poziom>().HasMany(o => o.Korytarze).WithOptional(k=>k.Poziom);
            modelBuilder.Entity<Korytarz>().HasMany(o => o.ObiektyDoWynajecia).WithOptional(p=>p.Korytarz);
            modelBuilder.Entity<Korytarz>().HasMany(o => o.PomieszczeniaTechniczne).WithOptional(p => p.Korytarz); ;
            modelBuilder.Entity<ObiektDoWynajecia>().HasMany(o => o.Pomieszczenia).WithOptional(p=>p.ObiektDoWynajecia);
            modelBuilder.Entity<ObiektDoWynajecia>().HasMany(o => o.Standy).WithOptional(p => p.ObiektDoWynajecia);
            modelBuilder.Entity<Pomieszczenie>().HasOptional(o => o.ObiektDoWynajecia);
            modelBuilder.Entity<Stand>().HasOptional(o => o.ObiektDoWynajecia);

            base.OnModelCreating(modelBuilder);
        }

    }
}
