using System;

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
    public class ObiektDoWynajecia : Korytarz
    {
        public TypDzialalnosci TypDzialalnosci { get; set; }
        public decimal CenaWynajmu { get; set; }
        public DateTime DataPoczatkuWynajmu { get; set; }
        public DateTime? DataZakonczeniaWynajmu { get; set; }
    }
}