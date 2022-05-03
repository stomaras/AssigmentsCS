using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;
using PrivateSchool.domain;
using PrivateSchool.domain.Assigments;

namespace PrivateSchool.services.AssigmentsPerCourse
{
    class AssigmentsPerCourse
    {
        private AssigmentsPerCourseService _assigmentsPerCourseService;

        public AssigmentsPerCourseService AssigmentsPerCourseService
        {
            get { return _assigmentsPerCourseService; }
            set { _assigmentsPerCourseService = value; }
        }

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        private AssigmentDetails _assigmentDetails;

        public AssigmentDetails AssigmentDetails
        {
            get { return _assigmentDetails; }
            set { _assigmentDetails = value; }
        }

        private List<int> _courses;

        public List<int> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        private List<int> _assigments;

        public List<int> Assigments
        {
            get { return _assigments; }
            set { _assigments = value; }
        }

        public AssigmentsPerCourse(AssigmentsPerCourseService assigmentsPerCourseService, CourseDetails courseDetails, AssigmentDetails assigmentDetails)
        {
            AssigmentsPerCourseService = assigmentsPerCourseService;
            Courses = AssigmentsPerCourseService.Courses;
            Assigments = AssigmentsPerCourseService.Assigments;
            CourseDetails = courseDetails;
            AssigmentDetails = assigmentDetails;
            GenerateAssigmentsPerCourse(Courses, Assigments, CourseDetails, AssigmentDetails);
        }

        public void GenerateAssigmentsPerCourse(List<int> courses, List<int> assigments, CourseDetails courseDetails, AssigmentDetails assigmentDetails)
        {
            for (int i = 0; i <= courses.Count - 1; i++)
            {
                var course = new RandomCourse(courseDetails);
                Console.WriteLine("\n");
                Console.WriteLine("Course:\t" + course + "\nWith Assigments:\n");
                int assigmentLength = assigments[i];
                for (int j = 0; j <= assigmentLength - 1; j++)
                {
                    var assigment = new RandomAssigment(assigmentDetails);
                    Console.WriteLine("Assigment:\t" + assigment);
                }
            }
        }




    }
}
