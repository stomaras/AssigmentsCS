using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class StartDateTime
    {
        private int _startMonth;

        public int StartMonth
        {
            get { return _startMonth; }
            set { _startMonth = value; }
        }

       

        private int _startDay;

        public int StartDay
        {
            get { return _startDay; }
            set { _startDay = value; }
        }


        public StartDateTime(int startMonth, int startDay)
        {
            if(startMonth != 2 || startMonth != 10)
            {
                startMonth = 2;
            }
            if(startDay != 28)
            {
                startDay = 28;
            }
            StartMonth = startMonth;
            StartDay = startDay;
        }

        public override string ToString()
        {
            return $"StartDateTime: {{ Start Month : {StartMonth}, Start Day : {StartDay} }}";
        }



    }
}
