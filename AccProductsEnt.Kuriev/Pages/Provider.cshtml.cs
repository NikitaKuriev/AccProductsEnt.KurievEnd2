using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ProviderModel : PageModel
    {
        [BindProperty]
        public InputProvider InputModel { get; set; }

        private readonly IProviderService _providerService;

        public ProviderModel(IProviderService provider)
        {
            _providerService = provider;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var provider = new Provider()
            {
                FullName = InputModel.FullName,
                TIN = InputModel.TIN,
                Address = InputModel.Address,
                NameOfSuppliedRaw = InputModel.NameOfSuppliedRaw,

            };
            _providerService.AddProvider(provider);
            return Page();
        }
    }
}
