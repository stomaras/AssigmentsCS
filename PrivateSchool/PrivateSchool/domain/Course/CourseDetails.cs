using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    class CourseDetails
    {
        private CourseMinMax _courseMinMax;

        public CourseMinMax CourseMinMax
        {
            get { return _courseMinMax; }
            set { _courseMinMax = value; }
        }

        private CourseTitle _courseTitle;

        public CourseTitle CourseTitle
        {
            get { return _courseTitle; }
            set { _courseTitle = value; }
        }

        public StreamTypes _streamTypes;

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


        public CourseDetails(CourseMinMax courseMinMax, CourseTitle courseTitle, StreamTypes streamTypes, CourseType courseType, StartDateTime startDateTime, EndDateTime endDateTime)
        {
            CourseMinMax = courseMinMax;
            CourseTitle = courseTitle;
            StreamTypes = streamTypes;
            CourseType = courseType;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }


        public override string ToString()
        {
            string s = $"CourseDetails {{\n CourseMinMax: min id{CourseMinMax.Min}, max id{CourseMinMax.Max},\n CourseTitle {CourseTitle.ToString()},\n StreamTypes {StreamTypes.ToString()},\n Type {CourseType.ToString()},\n Start Date {StartDateTime.ToString()},\n End Date {EndDateTime.ToString()}}}";
            return s;
        }
    }
}
