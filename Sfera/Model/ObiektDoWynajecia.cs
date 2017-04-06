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
        public TypDzialalnosci TypDzialalnosci { get; set; }
        public decimal CenaWynajmu { get; set; }
        public DateTime DataPoczatkuWynajmu { get; set; }
        public DateTime? DataZakonczeniaWynajmu { get; set; }
        public ICollection<Pomieszczenie> Pomieszczenia{ get; set; }
        public ICollection<Stand> Standy { get; set; }
        public ObiektDoWynajecia()
        {
            Pomieszczenia = new HashSet<Pomieszczenie>();
            Standy = new HashSet<Stand>();
        }


    }
}