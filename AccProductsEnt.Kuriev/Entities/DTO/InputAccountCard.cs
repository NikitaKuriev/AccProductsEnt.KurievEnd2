using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputAccountCard
    {
        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Название карточки учета")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Дата поступления")]
        [DataType(DataType.Date)]
        public DateTime ReseiptDate { get; set; }

        [Required]
        [Display(Name = "Дата реализации")]
        [DataType(DataType.Date)]
        public DateTime ImplementationDate { get; set; }


        [Required]
        [Display(Name = "Реализовано")]
        public int Implemented { get; set; }

        [Required]
        [Display(Name = "Остаток")]
        public int Remainder { get; set; }
    }
}
