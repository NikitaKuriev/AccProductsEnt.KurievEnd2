using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputWorkshop
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Название ЦЕХа")]
        public string WorkshopName { get; set; }

       

        [Required]
        [StringLength(100)]
        [Display(Name = "Название процесса")]
        public string ProccesName { get; set; }

        public int SelectlistRawItem { get; set; }
    }
}
