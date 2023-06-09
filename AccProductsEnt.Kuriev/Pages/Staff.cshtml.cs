using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Host;

namespace AccProductsEnt.Kuriev.Pages
{
    public class StaffModel : PageModel
    {
        private readonly IWorkshopService _workshopService;
        private readonly IStorageService _storageService;
        private readonly IAccountingService _accountingService;
        private readonly IImplementationsService _implementationsService;
        private readonly IStaffService _staffService;

        [BindProperty]
        public InputStaff InputModel { get; set; }

        public List<SelectListItem> WorkshopItems { get; set; }
        public List<SelectListItem> StorageItems { get; set; }
        public List<SelectListItem> AccoutingItems { get; set; }
        public List<SelectListItem> ImplementationItems { get; set; }
        public StaffModel(IWorkshopService workshopService, 
            IStorageService storageService, 
            IAccountingService accountingService, 
            IImplementationsService implementationsService,
            IStaffService staffService)
        {
            _workshopService = workshopService;
            _storageService = storageService;
            _accountingService = accountingService;
            _implementationsService = implementationsService;
            _staffService = staffService;
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
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
                return Page();
            var staff = new Staff()
            {
                FullName = InputModel.FullName,
                Experience = InputModel.Experience,
                Wage= InputModel.Wage,
                Address = InputModel.Address,
                Phone= InputModel.Phone,
                WorkshopId = InputModel.SelectValueListWorkshop,
                StorageId = InputModel.SelectValueListStorage,
                AccountingId = InputModel.SelectValueListAccounting,
                ImplementationId = InputModel.SelectValueListImplementation
            };
            _staffService.AddStaff(staff);
            return Page();
        }
    }
}
