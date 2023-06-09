using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputClient
    {
        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Полное Имя (ФИО)")]
        public string FullName { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "ИНН")]
        public string TIN { get; set; }
    }
}
