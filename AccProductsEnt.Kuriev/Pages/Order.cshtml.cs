using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly IImplementationsService _implementationsService;
        private readonly IClientService _clientService;
        [BindProperty]
        public InputOrder InputModel { get; set; }
        
        public List<SelectListItem> ImplementationItems { get; set; }
        public List<SelectListItem> ClientItems { get; set; }
        public OrderModel(IOrderService orderService, IImplementationsService implementationsService, IClientService clientService)
        {
            _orderService = orderService;
            _implementationsService = implementationsService;
            _clientService = clientService;
            LoadImplementation();
            LoadtClient();
        }

        private void LoadImplementation()
        {
            List<Implementation> implementations = _implementationsService.GetImplementationsAll();
            ImplementationItems = implementations.Select(i => new SelectListItem
            {
                Value = i.Id.ToString(),
                Text = i.ImplementationDate.ToString()
            })
            .ToList();
            ImplementationItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }
        private void LoadtClient()
        {
            List<Client> clients = _clientService.GetClientsAll();
            ClientItems = clients.Select(i => new SelectListItem
            {
                Value = i.Id.ToString(),
                Text = i.FullName
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

            var order = new Order()
            {
                Name = InputModel.Name,
                Quantity = InputModel.Quantity,
                OrdersDate = InputModel.OrdersDate,
                Cost = InputModel.Cost,
                ImplementationId = InputModel.SelectValueListImplementation,
                ClientId = InputModel.SelectValueListClient
            };
            _orderService.AddOrder(order);
            return Page();
        }
    }
}
