using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class EndDateTime
    {
        private int _endMonth;

        public int EndMonth
        {
            get { return _endMonth; }
            set { _endMonth = value; }
        }

        private int _endDay;

        public int EndDay
        {
            get { return _endDay; }
            set { _endDay = value; }
        }

        public EndDateTime(int endMonth, int endDay)
        {
            if(endMonth != 10 || endMonth != 1)
            {
                endMonth = 1;
            }
            if(endDay != 27)
            {
                endDay = 27;
            }
            EndMonth = endMonth;
            EndDay = endDay;

        }

        public override string ToString()
        {
            return $"EndDateTime {{ End Month : {EndMonth}, End Day : {EndDay} }}";
        }


    }
}
