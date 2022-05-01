using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain.Course
{
    class RandomCourse : Course
    {

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        public RandomCourse(CourseDetails courseDetails)
        {
            _courseDetails = courseDetails;
            Cid = RandomService.Number(_courseDetails.CourseMinMax.Min, _courseDetails.CourseMinMax.Max);
            Title = RandomService.Course(_courseDetails.CourseTitle.Courses);
            StreamType = RandomService.Stream(_courseDetails.StreamTypes.Streams);
            Type = RandomService.Type(_courseDetails.CourseType.Courses);
            StartDate = new DateTime(DateTime.Now.Year, _courseDetails.StartDateTime.StartMonth, _courseDetails.StartDateTime.StartDay);
            EndDate = new DateTime(DateTime.Now.Year, _courseDetails.EndDateTime.EndMonth, _courseDetails.EndDateTime.EndDay);
        }



        public override string ToString()
        {
            return $"Course {{ Id: {Cid}, Title: {Title}, StreamType: {StreamType}, CourseType: {Type}, StartDateTime: {StartDate}, EndDateTime: {EndDate}}}";
        }
    }
}
