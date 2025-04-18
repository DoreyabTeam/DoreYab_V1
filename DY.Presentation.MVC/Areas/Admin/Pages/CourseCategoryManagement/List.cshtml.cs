using DoreYab.Application.Contract.CourseCategory;
using DY.Application.Contract.CourseCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DY.Presentation.MVC.Areas.Admin.Pages.CourseCategoryManagement
{
    public class IndexModel : PageModel
    {
        public List<CourseCategoryViewModel> CourseCategories { get; set; }
        private readonly ICourseCategoryApplication _categoryApplication;

        public IndexModel(ICourseCategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        public void OnGet()
        {
            CourseCategories = _categoryApplication.List();
        }

    }
}
