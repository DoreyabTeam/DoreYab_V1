using DoreYab_V1.Domain.CourseAgg;
using DoreYab_V1.Domain.CourseCategoryAgg;
using DoreYab_V1.Inferastracture.Efcore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DoreYab_V1.Inferastracture.Efcore
{
    public class DoreYabContext : DbContext
    {
        public DbSet<CourseCategory> courseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DoreYabContext(DbContextOptions<DoreYabContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
