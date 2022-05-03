using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.AssigmentsPerCourse
{
    interface IAssigmentsPerCourseService
    {
        List<int> InitializeCourses(int count);
        List<int> InitializesNumberOfAssigmentsPerCourse(int count);
    }
}
