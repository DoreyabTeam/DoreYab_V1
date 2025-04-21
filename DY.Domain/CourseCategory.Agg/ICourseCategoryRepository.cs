namespace DoreYab_V1.Domain.CourseCategoryAgg
{
    public interface ICourseCategoryRepository
    {
        List<CourseCategory> GetAll();
        void Create(CourseCategory entity);
    }
}
