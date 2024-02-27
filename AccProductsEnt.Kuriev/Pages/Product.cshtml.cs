using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ProductModel : PageModel
    {

        private readonly IProductService _productService;
        private readonly IWorkshopService _workshopService;
        private readonly IStorageService _storageService;
        private readonly IAccountingService _accountingService;
        private readonly IImplementationsService _implementationsService;



        [BindProperty]
        public IEnumerable<Product> Products { get; set; }    

        [BindProperty]
        public InputProduct InputProduct { get; set; }

        [BindProperty]
        public InputProduct Input { get; set; }

        public List<SelectListItem> WorkshopItems { get; set; }
        public List<SelectListItem> StorageItems { get; set; }
        public List<SelectListItem> AccoutingItems { get; set; }
        public List<SelectListItem> ImplementationItems { get; set; }

        [BindProperty]
        public string SortProduct { get; set; }


        [BindProperty]
        public string SearchProduct { get; set; }

        public ProductModel(IProductService productService, 
            IWorkshopService workshopService, 
            IStorageService storageService, 
            IAccountingService accountingService, 
            IImplementationsService implementationsService)
        {
            _productService = productService;
            _workshopService = workshopService;
            _storageService = storageService;
            _accountingService = accountingService;
            _implementationsService = implementationsService;
            LoadWorkshop();
            LoadStorage();
            LoadAccouting();
            LoadImplementation();
        }
        private void LoadWorkshop()
        {
            List<Workshop> workshops = _workshopService.GetAllWorkshop();
            WorkshopItems = workshops.Select(w => new SelectListItem
            {
                Value = w.Id.ToString(),
                Text = w.WorkshopName
            })
            .ToList();
            WorkshopItems.Insert(0, new SelectListItem { Value = "0", Text = "�����������" });
        }
        private void LoadStorage()
        {
            List<Storage> storages = _storageService.GetStoragesAll();
            StorageItems = storages.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.StorageName
            })
            .ToList();
            StorageItems.Insert(0, new SelectListItem { Value = "0", Text = "�����������" });
        }
        private void LoadAccouting()
        {
            List<Accounting> accountings = _accountingService.GetAllAccounts();
            AccoutingItems = accountings.Select(ac => new SelectListItem
            {
                Value = ac.Id.ToString(),
                Text = ac.WaybillId.ToString()
            })
            .ToList();
            AccoutingItems.Insert(0, new SelectListItem { Value = "0", Text = "�����������" });
        }
        private void LoadImplementation()
        {
            List<Implementation> implementations = _implementationsService.GetImplementationsAll();
            ImplementationItems = implementations.Select(ac => new SelectListItem
            {
                Value = ac.Id.ToString(),
                Text = ac.ImplementationDate.ToString()
            })
            .ToList();
            ImplementationItems.Insert(0, new SelectListItem { Value = "0", Text = "�����������" });
        }

        public void OnGet()
        {
            Products = _productService.GetAllProducts();
        }

        public IActionResult OnPost()
        {
         
            return Page();
        }
        public IActionResult OnPostUpdate(int id)
        {
            return RedirectToPage("UpdateProduct");
        }
        public IActionResult OnPostSearchProduct()
        {
            Products = _productService.GetProduct(SearchProduct);
            return Page();
        }

        public IActionResult OnPostSortProduct()
        {
            switch (SortProduct)
            {
                case "1":

                    Products = _productService.GetAllProducts ();
                    return Page();
                case "2":

                    Products = _productService.SortProductName();
                    return Page();
                case "3":

                    Products = _productService.SortPriceProduct();
                    return Page();
                case "4":

                    Products = _productService.SortDateManufactureProduct();
                    return Page();

                default: return Page();
            }
        }
        public IActionResult OnPostDelete(int id)
        {
            _productService.RemoveProduct(id);
            Products = _productService.GetAllProducts();
            return Page();
        }
    }

}
