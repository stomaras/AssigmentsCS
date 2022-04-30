using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain
{
    // One Assigment Per Month
    /*
     * Months for Each Assigment 6-12
     * Days for Each Assigment 1-4 days of this month
     * 
     */
    class SubDateTime
    {
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _minMonth;

        public int MinMonth
        {
            get { return _minMonth; }
            set { _minMonth = value; }
        }

        private int _maxMonth;

        public int MaxMonth
        {
            get { return _maxMonth; }
            set { _maxMonth = value; }
        }

        private int _minDay;

        public int MinDay
        {
            get { return _minDay; }
            set { _minDay = value; }
        }

        private int _maxDay;

        public int MaxDay
        {
            get { return _maxDay; }
            set { _maxDay = value; }
        }

        public SubDateTime(int year, int minMonth, int maxMonth, int minDay, int maxDay)
        {
            year = DateTime.Now.Year;
            minMonth = 6;
            maxMonth = 12;
            minDay = 1;
            maxDay = 5;

            Year = year;
            MinMonth = minMonth;
            MaxMonth = maxMonth;
            MinDay = minDay;
            MaxDay = maxDay;
        }

        public override string ToString()
        {
            return $"SubDateTime {{  Year : {Year}, Min Month {MinMonth}, Max Month {MaxMonth}, Min Day {MinDay}, Max Day {MaxDay}}} ";
        }










    }
}
