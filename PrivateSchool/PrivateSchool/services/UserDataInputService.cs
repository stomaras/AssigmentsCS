using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;


namespace PrivateSchool.services
{
    class UserDataInputService
    {

        private int _numOfStudents;

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set { _numOfStudents = value; }
        }

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
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
            while(choice != 4)
            {
                switch (choice)
                {
                    case 0:
                        StudentDetails = EnterStudentDetails();
                        NumOfStudents = NumOfStudentss();
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

        public void StudentDetailss()
        {
           
            StudentDetails studentDetails = EnterStudentDetails();
            
        }

        public StudentDetails EnterStudentDetails()
        {
          
            MinMax sid = InitializeStudentId();
            MinMax tuitionFees = InitializeTuitionFees();
            NameMinMax firstName = InitializeFirstName();
            NameMinMax lastName = InitializeLastName();
            DateBirth dateBirth = InitializeDateBirth();
            StudentDetails studentDetails = new StudentDetails(sid, firstName, lastName, dateBirth, tuitionFees);
            return studentDetails;
        }

        public int NumOfStudentss()
        {
            Console.WriteLine("Enter Number Of Students:\n");
            int numOfStudents = Convert.ToInt32(Console.ReadLine());
            return numOfStudents;
        }
        public MinMax InitializeStudentId()
        {
            Console.WriteLine("Enter Min Id:\n");
            int minId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Id:\n");
            int maxId = Convert.ToInt32(Console.ReadLine());
            return new MinMax(minId, maxId);
        }

        public MinMax InitializeTuitionFees()
        {
            Console.WriteLine("Enter Min Tuition Fees:\n");
            double minTuitionFees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Max Tuition Fees:\n");
            double maxTuitionFees = Convert.ToDouble(Console.ReadLine());
            return new MinMax(minTuitionFees, maxTuitionFees);
        }

        public NameMinMax InitializeFirstName()
        {
            Console.WriteLine("Enter min ascii first name number:\n");
            int minAscii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max ascii first name number:\n");
            int maxAscii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first name number of chars:\n");
            int firstNameNumOfChars = Convert.ToInt32(Console.ReadLine());
            return new NameMinMax(minAscii, maxAscii, firstNameNumOfChars);
        }

        public NameMinMax InitializeLastName()
        {
            Console.WriteLine("Enter min ascii last name number:\n");
            int minAsciiLast = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max ascii last name number:\n");
            int maxAsciiLast = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last name number of chars:\n");
            int lastNameNumOfChars = Convert.ToInt32(Console.ReadLine());
            return new NameMinMax(minAsciiLast, maxAsciiLast, lastNameNumOfChars);
        }

        public DateBirth InitializeDateBirth()
        {
            Console.WriteLine("Enter Min Year In Calendar:\n");
            int minYearInCalendar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Year In Calendar:\n");
            int maxYearInCalendar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minimum Month:\n");
            int minMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maximum Month:\n");
            int maxMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Min Day:\n");
            int minDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Day:\n");
            int maxDay = Convert.ToInt32(Console.ReadLine());
            return new DateBirth(minYearInCalendar, maxYearInCalendar, minMonth, maxMonth, minDay, maxDay);
        }
    }
}
