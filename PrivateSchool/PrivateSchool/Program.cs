using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.services;
using PrivateSchool.domain.Assigments;
using PrivateSchool.domain.Course;
using PrivateSchool.services.StudentsPerCourse;
using PrivateSchool.services.TrainersPerCourse;
namespace PrivateSchool
{
    class Program
    {
        /*
         * With CSVDataInputService, i will generate noOfStudents and StudentDetails
         * 
         * 
         */
        static void Main(string[] args)
        {


            //StudentDataInputService studentDataInputService = new StudentDataInputService();
            //studentDataInputService.Start();


            //csvDataInputService.NoOfStudents;
            //csvDataInputService.StudentDetails

            //int noOfStudents = 30;
            //MinMax Id = new MinMax(1, 100);
            //MinMax TuitionFees = new MinMax(900.00, 7900.00);
            //NameMinMax FirstName = new NameMinMax(65, 91, 4);
            //NameMinMax LastName = new NameMinMax(65, 91, 6);
            //DateBirth DateBirth = new DateBirth(1982, 2005, 3, 8, 5, 23);
            //StudentDetails studentDetails = new StudentDetails(Id, FirstName, LastName, DateBirth, TuitionFees);
            //RandomStudent random = new RandomStudent(studentDetails);

            //Console.WriteLine(random.ToString());


            CSVDataInputService csvDataInputService = new CSVDataInputService(@"C:\Users\spyros\testPrivateSchool\AssigmentsCS\PrivateSchool\PrivateSchool\SchoolData.csv");
            StudentDetails studentDetails = csvDataInputService.StudentDetails;
            int noOfStudents = csvDataInputService.NoOfStudents;
            School school = new School(studentDetails, noOfStudents);
            school.Start();

            CSVDataInputServiceCourse csvDataInputServiceCourse = new CSVDataInputServiceCourse(@"C:\Users\spyros\AssigmentsCS\PrivateSchool\PrivateSchool\CourseData.csv");
            CourseDetails courseDetails1 = csvDataInputServiceCourse.CourseDetails;
            
            int noOfCourses = csvDataInputServiceCourse.NumOfCourses;
            Console.WriteLine(noOfCourses);
            School school4 = new School(courseDetails1, noOfCourses);
            school4.StartCourses();
           













            //TrainerDetails trainerDetails = csvDataInputService.TrainerDetails;


            //string[] courses = { "java", "python", "csharp", "javascript" };



            //Console.WriteLine(RandomService.Course(courses));

            //Subject su = new Subject();
            //Console.WriteLine(su.ToString());

            // List With Trainers 1st Way

            MinMax Id = new MinMax(1, 20);
            NameMinMax FirstName = new NameMinMax(65, 91, 4);
            NameMinMax LastName = new NameMinMax(65, 91, 7);
            Subject subject = new Subject();
            TrainerDetails trainerDetails = new TrainerDetails(Id, FirstName, LastName, subject);
            RandomTrainer trainer = new RandomTrainer(trainerDetails);
            int noOfTrainers = 10;
            School school1 = new School(trainerDetails, noOfTrainers);
            school1.StartTrainers();
             



            //CSVDataInputService csvDataInputService = new CSVDataInputService(@"c:\users\spyros\assigmentscs\privateschool\privateschool\schooldata.csv");


            //Console.WriteLine("Assigments");




            
             
            MinMaxAssigment aid = new MinMaxAssigment(-5, 8);
            AssigmentTitle title = new AssigmentTitle();
            NameMinMax description = new NameMinMax(65, 91, 20);
            SubDateTime subDateTime = new SubDateTime(7892,2,3,3,4);
            OralMark oralMark = new OralMark(4, 7);
            TotalMark totalMark = new TotalMark(aid.Max);

            AssigmentDetails assigmentDetails = new AssigmentDetails(aid,title,description,subDateTime, oralMark, totalMark);
            

            RandomAssigment assigment = new RandomAssigment(assigmentDetails);
           

            School school3 = new School(assigmentDetails);
            school3.StartAssigments();


            CourseMinMax courseMinMax = new CourseMinMax(300,1);
            CourseTitle courseTitle = new CourseTitle();
            StreamTypes streamTypes = new StreamTypes(1,180);
            CourseType courseType = new CourseType();
            StartDateTime startDateTime = new StartDateTime(3, 29);
            EndDateTime endDateTime = new EndDateTime(5, 222);
            CourseDetails courseDetails = new CourseDetails(courseMinMax, courseTitle, streamTypes, courseType, startDateTime, endDateTime);
            RandomCourse randomCourse = new RandomCourse(courseDetails);
            Console.WriteLine(randomCourse.ToString());
            int numOfCourses = -2;
            School school2 = new School(courseDetails, numOfCourses);
            school2.StartCourses();






            /***************************************************************************************************************/
            /******************* *******************UserDataInputService *********************************************************************/
            /***********************************************************************************************************/
            //Console.WriteLine("--------------------------UserDataInputService--------------------------------------");
            //Menu();

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------Students Per Course Question-----------------------------------------------------------------------------");
            IDictionary<int, int> studentsPerCourses = new Dictionary<int, int>();
            int count = 8;
            CourseMinMax courseMinMaxx = new CourseMinMax(300, 1);
            CourseTitle courseTitlee = new CourseTitle();
            StreamTypes streamTypess = new StreamTypes(1, 180);
            CourseType courseTypee = new CourseType();
            StartDateTime startDateTimee = new StartDateTime(3, 29);
            EndDateTime endDateTimee = new EndDateTime(5, 222);
            CourseDetails courseDetailss = new CourseDetails(courseMinMax, courseTitle, streamTypes, courseType, startDateTime, endDateTime);

            MinMax Idd = new MinMax(1, 100);
            MinMax TuitionFees = new MinMax(900.00, 7900.00);
            NameMinMax FirstNamee = new NameMinMax(65, 91, 4);
            NameMinMax LastNamee = new NameMinMax(65, 91, 2);
            DateBirth DateBirth = new DateBirth(1982, 2005, 3, 8, 5, 23);
            StudentDetails studentDetailss = new StudentDetails(Idd, FirstNamee, LastNamee, DateBirth, TuitionFees);

            StudentsPerCourseService studentsPerCourseService = new StudentsPerCourseService(count);
            StudentsPerCourse studentsPerCourse = new StudentsPerCourse(studentsPerCourseService, courseDetails, studentDetailss);
            //Console.WriteLine(studentsPerCourseService.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------Trainers Per Course Question-----------------------------------------------------------------------------------------");
            MinMax TId = new MinMax(1, 20);
            NameMinMax TFirstName = new NameMinMax(65, 91, 4);
            NameMinMax TLastName = new NameMinMax(65, 91, 7);
            Subject Tsubject = new Subject();
            TrainerDetails trainerDetailss = new TrainerDetails(TId, TFirstName, TLastName, Tsubject);
            TrainersPerCourseService trainersPerCourseService = new TrainersPerCourseService(count);
            TrainersPerCourse trainersPerCourse = new TrainersPerCourse(trainersPerCourseService, courseDetails, trainerDetailss);
           
            

            /**
             * 
             * int noOfStudentss = 30;
            MinMax Idd = new MinMax(1, 100);
            MinMax TuitionFees = new MinMax(900.00, 7900.00);
            NameMinMax FirstNamee = new NameMinMax(65, 91, 4);
            NameMinMax LastNamee = new NameMinMax(65, 91, 6);
            DateBirth DateBirth = new DateBirth(1982, 2005, 3, 8, 5, 23);
            StudentDetails studentDetailss = new StudentDetails(Id, FirstName, LastName, DateBirth, TuitionFees);

            int noOfCoursess = 8;
            CourseMinMax courseMinMaxx = new CourseMinMax(300, 1);
            CourseTitle courseTitlee = new CourseTitle();
            StreamTypes streamTypess = new StreamTypes(1, 180);
            CourseType courseTypee = new CourseType();
            StartDateTime startDateTimee = new StartDateTime(3, 29);
            EndDateTime endDateTimee = new EndDateTime(5, 222);
            CourseDetails courseDetailss = new CourseDetails(courseMinMax, courseTitle, streamTypes, courseType, startDateTime, endDateTime);

            School school56 = new School(studentDetailss, noOfStudentss, courseDetailss, noOfCourses);
            school56.StartStudentsPerCourse();

             * 
             * 
             */

        }


