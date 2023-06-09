using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class AccountingModel : PageModel
    {
        [BindProperty]
        public InputAccounting InputModel { get; set; }

        private readonly IAccountingService _accountingService;

        public AccountingModel(IAccountingService accounting)
        {
            _accountingService = accounting;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var accounting = new Accounting()
            {
                WaybillId = InputModel.WaybillId,
                PriceProduct = InputModel.PriceProduct
               
            };
            _accountingService.AddAccounting(accounting);
            return Page();
        }
    }
}
