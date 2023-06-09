using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputImplementation
    {
        [Required]
        [Display(Name = "Дата реализации")]
        [DataType(DataType.Date)]
        public DateTime ImplementationDate { get; set; }


        [Required]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Склад")]
        public int SelectValueListStorage { get; set; }

    }
}
