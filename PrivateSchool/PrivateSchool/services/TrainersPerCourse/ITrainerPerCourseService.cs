using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.TrainersPerCourse
{
    interface ITrainerPerCourseService
    {
        List<int> NumberOfCoursesInitializationKey(int count);
        List<int> NumberOfTrainersPerCourseInitializationValue(int count);
    }
}
