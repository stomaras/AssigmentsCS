using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.domain.Course;

namespace PrivateSchool.services
{
    class CourseDetailsInputService
    {

        

        private CourseMinMax _cid;

        public CourseMinMax CID
        {
            get { return _cid; }
            set { _cid = value; }
        }

        private CourseTitle _courseTitle;

        public CourseTitle CourseTitle
        {
            get { return _courseTitle; }
            set { _courseTitle = value; }
        }

        private StreamTypes _streamTypes;

        public StreamTypes StreamTypes
        {
            get { return _streamTypes; }
            set { _streamTypes = value; }
        }

        private CourseType _courseType;

        public CourseType CourseType
        {
            get { return _courseType; }
            set { _courseType = value; }
        }

        private StartDateTime _startDateTime;

        public StartDateTime StartDateTime
        {
            get { return _startDateTime; }
            set { _startDateTime = value; }
        }

        private EndDateTime _endDateTime;

        public EndDateTime EndDateTime
        {
            get { return _endDateTime; }
            set { _endDateTime = value; }
        }

        public CourseDetailsInputService()
        {
            CID = InitializeCourseId();
            CourseTitle = InitializeCourseTitle();
            StreamTypes = InitializeStreamTypes();
            CourseType = InitializeCourseType();
            StartDateTime = InitializeStartDateTime();
            EndDateTime = InitializeEndDateTime();
        }

        public CourseMinMax InitializeCourseId()
        {
            Console.WriteLine("Enter min course id:\n");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max course id:\n");
            int max = Convert.ToInt32(Console.ReadLine());
            return new CourseMinMax(min, max);
        }

        public CourseTitle InitializeCourseTitle()
        {
            return new CourseTitle();
        }

        public StreamTypes InitializeStreamTypes()
        {
            Console.WriteLine("Enter minimum stream type:\n");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum stream type:\n");
            int max = Convert.ToInt32(Console.ReadLine());
            return new StreamTypes(min, max);
        }

        public CourseType InitializeCourseType()
        {
            return new CourseType();
        }

        public StartDateTime InitializeStartDateTime()
        {
            Console.WriteLine("Enter start day:\n");
            int startDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start month:\n");
            int startMonth = Convert.ToInt32(Console.ReadLine());
            return new StartDateTime(startMonth, startDay);
        }

        public EndDateTime InitializeEndDateTime()
        {
            Console.WriteLine("Enter end day:\n");
            int endDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end month:\n");
            int endMonth = Convert.ToInt32(Console.ReadLine());
            return new EndDateTime(endMonth, endDay);
        }






    }
}
