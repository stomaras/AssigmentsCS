using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class OralMark
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

        public OralMark(int min, int max)
        {
            
            if(min != 0 || max != 20)
            {
                min = 0;
                max = 20;
            }
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return $"Oral Mark {{ Min Oral Mark {Min} Max Oral Mark {Max} }}";
        }
    }
}
