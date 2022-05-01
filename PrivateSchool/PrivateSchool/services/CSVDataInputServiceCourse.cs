using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Course;
using System.IO;

namespace PrivateSchool.services
{
    class CSVDataInputServiceCourse
    {

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        private int _numOfCourses;

        public int NumOfCourses
        {
            get { return _numOfCourses; }
            set { _numOfCourses = value; }
        }

        public CSVDataInputServiceCourse(string filename)
        {
            Console.WriteLine("dfsdcvcfdf");
            using (var reader = new StreamReader(filename))
            {
                var counter = 0;

                CourseMinMax cid;
                CourseTitle courseTitle;
                CourseType courseType;
                StreamTypes stream;
                StartDateTime startDateTime;
                EndDateTime endDateTime;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter > 0)
                    {
                        var values = line.Split(';');
                        NumOfCourses = Convert.ToInt32(values[0]);
                        cid = new CourseMinMax(Convert.ToInt32(values[1]), Convert.ToInt32(values[2]));
                        courseTitle = new CourseTitle();
                        stream = new StreamTypes(Convert.ToInt32(values[3]), Convert.ToInt32(values[4]));
                        courseType = new CourseType();
                        startDateTime = new StartDateTime(Convert.ToInt32(values[5]), Convert.ToInt32(values[6]));
                        endDateTime = new EndDateTime(Convert.ToInt32(values[7]), Convert.ToInt32(values[8]));
                        CourseDetails = new CourseDetails(cid, courseTitle, stream, courseType, startDateTime, endDateTime);
                    }
                    counter++;
                }
                
            }
        }
    }
}

