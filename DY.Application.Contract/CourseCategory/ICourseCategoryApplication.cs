using DoreYab.Application.Contract.CourseCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY.Application.Contract.CourseCategory
{
    public  interface ICourseCategoryApplication
    {
        List<CourseCategoryViewModel> List();
    }
}
