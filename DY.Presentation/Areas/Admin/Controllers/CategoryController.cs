using DoreYab_V1.Application.Contract.CourseCategory;
using DY.Application.Contract.CourseCategory;
using Microsoft.AspNetCore.Mvc;

namespace DY.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public List<CourseCategoryViewModel> CourseCategories { get; set; }
        private readonly ICourseCategoryApplication _categoryApplication;

        public CategoryController(ICourseCategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        public IActionResult List()
        {
            CourseCategories = _categoryApplication.List();
            return View(CourseCategories);
        }

    }
}
