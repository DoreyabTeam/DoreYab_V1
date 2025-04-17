using DoreYab.Application.Contract.CourseCategory;
using DoreYab.Domain.CourseCategoryAgg;
using DY.Application.Contract.CourseCategory;

namespace DoreYab.Application.CourseCategory
{
    public class CourseCategoryApplication : ICourseCategoryApplication
    {
        private readonly ICourseCategoryRepository _categoryRepository;

        public CourseCategoryApplication(ICourseCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CourseCategoryViewModel> List()
        {
            var courseCategories = _categoryRepository.GetAll();
            var result = new List<CourseCategoryViewModel>();

            foreach (var courseCategory in courseCategories)
            {
                result.Add(new CourseCategoryViewModel
                {
                    Id = courseCategory.Id,
                    Title = courseCategory.Title,
                    IsDeleted = courseCategory.IsDeleted,
                    ShortDescription = courseCategory.ShortDescription,
                    CreationDate = courseCategory.CreationDate,
                });
            }
            return result;
        }

    }
}
