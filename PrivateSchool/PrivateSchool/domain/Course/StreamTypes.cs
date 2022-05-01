using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain.Course
{
    class StreamTypes : IStreamTypes
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

        public List<string> Streams { get; private set; }
       

        public StreamTypes(int min, int max)
        {
            
            min = 1;
            max = 180;
            Min = min;
            Max = max;
            Streams = InitializeStreamTypes(min, max);
        }

        public List<string> InitializeStreamTypes(int min, int max)
        {
            List<string> streamTypes = new List<string>();
            string result = "CB";
            int num = 0;
            for(int i = min; i<= max; i++)
            {
                num = i;
                result = "CB";
                num = RandomService.Number(min, max);
                result += num;
                streamTypes.Add(result);
            }
            return streamTypes;
        }

        public override string ToString()
        {
            string s = $"StreamType {{";
            s = s + $" min {Min}, max {Max}\n";
            for(int i = Min; i<= Max-1; i++)
            {
                s = s + $"\t{Streams[i]}";
            }
            s = s + $"}}";
            return s;
            
        }

    }
}
