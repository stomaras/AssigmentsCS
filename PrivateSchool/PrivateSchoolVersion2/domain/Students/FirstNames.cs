using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolVersion2.domain.Students
{
    class FirstNames : IFirstNames
    {

        private int _numOfStudents;

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set { _numOfStudents = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }



        public List<string> FirstNamess { get; private set; }
        
        public FirstNames(int numOfStudents, string firstName)
        {
            NumOfStudents = numOfStudents;
            FirstName = firstName;
            FirstNamess = InitializeFirstNames(firstName);
        }

        public List<string> InitializeFirstNames(string name)
        {
            List<string> firstNames = new List<string>();
            for(int i=0; i<= NumOfStudents-1; i++)
            {
                firstNames.Add(name);
            }
            return firstNames;
        }
    }
}
