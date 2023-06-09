using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputStorage
    {
        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Название склада")]
        public string StorageName { get; set; }

        [Required]
        [Display(Name = "Дата поступления")]
        [DataType(DataType.Date)]
        public DateTime ReseiptDate { get; set; }

        [Required]
        [Display(Name = "Карточки")]
        public int SelectedValueAccoundCard { get; set; }


    }
}
