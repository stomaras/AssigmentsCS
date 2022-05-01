using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class CourseMinMax
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

        public CourseMinMax(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return $"CourseMinMax {{ Min : {Min}, Max : {Max} }}";
        }
    }
}
