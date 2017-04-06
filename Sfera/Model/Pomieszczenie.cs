namespace Sfera.Model
{
    public class Pomieszczenie
    {
        public int Id { get; set; }
        public double PowierzchniaWynajmu { get; set; }
        public ObiektDoWynajecia ObiektDoWynajecia { get; set; }
    }
}
