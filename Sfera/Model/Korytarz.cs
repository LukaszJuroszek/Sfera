﻿using System.Collections.Generic;

namespace Sfera.Model
{
    public class Korytarz 
    {
        public int Id { get; set; }
        public Poziom Poziom { get; set; }
        public virtual ICollection<ObiektDoWynajecia> ObiektyDoWynajecia{ get; set; }
        public virtual ICollection<PomieszczenieTechniczne> PomieszczeniaTechniczne{ get; set; }
        public Korytarz()
        {
            ObiektyDoWynajecia = new HashSet<ObiektDoWynajecia>();
            PomieszczeniaTechniczne = new HashSet<PomieszczenieTechniczne>();
        }
    }
}
