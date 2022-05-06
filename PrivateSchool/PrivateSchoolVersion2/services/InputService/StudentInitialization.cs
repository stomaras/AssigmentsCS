using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolVersion2.domain.Students;
using PrivateSchoolVersion2.domain;

namespace PrivateSchoolVersion2.services.InputService
{
    class StudentInitialization
    {

        public static int InitializeNumOfStudentss()
        {
            Console.WriteLine("Enter Number Of Students:\n");
            int numOfStudents = Convert.ToInt32(Console.ReadLine());
            return numOfStudents;
        }

        public static MinMax InitializeStudentId()
        {
            Console.WriteLine("Enter Min Id:\n");
            int minId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Id:\n");
            int maxId = Convert.ToInt32(Console.ReadLine());
            return new MinMax(minId, maxId);
        }
    }
}
