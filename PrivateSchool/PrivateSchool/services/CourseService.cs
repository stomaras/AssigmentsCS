using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;

namespace PrivateSchool.services
{
    class CourseService
    {

        private int _noOfCourses;
        private CourseDetails _courseDetails;

        public List<Course> Courses { get; private set; }

        public CourseService(CourseDetails courseDetails, int noOfCourses)
        {
            if(noOfCourses != 8)
            {
                _noOfCourses = 8;
            }
            _courseDetails = courseDetails;
            
            Courses = GenerateCourses();
        }


        public List<Course> GenerateCourses()
        {
            List<Course> courses = new List<Course>();
            var course = new RandomCourse(_courseDetails);
            courses.Add(course);

            for(int i=0; i<= _noOfCourses; i++)
            {
                course = new RandomCourse(_courseDetails);
                courses.Add(course);
                
            }

            return courses;
        }



    }
}
