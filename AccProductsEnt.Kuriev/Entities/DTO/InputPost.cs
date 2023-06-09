using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputPost
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Название должности")]
        public string PostTitle { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Должностные обязанности")]
        public string JobResponsibilities { get; set; }

        [Required]
        [Display(Name = "Сотрудник")]
        public int SelectValueListStaff { get; set; }
    }
}
