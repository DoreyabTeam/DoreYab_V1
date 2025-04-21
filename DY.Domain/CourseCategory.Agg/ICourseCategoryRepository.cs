namespace DoreYab.Domain.CourseCategoryAgg
{
    public interface ICourseCategoryRepository
    {
        List<CourseCategory> GetAll();
        void Create(CourseCategory entity);
    }
}
