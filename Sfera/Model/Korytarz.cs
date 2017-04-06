using System.Collections.Generic;

namespace Sfera.Model
{
    public class Korytarz 
    {
        public ICollection<ObiektDoWynajecia> ObiektyDoWynajecia{ get; set; }
        public ICollection<PomieszczenieTechniczne> PomieszczeniaTechniczne{ get; set; }
        public Korytarz()
        {
            ObiektyDoWynajecia = new HashSet<ObiektDoWynajecia>();
            PomieszczeniaTechniczne = new HashSet<PomieszczenieTechniczne>();
        }
    }
}
