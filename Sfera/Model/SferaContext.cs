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

    }
}
