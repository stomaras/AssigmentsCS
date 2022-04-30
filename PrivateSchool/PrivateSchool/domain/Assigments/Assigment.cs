using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    abstract class Assigment
    {

        private int _aid;

        public int Aid
        {
            get { return _aid; }
            set { _aid = value; }
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _subDateTime;

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        private int _oralMark;

        public int OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        private int _totalMark;

        public int TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        public abstract override string ToString();





    }
}
