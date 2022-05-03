using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.AssigmentsPerCourse
{
    class AssigmentsPerCourseService : IAssigmentsPerCourseService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);

        private readonly int numOfAssigments = 8;

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        private int _numOfAssigments;

        public int NumOfAssigments
        {
            get { return _numOfAssigments; }
            set { _numOfAssigments = value; }
        }

        public Dictionary<int,int> AssigmentsPerCourse { get; private set; }

        public List<int> Courses { get; private set; }
        public List<int> Assigments { get; private set; }

        public AssigmentsPerCourseService(int count)
        {
            Courses = InitializeCourses(count);
            //PrintKeys(Courses);
            Assigments = InitializesNumberOfAssigmentsPerCourse(count);
            AssigmentsPerCourse = InitializeAssigmentsPerCourse(Courses, Assigments);
            //PrintDictionary(AssigmentsPerCourse);
        }
        public void PrintKeys(List<int> keys)
        {
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                Console.WriteLine(Courses[i]);
            }
        }
        public Dictionary<int,int> InitializeAssigmentsPerCourse(List<int> keys, List<int> values)
        {
            Dictionary<int, int> AssigmentsPerCourse = new Dictionary<int, int>();
            for(int i=0; i<=keys.Count-1; i++)
            {
                int key = keys[i];
                int value = values[i];
                AssigmentsPerCourse.Add(key, value);
            }
            return AssigmentsPerCourse;
        }
        public List<int> InitializeCourses(int count)
        {
            List<int> courses = new List<int>();
            for(int i = 0; i <= count - 1; i++)
            {
                courses.Add(i);
            }
            return courses;
        }

        public List<int> InitializesNumberOfAssigmentsPerCourse(int count)
        {
            List<int> assigments = new List<int>();
            for(int i=0; i<= count -1; i++)
            {
                int assigmentsNum = numOfAssigments;
                assigments.Add(assigmentsNum);
            }
            return assigments;
        }

        public void PrintDictionary(Dictionary<int, int> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("Course = {0}, Assigment = {1}", item.Key, item.Value);
            }
        }

        
    }
}
