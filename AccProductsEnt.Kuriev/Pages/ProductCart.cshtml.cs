using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ProductCartModel : PageModel
    {
        public string ProductName { get; set; }

        public string ImgPath { get; set; }

        public string Description { get; set; }

        public string PricePerPiece { get; set; }

        public string ProductId { get; set; }

        public void OnGet()
        {
        }
    }
}
