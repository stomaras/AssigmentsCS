using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    abstract class Course
    {
        private int _cid;

        public int Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _stream;

        public string StreamType
        {
            get { return _stream; }
            set { _stream = value; }
        }


        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public abstract override string ToString();





    }
}
