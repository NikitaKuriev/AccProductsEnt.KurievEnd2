using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AccProductsEnt.Kuriev.Pages
{
    public class StorageModel : PageModel
    {
        private readonly IStorageService _storageService;
        private readonly IAccountCardService _accountCardService;


        [BindProperty]
        public InputStorage InputModel { get; set; }


         public List<SelectListItem> AccoundCardItems { get; set; }


        public StorageModel(IStorageService storageService, IAccountCardService accountCardService)
        {
            _storageService = storageService;
            _accountCardService = accountCardService;
            LoadCard();
        }

        private void LoadCard()
        {
            List<AccountCard> cards = _accountCardService.GetAccountCardsAll();
            AccoundCardItems = cards.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            })
           .ToList();
            AccoundCardItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var storage = new Storage()
            {
                StorageName = InputModel.StorageName,
                ReceiptDate = InputModel.ReseiptDate,
                AccountCardId = InputModel.SelectedValueAccoundCard
            };
            _storageService.AddStorage(storage);
            return Page(); 
        }



    }
}
