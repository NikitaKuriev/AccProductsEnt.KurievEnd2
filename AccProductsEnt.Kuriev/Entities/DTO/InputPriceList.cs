using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputPriceList
    {
        [Required]
        [StringLength(100)]
        [Display(Name = " Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Цена за шт")]
        public decimal PricePerPiece { get; set; }

        [Required]
        [Display(Name = "Клиент")]
        public int SelectValueListClient { get; set; }

    }
}
