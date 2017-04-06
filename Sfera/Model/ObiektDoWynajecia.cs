using System;
using System.Collections.Generic;

namespace Sfera.Model
{
    public enum TypDzialalnosci
    {
        Rozrywka,
        Odziez,
        Gastronomia,
        AGD,
        ArtykulySpozywcze,
        DomIWnetrzne
    }
    public class ObiektDoWynajecia
    {
        public int Id { get; set; }
        public Korytarz Korytarz { get; set; }
        public TypDzialalnosci TypDzialalnosci { get; set; }
        public decimal CenaWynajmu { get; set; }
        public DateTime DataPoczatkuWynajmu { get; set; }
        public DateTime? DataZakonczeniaWynajmu { get; set; }
        public virtual ICollection<Pomieszczenie> Pomieszczenia{ get; set; }
        public virtual ICollection<Stand> Standy { get; set; }
        public ObiektDoWynajecia()
        {
            Pomieszczenia = new HashSet<Pomieszczenie>();
            Standy = new HashSet<Stand>();
        }


    }
}