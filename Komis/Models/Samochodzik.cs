using System.ComponentModel.DataAnnotations;

namespace Komis.Models
{
    public class Samochodzik
    {
        public int ID { get; set; }

        public int MarkaID { get; set; }

        public Marka? Marka { get; set; }
        public int ModelID { get; set; }

        public Model? Model { get; set; }

        public int RodzajNadwoziaID { get; set; }

        public RodzajNadwozia? RodzajNadwozia { get; set; }
        public int RodzajPaliwaID { get; set; }

        public RodzajPaliwa? RodzajPaliwa { get; set; }

        public string Kolor { get; set; }

        [Display(Name = "Pojemność Silnika")]
        public string PojemnośćSilnika { get; set; }
        
        public string Przebieg {  get; set; }

        public string VIN {  get; set; }

        public decimal Cena { get; set; }

  




    }
}
