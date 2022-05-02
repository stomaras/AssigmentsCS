using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.domain.Assigments;
using PrivateSchool.domain.Course;


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


        private int _numOfTrainers;

        public int NumOfTrainers
        {
            get { return _numOfTrainers; }
            set { _numOfTrainers = value; }
        }

        private TrainerDetails _trainersDetails;

        public TrainerDetails TrainerDetails
        {
            get { return _trainersDetails; }
            set { _trainersDetails = value; }
        }

        private int _numOfAssigmetns;

        public int NumOfAssigments
        {
            get { return _numOfAssigmetns; }
            set { _numOfAssigmetns = value; }
        }

        private AssigmentDetails _assigmentDetails;

        public AssigmentDetails AssigmentDetails
        {
            get { return _assigmentDetails; }
            set { _assigmentDetails = value; }
        }

        private int _numOfCourses;

        public int NumOfCourses
        {
            get { return _numOfCourses; }
            set { _numOfCourses = value; }
        }

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }








        public UserDataInputService()
        {
            Console.WriteLine("--------------------------UserDataInputService--------------------------");
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
                        Console.WriteLine("----------------------------Student Details-------------------------------");
                        StudentDetails = EnterStudentDetails();
                        NumOfStudents = NumOfStudentss();
                        break;
                    case 1:
                        Console.WriteLine("-------------------------Trainer Details---------------------------------");
                        TrainerDetails = EnterTrainerDetails();
                        NumOfTrainers = NumOfTrainerss();
                        break;
                    case 2:
                        Console.WriteLine("-------------------------Assigment Details---------------------------------");
                        AssigmentDetails = EnterAssigmentDetails();
                        break;
                    case 3:
                        Console.WriteLine("----------------------Course Details-----------------------------------");
                        CourseDetails = EnterCourseDetails();
                        NumOfCourses = NumOfCoursess();
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

        public void StudentDetailss()
        {
           
            StudentDetails studentDetails = EnterStudentDetails();
            
            
        }

        public TrainerDetails EnterTrainerDetails()
        {
            MinMax tid = InitializeTrainerId();
            NameMinMax firstName = InitializeTrainerFirstName();
            NameMinMax lastName = InitializeTrainerLastName();
            Subject subject = new Subject();
            TrainerDetails trainerDetails = new TrainerDetails(tid, firstName, lastName, subject);
            return trainerDetails;
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

        public AssigmentDetails EnterAssigmentDetails()
        {
            AssigmentDetailsInputService assigmentDetailsInputService = new AssigmentDetailsInputService();
            MinMaxAssigment aid = assigmentDetailsInputService.Aid;
            AssigmentTitle atitle = assigmentDetailsInputService.AssigmentTitle;
            NameMinMax description = assigmentDetailsInputService.Description;
            SubDateTime subDateTime = assigmentDetailsInputService.SubDateTime;
            OralMark oralMark = assigmentDetailsInputService.OralMark;
            TotalMark totalMark = assigmentDetailsInputService.TotalMark;
            AssigmentDetails assigmentDetails = new AssigmentDetails(aid,atitle,description,subDateTime,oralMark,totalMark);
            return assigmentDetails;
        }

        public CourseDetails EnterCourseDetails()
        {
            CourseDetailsInputService courseDetailsInputService = new CourseDetailsInputService();
            CourseMinMax cid = courseDetailsInputService.CID;
            CourseTitle ctitle = courseDetailsInputService.CourseTitle;
            StreamTypes sTypes = courseDetailsInputService.StreamTypes;
            CourseType cType = courseDetailsInputService.CourseType;
            StartDateTime sDateTime = courseDetailsInputService.StartDateTime;
            EndDateTime eDateTime = courseDetailsInputService.EndDateTime;
            CourseDetails courseDetails = new CourseDetails(cid, ctitle, sTypes, cType, sDateTime, eDateTime);
            return courseDetails;
        }

        public int NumOfStudentss()
        {
            Console.WriteLine("Enter Number Of Students:\n");
            int numOfStudents = Convert.ToInt32(Console.ReadLine());
            return numOfStudents;
        }

        public int NumOfTrainerss()
        {
            Console.WriteLine("Enter Number Of Trainers:\n");
            int numOfTrainers = Convert.ToInt32(Console.ReadLine());
            return numOfTrainers;
        }

        public int NumOfCoursess()
        {
            Console.WriteLine("Enter Number Of Courses:\n");
            int numOfCourses = Convert.ToInt32(Console.ReadLine());
            return numOfCourses;
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

        public MinMax InitializeTrainerId()
        {
            Console.WriteLine("Enter Trainer Min Id:\n");
            int minId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Trainer Max Id:\n");
            int maxId = Convert.ToInt32(Console.ReadLine());
            return new MinMax(minId, maxId);
        }

        public NameMinMax InitializeTrainerFirstName()
        {
            Console.WriteLine("Enter min ascii trainer first name number:\n");
            int minAscii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max ascii trainer first name number:\n");
            int maxAscii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name number of chars:\n");
            int firstNameNumOfChars = Convert.ToInt32(Console.ReadLine());
            return new NameMinMax(minAscii, maxAscii, firstNameNumOfChars);
        }

        public NameMinMax InitializeTrainerLastName()
        {
            Console.WriteLine("Enter min ascii last name trainer number:\n");
            int minAsciiLast = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max ascii last name trainer number:\n");
            int maxAsciiLast = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last name trainer number of chars:\n");
            int lastNameNumOfChars = Convert.ToInt32(Console.ReadLine());
            return new NameMinMax(minAsciiLast, maxAsciiLast, lastNameNumOfChars);
        }

        public MinMaxAssigment InitializeAssigmentId()
        {
            Console.WriteLine("Enter Assigment Min Id:\n");
            int minId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Assigment Max Id:\n");
            int maxId = Convert.ToInt32(Console.ReadLine());
            return new MinMaxAssigment(minId, maxId);
        }

        
    }
}
