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
    class School
    {
        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }

        private int _noOfStudents;

        public int NoOfStudents
        {
            get { return _noOfStudents; }
            set { _noOfStudents = value; }
        }

        private TrainerDetails _trainerDetails;

        public TrainerDetails TrainerDetails
        {
            get { return _trainerDetails; }
            set { _trainerDetails = value; }
        }

        private int _noOfTrainers;

        public int NoOfTrainers
        {
            get { return _noOfTrainers; }
            set { _noOfTrainers = value; }
        }

        private AssigmentDetails _assigmentDetails;

        public AssigmentDetails AssigmentDetails
        {
            get { return _assigmentDetails; }
            set { _assigmentDetails = value; }
        }

        /*
         * School Constrcuctors Start Point
         */
        public School(StudentDetails studentDetails, int noOfStudents)
        {
            StudentDetails = studentDetails;
            NoOfStudents = noOfStudents;
        }

        public School(TrainerDetails trainerDetails, int noOfTrainers)
        {
            TrainerDetails = trainerDetails;
            NoOfTrainers = noOfTrainers;
        }

        public School(TrainerDetails trainerDetails, int noOfTrainers, StudentDetails studentDetails, int noOfStudents)
        {
            TrainerDetails = trainerDetails;
            StudentDetails = studentDetails;
            NoOfStudents = noOfStudents;
            NoOfTrainers = noOfTrainers;
        }

        public School(AssigmentDetails assigmentDetails)
        {
            _assigmentDetails = assigmentDetails;
        }

        public School(CourseDetails )
        

        /*
         * School Constrcuctors End Point
         */

        public void Start()
        {
            Console.WriteLine("-----------------Private School Application Start----------------------------");


            Console.WriteLine("--------------------- List With Students ----------------------------------");

            StudentService studentService = new StudentService(_studentDetails, _noOfStudents);

            foreach(RandomStudent student in studentService.Students)
            {
                Console.WriteLine(student);
            }

            
        }

        public void StartTrainers()
        {
            Console.WriteLine("---------------------List With Trainers -----------------------------------------");

            TrainerService trainerService = new TrainerService(_trainerDetails, _noOfTrainers);

            foreach (RandomTrainer trainer in trainerService.Trainers)
            {
                Console.WriteLine(trainer);
            }
        }

        public void StartAssigments()
        {
            Console.WriteLine("------------------------------------List With Assigments ------------------------------------------");

            AssigmentService assigmentService = new AssigmentService(_assigmentDetails);

            foreach(RandomAssigment assigment in assigmentService.Assigments)
            {
                Console.WriteLine(assigment);
            }
        }
    }
}
