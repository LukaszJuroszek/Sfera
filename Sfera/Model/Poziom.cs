using System.Collections;
using System.Collections.Generic;

namespace Sfera.Model
{
    public class Poziom
    {
        public double PowierzchniaCalkowita { get; set; }
        public ICollection<Korytarz> Korytarze{ get; set; }
        public Poziom()
        {
            Korytarze = new HashSet<Korytarz>();
        }
    }
}
