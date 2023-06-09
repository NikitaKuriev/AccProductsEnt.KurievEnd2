using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class AccountCardModel : PageModel
    {
        [BindProperty]
        public InputAccountCard InputModel { get; set; }

        private readonly IAccountCardService _accountCardService;

        public AccountCardModel(IAccountCardService accountCardService)
        {
            _accountCardService = accountCardService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) 
                return Page();
            var accountCard = new AccountCard()
            {
                Name = InputModel.Name,
                ReseiptDate = InputModel.ReseiptDate,
                ImplementationDate = InputModel.ImplementationDate,
                Implemented = InputModel.Implemented,
                Remainder = InputModel.Remainder
            };
            _accountCardService.AddAccountCard(accountCard);
            return Page();
        }
    }
}
