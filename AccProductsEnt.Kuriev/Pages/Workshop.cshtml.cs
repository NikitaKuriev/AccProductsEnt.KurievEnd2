using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProductsEnt.Kuriev.Pages
{
    public class WorkshopModel : PageModel
    {
        private readonly IWorkshopService _workshopService;
        private readonly IRawService _rwService;
        public WorkshopModel(IWorkshopService workshopService, IRawService rwService)
        {
            _workshopService = workshopService;
            _rwService = rwService;
            LoadRaws();
        }

        public List<SelectListItem> RawItems { get; set; }

        [BindProperty]
        public InputWorkshop InputModel { get; set; }

        private void LoadRaws()
        {
            List<Raw> cards = _rwService.GetAllRaws();
            RawItems = cards.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.RawName
            })
           .ToList();
            RawItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует" });
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var workshop = new Workshop()
            {
                WorkshopName = InputModel.WorkshopName,
                ProccesName = InputModel.ProccesName,
                RawId = InputModel.SelectlistRawItem
            };
            _workshopService.AddWorkshop(workshop);
            return Page();
        }
    }
}
