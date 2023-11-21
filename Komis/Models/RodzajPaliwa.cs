namespace Komis.Models
{
    public class RodzajPaliwa
    {
        public int ID { get; set; }

        public string Rodzaj { get; set; }

        public string Opis { get; set; }

        public ICollection<Samochodzik> Samochodziks { get; } = new List<Samochodzik>();
    }
}
