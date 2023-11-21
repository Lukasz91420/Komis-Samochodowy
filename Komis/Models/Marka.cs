namespace Komis.Models
{
    public class Marka
    {
        public int ID { get; set; }

        public string NAzwa { get; set; }

        public string Opis { get; set; }

        public ICollection<Samochodzik> Samochodziks { get; } = new List<Samochodzik>();
    }
}
