using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class PriceListModel : PageModel
    {
        private readonly IPriceListService _priceListService;
        private readonly IClientService _clientService;
        [BindProperty]
        public InputPriceList InputModel { get; set; }

        public List<SelectListItem> ClientItems { get; set; }

        public PriceListModel(IPriceListService priceListService, IClientService clientService)
        {
            _priceListService = priceListService;
            _clientService = clientService;
            LoadClient();
        }
        private void LoadClient()
        {
            List<Client> clients = _clientService.GetClientsAll(); 
            ClientItems = clients.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.FullName
            })
            .ToList();
            ClientItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var priceList = new PriceList()
            {
                Name = InputModel.Name,
                PricePerPiece = InputModel.PricePerPiece,
                ClientId = InputModel.SelectValueListClient
            };
           _priceListService.AddPriceList(priceList);
            return Page();
        }
    }
}
