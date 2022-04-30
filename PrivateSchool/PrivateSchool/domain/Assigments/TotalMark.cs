using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class TotalMark
    {

        private int _totalMark;

        public int TotalMarkk
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        

       public TotalMark(int numOfOralMarks)
        {
            TotalMarkk = 20;
        }

        public override string ToString()
        {
            return $"TotalMark {{ totalMark {TotalMarkk} }}";
        }
    }
}
