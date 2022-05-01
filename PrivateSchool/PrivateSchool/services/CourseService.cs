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

            for(int i=0; i<= _noOfCourses -1; i++)
            {
                course = new RandomCourse(_courseDetails, GenerateUniqueId(GetCoursesIds(courses)));
                courses.Add(course);
                
            }

            return courses;
        }

        private List<int> GetCoursesIds(List<Course> courses)
        {
            List<int> ids = new List<int>(courses.Select(course => course.Cid));
            return ids;
        }

        private int GenerateUniqueId(List<int> ids)
        {
            var newId = RandomService.Number(_courseDetails.CourseMinMax.Min, _courseDetails.CourseMinMax.Max);
            while (ids.Contains(newId))
            {
                newId = RandomService.Number(_courseDetails.CourseMinMax.Min, _courseDetails.CourseMinMax.Max);
            }
            return newId;
        }



    }
}
