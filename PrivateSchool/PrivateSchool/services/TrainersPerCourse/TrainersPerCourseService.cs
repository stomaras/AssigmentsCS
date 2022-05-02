using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services.TrainersPerCourse
{
    class TrainersPerCourseService : ITrainerPerCourseService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        private int _numOfTrainers;

        public int NumOfTrainers
        {
            get { return _numOfTrainers; }
            set { _numOfTrainers = value; }
        }

        public Dictionary<int, int> TrainersPerCoursee { get; private set; }

        public List<int> Keys { get; private set; }
        public List<int> Values { get; private set; }


        public TrainersPerCourseService(int count)
        {
            //Console.WriteLine(count);
            Keys = NumberOfCoursesInitializationKey(count);

            Values = NumberOfTrainersPerCourseInitializationValue(count);
            //PrintValues(Values);
            TrainersPerCoursee = InitializeTrainersPerCourse(Keys, Values);
            //PrintDictionary(TrainersPerCoursee);
        }

        public void PrintKeys(List<int> keys)
        {
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                Console.WriteLine(Keys[i]);
            }
        }

        public void PrintValues(List<int> values)
        {
            for (int i = 0; i <= values.Count - 1; i++)
            {
                Console.WriteLine(Values[i]);
            }
        }

        public void PrintDictionary(Dictionary<int, int> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("Course = {0}, Students = {1}", item.Key, item.Value);
            }
        }


        public Dictionary<int, int> InitializeTrainersPerCourse(List<int> keys, List<int> values)
        {
            Dictionary<int, int> TrainersPerCourse = new Dictionary<int, int>();
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                int key = keys[i];
                int value = values[i];
                TrainersPerCourse.Add(key, value);
            }
            return TrainersPerCourse;
        }

        

        public List<int> NumberOfTrainersPerCourseInitializationValue(int count)
        {
            List<int> values = new List<int>();
            for (int i = 0; i <= count - 1; i++)
            {
                int trainersNum = _rand.Next(5, 30);
                values.Add(trainersNum);
            }
            return values;
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

        
    }
}
