using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class RawModel : PageModel
    {
        private readonly IRawService _rwService;
        private readonly IProviderService _providerService;

        [BindProperty]
        public InputRaw InputRaw { get; set; }

        public List<SelectListItem> SelectProviderItems { get; set; }

        public RawModel(IRawService rwService, IProviderService providerService)
        {
            _rwService = rwService;
            _providerService = providerService;
            LoadRaw();
        }
        private void LoadRaw()
        {
            List<Provider> raws = _providerService.GetAllProviders();

            SelectProviderItems = raws.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.FullName
            })
            .ToList();
            SelectProviderItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var raw = new Raw()
            {
                RawName = InputRaw.RawName,
                Quantity = InputRaw.Quantity,
                PriceRaw = InputRaw.PriceRaw,
                ReceiptDate = InputRaw.ReceiptDate,
                ProviderId = InputRaw.SelectProviderItem
            };
            _rwService.AddRaw(raw);
            return Page();
        }
    }
}
