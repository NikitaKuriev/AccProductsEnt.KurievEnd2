using AccProductsEnt.Kuriev.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Protocol.Core.Types;

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

        //public IActionResult OnPost(long productId, string returnUrl, int quantity)
        //{
        //    Product? product = products.FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        Cart?.AddItem(product, quantity);
        //    }
        //    return RedirectPermanent(returnUrl);
        //}
    }
}
