using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;
using PrivateSchool.domain;

namespace PrivateSchool.services.TrainersPerCourse
{
    class TrainersPerCourse
    {
        private TrainersPerCourseService _trainersPerCourseService;

        public TrainersPerCourseService TrainersPerCourseService
        {
            get { return _trainersPerCourseService; }
            set { _trainersPerCourseService = value; }
        }

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        private TrainerDetails _trainerDetails;

        public TrainerDetails TrainerDetails
        {
            get { return _trainerDetails; }
            set { _trainerDetails = value; }
        }


        private List<int> _courses;

        public List<int> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        private List<int> _trainers;

        public List<int> Trainers
        {
            get { return _trainers; }
            set { _trainers = value; }
        }

        public TrainersPerCourse(TrainersPerCourseService trainersPerCourseService, CourseDetails courseDetails, TrainerDetails trainerDetails)
        {
            TrainersPerCourseService = trainersPerCourseService;
            Courses = TrainersPerCourseService.Keys;
            //PrintList(Courses);
            Trainers = TrainersPerCourseService.Values;
            CourseDetails = courseDetails;
            TrainerDetails = trainerDetails;
            GenerateTrainersPerCourse(Courses, Trainers, CourseDetails, TrainerDetails);
            //PrintList(Students);
        }



        public void GenerateTrainersPerCourse(List<int> courses, List<int> trainers, CourseDetails courseDetails, TrainerDetails trainerDetails)
        {
            for (int i = 0; i <= courses.Count - 1; i++)
            {
                var course = new RandomCourse(courseDetails);
                Console.WriteLine("\n");
                Console.WriteLine("Course:\t" + course + "\nWith Trainers:\n");
                int trainerLength = trainers[i];
                for (int j = 0; j <= trainerLength - 1; j++)
                {
                    var trainer = new RandomTrainer(trainerDetails);
                    Console.WriteLine("Trainer:\t" + trainer);
                }
            }
        }



    }
}
