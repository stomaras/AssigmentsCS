using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PrivateSchool.domain;



namespace PrivateSchool.services
{
    
    class CSVDataInputService
    {

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }

        private int _noOfStudents;

        public int NoOfStudents
        {
            get { return _noOfStudents; }
            set { _noOfStudents = value; }
        }

        private int _noOfTrainers;

        public int NoOfTrainers
        {
            get { return _noOfTrainers; }
            set { _noOfTrainers = value; }
        }

        private TrainerDetails _trainerDetails;

        public TrainerDetails TrainerDetails
        {
            get { return _trainerDetails; }
            set { _trainerDetails = value; }
        }





        public CSVDataInputService(string filename)
        {

            
            using (var reader = new StreamReader(filename))// using with resources
            {
                var counter = 0;
                MinMax sid;
                MinMax tuitionFees;
                NameMinMax firstName;
                NameMinMax lastName;
                DateBirth dateBirth;

                MinMax tid;
                NameMinMax trainerFirstName;
                NameMinMax trainerLastName;
                Subject subject;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter > 0 && counter == 1)
                    {
                        var values = line.Split(';');
                        NoOfStudents = Convert.ToInt32(values[0]);
                        sid = new MinMax(Convert.ToInt32(values[1]), Convert.ToInt32(values[2]));
                        tuitionFees = new MinMax(Convert.ToDouble(values[3]), Convert.ToDouble(values[4]));
                        firstName = new NameMinMax(Convert.ToInt32(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]));
                        lastName = new NameMinMax(Convert.ToInt32(values[8]), Convert.ToInt32(values[9]), Convert.ToInt32(values[10]));
                        dateBirth = new DateBirth(Convert.ToInt32(values[11]), Convert.ToInt32(values[12]), Convert.ToInt32(values[13]), Convert.ToInt32(values[14]), Convert.ToInt32(values[15]), Convert.ToInt32(values[16]));
                        StudentDetails = new StudentDetails(sid, firstName, lastName, dateBirth, tuitionFees);
                    }
                    if(counter > 2 && counter == 3)
                    {
                        Console.WriteLine("ddddddddddddd");
                        var trainerValues = line.Split(';');
                        NoOfTrainers = Convert.ToInt32(trainerValues[0]);
                        Console.WriteLine(NoOfTrainers);
                        tid = new MinMax(Convert.ToInt32(trainerValues[1]), Convert.ToInt32(trainerValues[2]));
                        trainerFirstName = new NameMinMax(Convert.ToInt32(trainerValues[3]), Convert.ToInt32(trainerValues[4]), Convert.ToInt32(trainerValues[5]));
                        trainerLastName = new NameMinMax(Convert.ToInt32(trainerValues[6]), Convert.ToInt32(trainerValues[7]), Convert.ToInt32(trainerValues[8]));
                        subject = new Subject();
                        TrainerDetails = new TrainerDetails(tid, trainerFirstName, trainerLastName, subject);
                        Console.WriteLine(TrainerDetails.ToString());
                    }
                    counter++;
                }
            }
            Console.WriteLine(NoOfStudents);
            Console.WriteLine(StudentDetails);
        }

        
    }
}
