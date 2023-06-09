using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace AccProductsEnt.Kuriev.Pages
{
    public class PostModel : PageModel
    {
        private readonly IPostServive _postServive;
        private readonly IStaffService _staffService;
        public List<SelectListItem> StaffItems { get; set; }

        [BindProperty]
        public InputPost InputModel { get; set; }
        public PostModel(IPostServive postServive, IStaffService staffService)
        {
            _postServive = postServive;
            _staffService = staffService;
            LoadStaff();
        }

        private void LoadStaff()
        {
            List<Staff> stafs = _staffService.GetStaffAll();
            StaffItems = stafs.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.FullName
            })
            .ToList();
            StaffItems.Insert(0,new SelectListItem { Value = "0", Text = "Отсутсвует" });
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var post = new Post()
            {
                PostTitle = InputModel.PostTitle,
                JobResponsibilities = InputModel.JobResponsibilities,
                StaffId = InputModel.SelectValueListStaff
            };
            _postServive.AddPost(post);
            return Page();
        }
    }
}
