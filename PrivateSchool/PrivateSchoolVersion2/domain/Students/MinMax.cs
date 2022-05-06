using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolVersion2.domain.Students
{
    class MinMax
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

        private double _minTuitionFees;

        public double MinTuitionFees
        {
            get { return _minTuitionFees; }
            set { _minTuitionFees = value; }
        }

        private double _maxTuitionFees;

        public double MaxTuitionFees
        {
            get { return _maxTuitionFees; }
            set { _maxTuitionFees = value; }
        }

        
        public MinMax(int min, int max)
        {
            if(min < 0 || min > max || max < 0)
            {
                min = 1;
                max = 200;
                Min = min;
                Max = max;
            }
        }

        public MinMax(double minTuitionFees, double maxTuitionFees)
        {
            if(minTuitionFees < 1000 || minTuitionFees > maxTuitionFees || maxTuitionFees > 2500)
            {
                minTuitionFees = 1000;
                maxTuitionFees = 2500;
                MinTuitionFees = minTuitionFees;
                MaxTuitionFees = maxTuitionFees;
            }
            
        }

        public override string ToString()
        {
            return $"MinMax {{ Min generation id:{Min}, Max generation id:{Max}, Min tuition fees {MinTuitionFees}, Max tuition fees {MaxTuitionFees}  }}";
        }


    }
}
