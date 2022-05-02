using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.StudentsPerCourse
{
    class StudentsPerCourseService : IStudentsPerCourseService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);


        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        private int _numOfStudents;

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set { _numOfStudents = value; }
        }

        public Dictionary<int,int> StudentsPerCoursee { get; private set; }

        public List<int> Keys { get; private set; }
        public List<int> Values { get; private set; }



        public StudentsPerCourseService(int count)
        {
            //Console.WriteLine(count);
            Keys = NumberOfCoursesInitializationKey(count);
            //PrintKeys(Keys);
            Values = NumberOfStudentsPerCourseInitializationValue(count);
            //PrintValues(Values);
            StudentsPerCoursee = InitializeStudentsPerCourse(Keys,Values);
            PrintDictionary(StudentsPerCoursee);
        }

        public void PrintKeys(List<int> keys)
        {
            for(int i=0; i<= keys.Count-1; i++)
            {
                Console.WriteLine(Keys[i]);
            }
        }

        public void PrintValues(List<int> values)
        {
            for(int i=0; i<= values.Count-1; i++)
            {
                Console.WriteLine(Values[i]);
            }
        }

        public void PrintDictionary(Dictionary<int,int> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("Course = {0}, Students = {1}", item.Key, item.Value);
            }
        }


       
        public Dictionary<int,int> InitializeStudentsPerCourse(List<int> keys, List<int> values)
        {
            Dictionary<int, int> StudentsPerCourse= new Dictionary<int, int>();
            for(int i=0; i<= keys.Count-1; i++)
            {
                int key = keys[i];
                int value = values[i];
                StudentsPerCourse.Add(key, value);
            }
            return StudentsPerCourse;
        }



        public List<int> NumberOfCoursesInitializationKey(int count)
        {
            List<int> keys = new List<int>();
            for (int i = 0; i <= count - 1; i++)
            {
                keys.Add(i);
            }

            return keys;
        }

        public List<int> NumberOfStudentsPerCourseInitializationValue(int count)
        {
            List<int> values = new List<int>();
            for (int i = 0; i <= count - 1; i++)
            {
                int studentsNum = _rand.Next(1, 40);
                values.Add(studentsNum);
            }
            return values;
        }

       

    }
}
