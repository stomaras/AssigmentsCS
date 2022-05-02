using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.StudentsPerCourse
{
    interface IStudentsPerCourseService
    {
        List<int> NumberOfCoursesInitializationKey(int count);
        List<int> NumberOfStudentsPerCourseInitializationValue(int count);
    }
}
