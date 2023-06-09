using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ClientModel : PageModel
    {
        private readonly IClientService _clientService;

        [BindProperty]
        public InputClient InputModel { get; set; }

        public ClientModel(IClientService clientService)
        {
            _clientService = clientService;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var client = new Client()
            {
               FullName = InputModel.FullName,
               TIN = InputModel.TIN
            };
            _clientService.AddClient(client);
            return Page();
        }
    }
}
