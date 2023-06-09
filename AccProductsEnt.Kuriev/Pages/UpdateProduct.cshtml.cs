using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Policy;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class UpdateProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IWorkshopService _workshopService;
        private readonly IStorageService _storageService;
        private readonly IAccountingService _accountingService;
        private readonly IImplementationsService _implementationsService;

        public UpdateProductModel(IProductService productService,
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

        [BindProperty]
        public InputProduct InputProduct { get; set; }

        public IEnumerable<Product> ProductsId { get; set; }
       

        public int Id { get; set; }


        public List<SelectListItem> WorkshopItems { get; set; }
        public List<SelectListItem> StorageItems { get; set; }
        public List<SelectListItem> AccoutingItems { get; set; }
        public List<SelectListItem> ImplementationItems { get; set; }



        public int IdProduct { get; set; }  

        private void LoadWorkshop()
        {
            List<Workshop> workshops = _workshopService.GetAllWorkshop();
            WorkshopItems = workshops.Select(w => new SelectListItem
            {
                Value = w.Id.ToString(),
                Text = w.WorkshopName
            })
            .ToList();
            WorkshopItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
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
            StorageItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
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
            AccoutingItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
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
            ImplementationItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }

      
        public void OnGet()
        {
        }
        

        public void OnPost() 
        {
        }

        public IActionResult OnPostEditProduct(int id)
        {

            ProductsId = _productService.GetProductsById(id);
            return Page();
        }

        public IActionResult OnPostEdit(int id)
        {
            if (!ModelState.IsValid)
                return Page();

            var product = new Product()
            {
                Description = InputProduct.Description,
                ProductName = InputProduct.ProductName,
                Quantity = InputProduct.Quantity,
                DateOfManufacture = InputProduct.DateOfManufacture,
                PricePerPiece = InputProduct.PricePerPiece,
                ImgPath = InputProduct.ImgPath,
                WorkshopId = InputProduct.SelectValueListWorkshop,
                StorageId = InputProduct.SelectValueListStorage,
                AccountingId = InputProduct.SelectValueListAccounting,
                ImplementationId = InputProduct.SelectValueListImplementation
            };

            _productService.UpdateProduct(id, product);
            ProductsId = _productService.GetAllProducts();
            return RedirectToPage("Product");
        }
    }
}
