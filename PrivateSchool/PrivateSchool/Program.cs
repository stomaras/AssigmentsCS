﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.services;
using PrivateSchool.domain.Assigments;
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

            CSVDataInputService csvDataInputService = new CSVDataInputService(@"C:\Users\spyros\C-\Assigments\Individual_Project_Part_A\PrivateSchool\PrivateSchool\SchoolData.csv");
            StudentDetails studentDetails = csvDataInputService.StudentDetails;
            int noOfStudents = csvDataInputService.NoOfStudents;
            School school = new School(studentDetails, noOfStudents);
            school.Start();


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
            Console.WriteLine(assigment.ToString());

            School school = new School(assigmentDetails);
            school.StartAssigments();
            





        }

            
    }
        
}

