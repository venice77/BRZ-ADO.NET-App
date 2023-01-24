using System.ComponentModel.DataAnnotations;

namespace BiuroRzeczyZnalezionych.Models
{
    public class PrzedmiotModel
    {
        public int ID{ get; set; }
        [Required] 
        public string Nazwa{ get; set; }
        [Required]
        public DateTime dataDodania { get; set; }
        public DateTime dataZwrotu {get; set; }
    }
}
