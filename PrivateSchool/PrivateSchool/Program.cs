using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.services;
using PrivateSchool.domain.Assigments;
using PrivateSchool.domain.Course;
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




            /*
             * Assigment Details
             * 
             */

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



            /*****************************************************************/
            /******************* UserDataInputService ************************/
            /****************************************************************/

            UserDataInputService userDataInputService = new UserDataInputService();
            StudentDetails student = userDataInputService.StudentDetails;
            int numberOfStudents = userDataInputService.NumOfStudents;
            School school5 = new School(student, numberOfStudents);
            school5.Start();


        }

        

            
    }
        
}