        public static void Menu()
        {
            int printChoice = 0;
            Options();
            
            while(printChoice != 4)
            {
                Console.WriteLine("Enter a number:\n");
                printChoice = Convert.ToInt32(Console.ReadLine());
                switch (printChoice)
                {
                    case 0:
                        UserDataInputService userDataInputService = new UserDataInputService();
                        StudentDetails student = userDataInputService.StudentDetails;
                        int numberOfStudents = userDataInputService.NumOfStudents;
                        School school5 = new School(student, numberOfStudents);
                        school5.Start();
                        break;
                    case 1:
                        UserDataInputService userDataInputService1 = new UserDataInputService();
                        TrainerDetails trainer = userDataInputService1.TrainerDetails;
                        int numberOfTrainerss = userDataInputService1.NumOfTrainers;
                        School school64 = new School(trainer, numberOfTrainerss);
                        school64.StartTrainers();
                        break;
                    case 2:
                        UserDataInputService userDataInputService2 = new UserDataInputService();
                        AssigmentDetails assigment = userDataInputService2.AssigmentDetails;
                        School school65 = new School(assigment);
                        school65.StartAssigments();
                        break;
                    case 3:
                        UserDataInputService userDataInputService3 = new UserDataInputService();
                        CourseDetails course = userDataInputService3.CourseDetails;
                        int numOfCourses = userDataInputService3.NumOfCourses;
                        School school66 = new School(course, numOfCourses);
                        school66.StartCourses();
                        break;
                }
                Options();
                Console.WriteLine("Enter a number:\n");
                printChoice = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Options()
        {
            Console.WriteLine("Enter Options:\n");
            Console.WriteLine("0 to enter student list:\n");
            Console.WriteLine("1 to enter trainer list:\n");
            Console.WriteLine("2 to enter assigment list:\n");
            Console.WriteLine("3 to enter course list:\n");
            Console.WriteLine("4 to exit the program:\n");
        }

       
            
    }
        
}

