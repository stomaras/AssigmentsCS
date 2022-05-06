using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolVersion2.domain.Students
{
    class StudentDetails
    {
        private int _numOfStudents;

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set { _numOfStudents = value; }
        }


        private MinMax _id;

        public MinMax Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private MinMax _tuitionFees;

        public MinMax TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }

        private FirstNames _firstNames;

        public FirstNames FirstNames
        {
            get { return _firstNames; }
            set { _firstNames = value; }
        }

        public StudentDetails(MinMax sid, int numOfStudents)
        {
            Id = sid;
            NumOfStudents = numOfStudents;
        }



    }
}
