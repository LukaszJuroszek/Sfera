using System.Collections;
using System.Collections.Generic;

namespace Sfera.Model
{
    public class Poziom : Obiekt
    {
        public Obiekt Obiekt { get; set; }
        public double PowierzchniaCalkowita { get; set; }
        public virtual ICollection<Korytarz> Korytarze{ get; set; }
        public Poziom()
        {
            Korytarze = new HashSet<Korytarz>();
        }
    }
}
