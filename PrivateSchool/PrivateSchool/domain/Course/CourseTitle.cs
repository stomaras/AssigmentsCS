using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class CourseTitle : ICourseTitle
    {
        public List<string> Courses { get; private set; }

        public CourseTitle()
        {
            Courses = InitializeCourses();
        }

        public List<string> InitializeCourses()
        {
            List<string> courses = new List<string>();
            courses.Add("java");
            courses.Add("csharp");
            courses.Add("python");
            courses.Add("javascript");
            return courses;

        }

        public override string ToString()
        {
            string s = $"Course Title";
            for(int i=0; i<= Courses.Count-1; i++)
            {
                s = s + $" \nAvailable Course : {Courses[i]}";
            }
            return s;
        }
    }
}
