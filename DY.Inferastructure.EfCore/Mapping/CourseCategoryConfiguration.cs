using DoreYab_V1.Domain.CourseCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoreYab_V1.Inferastracture.Efcore.Mapping
{
    public class CourseCategoryConfiguration : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("Course_Category");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(50);
            builder.Property(b => b.ShortDescription);
            builder.Property(b => b.CourseCount);

            builder.HasMany(b => b.Courses)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
