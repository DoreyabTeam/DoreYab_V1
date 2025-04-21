
using _0_Framework.Domain;
using DoreYab.Domain.CourseAgg;

namespace DoreYab.Domain.CourseCategoryAgg
{
    public class CourseCategory : EntityBase
    {
        public string Title { get;private set; }
        public string? ShortDescription { get; private set; }
        public long CourseCount { get; private set; }
        public bool IsDeleted { get; private set; }

        public ICollection<Course> Courses { get;private set; }
    }
}
