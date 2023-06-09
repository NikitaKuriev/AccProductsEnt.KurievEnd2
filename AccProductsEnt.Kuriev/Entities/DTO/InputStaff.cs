using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputStaff
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Стаж")]
        public int Experience { get; set; }

        [Required]
        [Display(Name = "Заработная плата")]
        public decimal Wage { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Адресс")]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Цех")]
        public int SelectValueListWorkshop {get; set; }
        [Required]
        [Display(Name = "Склад")]
        public int SelectValueListStorage { get; set; }
        [Required]
        [Display(Name = "Бухгалтерия")]
        public int SelectValueListAccounting { get; set; }
        [Required]
        [Display(Name = "Реализация")]
        public int SelectValueListImplementation { get; set; }


    }
}
