using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolVersion2.domain.Students;
using PrivateSchoolVersion2.domain;

namespace PrivateSchoolVersion2.services.InputService
{
    class UserDataInputService
    {

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }

        private StudentInitialization _studentInitialization;

        public StudentInitialization StudentInitialization
        {
            get { return _studentInitialization; }
            set { _studentInitialization = value; }
        }


        public UserDataInputService()
        {
            Menu();
        }

        public void Menu()
        {
            Options();
            int choice = 0;
            Console.WriteLine("Enter Option:\n");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 4)
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("----------------------------Student Details-------------------------------");
                        StudentDetails = EnterStudentDetails();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                Options();
                Console.WriteLine("Enter Option:\n");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Options()
        {
            Console.WriteLine("Available Options:\n");
            Console.WriteLine("Enter option 0 to enter student details\n");
            Console.WriteLine("Enter option 1 to enter trainer details\n");
            Console.WriteLine("Enter option 2 to enter assigment details\n");
            Console.WriteLine("Enter option 3 to enter course details\n");
            Console.WriteLine("Enter option 4 to exit the program\n");
            Console.WriteLine("Enter option 5 to see available options\n");
        }

        public StudentDetails EnterStudentDetails()
        {
            MinMax sid = StudentInitialization.InitializeStudentId();
            int numOfStudents = StudentInitialization.InitializeNumOfStudentss();
            StudentDetails studentDetails = new StudentDetails(sid, numOfStudents);
            return studentDetails;
        }


    }
}
