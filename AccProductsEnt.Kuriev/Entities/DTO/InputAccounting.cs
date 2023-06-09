using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputAccounting
    {
        [Required]
        [Display(Name = "Номер накладной")]
        public int WaybillId { get; set; }

        [Required]
        [Display(Name = "Цена изделия")]
        public decimal PriceProduct { get; set; }
    }
}
