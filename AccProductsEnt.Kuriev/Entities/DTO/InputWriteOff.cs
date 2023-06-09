using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputWriteOff
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата списания")]
        public DateTime WriteOffDate { get; set; }

        [Required]
        [Display(Name = "Причина")]
        public string Cause { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Количество продуктов")]
        public int QuntityProduct { get; set; }

    }
}
