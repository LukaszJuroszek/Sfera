using System.Collections;
using System.Collections.Generic;

namespace Sfera.Model
{
    public enum TypPomieszczenia
    {
        Pomieszczenie,
        Stand,
        Inne
    }
    public class Obiekt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string NazwaTechniczna { get; set; }
        public TypPomieszczenia TypPomieszczenia { get; set; }
        public virtual ICollection<Poziom> Poziomy { get; set; }
        public virtual ICollection<Parking> Parkingi { get; set; }
        public Obiekt()
        {
            Poziomy = new HashSet<Poziom>();
            Parkingi = new HashSet<Parking>();
        }
    }
}