using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.AssigmentsPerStudent
{
    class AssigmentPerStudentService : IAssigmentPerStudentService
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

        public Dictionary<int, int> AssigmentsPerStudent { get; private set; }

        public List<int> Students { get; private set; }
        public List<int> Assigments { get; private set; }

        public AssigmentPerStudentService(int count)
        {
            Students = InitializeNumberOfStudents(count);
            //PrintKeys(Courses);
            Assigments = InitializeNumberOfAssigments(count);
            AssigmentsPerStudent = InitializeAssigmentsPerStudent(Students, Assigments);
            //PrintDictionary(AssigmentsPerStudent);
        }
        public void PrintKeys(List<int> keys)
        {
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                Console.WriteLine(Students[i]);
            }
        }
        public Dictionary<int, int> InitializeAssigmentsPerStudent(List<int> keys, List<int> values)
        {
            Dictionary<int, int> AssigmentsPerCourse = new Dictionary<int, int>();
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                int key = keys[i];
                int value = values[i];
                AssigmentsPerCourse.Add(key, value);
            }
            return AssigmentsPerCourse;
        }
        

        public void PrintDictionary(Dictionary<int, int> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("Student = {0}, Assigment = {1}", item.Key, item.Value);
            }
        }
        public List<int> InitializeNumberOfAssigments(int count)
        {
            List<int> assigments = new List<int>();
            for (int i = 0; i <= count - 1; i++)
            {
                int assigmentsNum = numOfAssigments;
                assigments.Add(assigmentsNum);
            }
            return assigments;
        }

        public List<int> InitializeNumberOfStudents(int count)
        {
            List<int> students = new List<int>();
            for (int i = 0; i <= count - 1; i++)
            {
                students.Add(i);
            }
            return students;
        }
    }
}
