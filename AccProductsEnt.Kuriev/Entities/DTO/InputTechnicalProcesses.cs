using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputTechnicalProcesses
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Название процесса")]
        public string ProcessName { get; set; }

        [Required]
        [Display(Name = "Время процесса")]
        [DataType(DataType.Date)]
        public DateTime TimeOfTheEvent { get; set; }

    }
}
