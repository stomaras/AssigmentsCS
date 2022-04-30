using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class MinMaxAssigment
    {
        private int _min;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        private int _max;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public MinMaxAssigment(int min, int max)
        {
            Min = 1;
            Max = 7;
        }

        public override string ToString()
        {
            return $"MinMaxAssigment {{ Min number of assigments: {Min}, Max number of assigments {Max} }}";
        }
    }
}
