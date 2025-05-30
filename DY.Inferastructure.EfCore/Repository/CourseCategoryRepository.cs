﻿using DoreYab_V1.Domain.CourseCategoryAgg;

namespace DoreYab_V1.Inferastracture.Efcore.Repository
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly DoreYabContext _context;

        public CourseCategoryRepository(DoreYabContext context)
        {
            _context = context;
        }

        public void Create(CourseCategory entity)
        {
            _context.courseCategories.Add(entity);
            _context.SaveChanges();
        }

        public List<CourseCategory> GetAll()
        {
            return _context.courseCategories.ToList();
        }
    }
}
