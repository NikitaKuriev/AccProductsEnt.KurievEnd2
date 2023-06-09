using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ImplementationsModel : PageModel
    {
        private readonly IImplementationsService _implementationsService;
        private readonly IStorageService _storageService;

        public ImplementationsModel(IImplementationsService implementationsService, IStorageService storageService)
        {
            _implementationsService = implementationsService;
            _storageService = storageService;
            LoadStorage();
        }
        [BindProperty]
        public InputImplementation InputModel { get; set; }

        public List<SelectListItem> StorageItems { get; set; }

        private void LoadStorage()
        {
            List<Storage> listStorage = _storageService.GetStoragesAll();

            StorageItems = listStorage.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.StorageName
            })
            .ToList();
            StorageItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });

        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var implementation = new Implementation()
            {
                ImplementationDate = InputModel.ImplementationDate,
                Price = InputModel.Price,
                StorageId = InputModel.SelectValueListStorage
            };
            _implementationsService.AddImplementations(implementation);

            return Page();
        }
    }
}
