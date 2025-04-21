using DoreYab_V1.Domain.CourseAgg;
using DY.Domain.Course.Agg;

namespace DoreYab_V1.Inferastracture.Efcore.Repository
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
