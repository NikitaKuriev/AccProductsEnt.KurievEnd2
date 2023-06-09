using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputRaw
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Название сырья")]
        public string RawName { get; set; }

        [Required]
        [Display(Name = "Количество")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Стоимость")]
        public decimal PriceRaw{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата поступления")]
        public DateTime ReceiptDate { get; set; }

        public int SelectProviderItem { get; set; }     
    }
}
