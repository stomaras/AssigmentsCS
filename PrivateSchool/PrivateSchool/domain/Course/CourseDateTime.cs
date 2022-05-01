using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class CourseDateTime
    {
        private CourseStartDateTime _courseStartDateTime;

        public CourseStartDateTime CourseStartDateTime
        {
            get { return _courseStartDateTime; }
            set { _courseStartDateTime = value; }
        }

        private CourseEndDateTime _endDateTime;

        public CourseEndDateTime CourseEndDateTime
        {
            get { return _endDateTime; }
            set { _endDateTime = value; }
        }

        public CourseDateTime(int startMonth, int endMonth, int startDay, int endDay)
        {
            if(startMonth != 2 || startMonth != 10)
            {
                startMonth = 2;
            }
        }


    }
}
