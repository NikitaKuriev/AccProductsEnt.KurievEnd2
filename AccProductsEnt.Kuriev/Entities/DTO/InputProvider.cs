using System.ComponentModel.DataAnnotations;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputProvider
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "ИНН")]
        public int TIN { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Адресс")]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Название поставляемого сырья")]
        public string NameOfSuppliedRaw { get; set; }
    }
}
