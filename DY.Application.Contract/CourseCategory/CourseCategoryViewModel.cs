namespace DoreYab_V1.Application.Contract.CourseCategory
{
    public class CourseCategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? ShortDescription { get; set; }
        public long CourseCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreationDate { get; set; }

        public CourseCategoryViewModel(string title, string? shortDescription, long courseCount)
        {
            Title = title;
            ShortDescription = shortDescription;
            CourseCount = courseCount;
            IsDeleted = false;
            CreationDate = DateTime.UtcNow;
        }

        public CourseCategoryViewModel()
        {
        }
    }
}
