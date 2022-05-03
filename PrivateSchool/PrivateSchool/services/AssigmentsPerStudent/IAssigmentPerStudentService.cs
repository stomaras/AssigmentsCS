using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.AssigmentsPerStudent
{
    interface IAssigmentPerStudentService
    {
        List<int> InitializeNumberOfStudents(int count);
        List<int> InitializeNumberOfAssigments(int count);
    }
}
