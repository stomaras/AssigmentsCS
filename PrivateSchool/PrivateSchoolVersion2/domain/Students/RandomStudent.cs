using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolVersion2.domain.Students
{
    class RandomStudent : Student
    {
        private StudentDetails _studentDetails;

        public RandomStudent(StudentDetails studentDetails)
        {

        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
