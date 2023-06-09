using System.ComponentModel.DataAnnotations;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputProduct
    {
        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Название")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Количество")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Дата производства")]
        [DataType(DataType.Date)]
        public DateTime DateOfManufacture { get; set; }

        [Required]
        [Display(Name = "Цена за штуку")]
        public decimal PricePerPiece { get; set; }

        
        [Display(Name = "Путь картинки")]
        public string ImgPath { get; set; }

        [Required]
        [Display(Name = "Цех")]
        public int SelectValueListWorkshop { get; set; }

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
