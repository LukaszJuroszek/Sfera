using System.Collections;
using System.Collections.Generic;

namespace Sfera.Model
{
    public class Obiekt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string NazwaTechniczna { get; set; }
        public virtual ICollection<Poziom> Poziomy { get; set; }
        public virtual ICollection<Parking> Parkingi { get; set; }
        public Obiekt()
        {
            Poziomy = new HashSet<Poziom>();
            Parkingi = new HashSet<Parking>();
        }
    }
}