using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class CourseType : ICourseType
    {

        public List<string> Courses{ get; private set; }

        public CourseType()
        {
            Courses = InitializeType();
        }

        public List<string> InitializeType()
        {
            List<string> types = new List<string>();
            types.Add("Full-Time");
            types.Add("Part-Time");
            return types;
        }

        public override string ToString()
        {
            string s = $"CourseType: ";
            for(int i=0; i <= Courses.Count - 1; i++)
            {
                s = s + Courses[i] + ",";
            }
            return s;
        }
    }
}
