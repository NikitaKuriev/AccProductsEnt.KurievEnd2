using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class TechnicalProcessesModel : PageModel
    {
        private readonly ITechnicalProcessesService technicalProcessesService;

        [BindProperty]
        public InputTechnicalProcesses InputModel { get; set; }
        public void OnGet()
        {
        }


    }
}
