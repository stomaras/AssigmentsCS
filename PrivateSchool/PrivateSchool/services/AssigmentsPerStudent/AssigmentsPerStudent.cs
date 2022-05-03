using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;
using PrivateSchool.domain;
using PrivateSchool.domain.Assigments;

namespace PrivateSchool.services.AssigmentsPerStudent
{
    class AssigmentsPerStudent
    {
        private AssigmentPerStudentService _assigmentPerStudentService;

        public AssigmentPerStudentService AssigmentPerStudentService
        {
            get { return _assigmentPerStudentService; }
            set { _assigmentPerStudentService = value; }
        }

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }

        private AssigmentDetails _assigmentDetails;

        public AssigmentDetails AssigmentDetails
        {
            get { return _assigmentDetails; }
            set { _assigmentDetails = value; }
        }

        private List<int> _students;

        public List<int> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        private List<int> _assigments;

        public List<int> Assigments
        {
            get { return _assigments; }
            set { _assigments = value; }
        }

        public AssigmentsPerStudent(AssigmentPerStudentService assigmentPerStudentService, StudentDetails studentDetails, AssigmentDetails assigmentDetails)
        {
            AssigmentPerStudentService = assigmentPerStudentService;
            Students = AssigmentPerStudentService.Students;
            Assigments = AssigmentPerStudentService.Assigments;
            StudentDetails = studentDetails;
            AssigmentDetails = assigmentDetails;
            GenerateAssigmentsPerStudent(Students, Assigments, StudentDetails, AssigmentDetails);
        }

        public void GenerateAssigmentsPerStudent(List<int> students, List<int> assigments, StudentDetails studentDetails, AssigmentDetails assigmentDetails)
        {
            for (int i = 0; i <= students.Count - 1; i++)
            {
                var student = new RandomStudent(studentDetails);
                Console.WriteLine("\n");
                Console.WriteLine("Student:\t" + student + "\nWith Assigments:\n");
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
