using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;
using PrivateSchool.domain;

namespace PrivateSchool.services.StudentsPerCourse
{
    class StudentsPerCourse
    {
        private StudentsPerCourseService _studentsPerCourseService;

        public StudentsPerCourseService StudentsPerCourseService
        {
            get { return _studentsPerCourseService; }
            set { _studentsPerCourseService = value; }
        }

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }


        private List<int> _courses;

        public List<int> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        private List<int> _students;

        public List<int> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public StudentsPerCourse(StudentsPerCourseService studentsPerCourseService, CourseDetails courseDetails, StudentDetails studentDetails)
        {
            StudentsPerCourseService = studentsPerCourseService;
            Courses = StudentsPerCourseService.Keys;
            //PrintList(Courses);
            Students = StudentsPerCourseService.Values;
            CourseDetails = courseDetails;
            StudentDetails = studentDetails;
            GenerateStudentsPerCourse(Courses,Students,CourseDetails,StudentDetails);
            //PrintList(Students);
        }



        public void GenerateStudentsPerCourse(List<int> courses, List<int> students, CourseDetails courseDetails, StudentDetails studentDetails)
        {
            for(int i=0; i<= courses.Count -1; i++)
            {
                var course = new RandomCourse(courseDetails);
                Console.WriteLine("\n");
                Console.WriteLine("Course:\t" + course + "\nWith Students:\n");
                int studentLength = students[i];
                for(int j = 0; j<= studentLength-1; j++)
                {
                    var student = new RandomStudent(studentDetails);
                    Console.WriteLine("Student:\t" + student);
                }
                
            }
        }























































        /*
         * 
         * 
         * 
         * 
         * public void PrintList(List<int> list)
        {
            for(int i=0; i<= list.Count-1; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

         * 
         */

    }
}
