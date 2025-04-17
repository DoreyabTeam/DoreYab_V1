using DoreYab.Domain.CourseAgg;
using DY.Domain.Course.Agg;

namespace DoreYab.Inferastracture.Efcore.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DoreYabContext _context;

        public CourseRepository(DoreYabContext context)
        {
            _context = context;
        }


    }
}
