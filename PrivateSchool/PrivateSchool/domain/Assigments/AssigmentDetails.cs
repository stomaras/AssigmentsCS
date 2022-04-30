using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain.Assigments
{
    class AssigmentDetails
    {

        private MinMaxAssigment _id;

        public MinMaxAssigment Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private AssigmentTitle _assigmentTitle;

        public AssigmentTitle AssigmentTitle
        {
            get { return _assigmentTitle; }
            set { _assigmentTitle = value; }
        }


        private NameMinMax _description;

        public NameMinMax Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private SubDateTime _subDateTime;

        public SubDateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        private OralMark _oralMark;

        public OralMark OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        private TotalMark _totalMark;

        public TotalMark TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        public AssigmentDetails(MinMaxAssigment aid, AssigmentTitle title, NameMinMax description, SubDateTime submissionDateTime, OralMark oralMark, TotalMark totalMark)
        {
            Id = aid;
            AssigmentTitle = title;
            Description = description;
            SubDateTime = submissionDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
            //Title = title;

            //Description = description;
            //SubDateTime = subDateTime;
            //OralMark = oralMark;
            
        }



        public override string ToString()
        {
            string s = $"AssigmentDetails {{ Id with min id {Id.Min} with max id {Id.Max}\n with title assigment Titles {AssigmentTitle.ToString()} ";
            s = s + $" \n with description min ascii character {Description.Min}, with description max ascii character {Description.Max}, with Length of description {Description.Length}";
            s = s + $" \n with submission date time Year {SubDateTime.Year}, with submission date time Min Montgh {SubDateTime.MinMonth}, with submission date time Max Month {SubDateTime.MaxMonth}, with submission date time Min Day {SubDateTime.MinDay}, with submission date time Max Day {SubDateTime.MaxDay}";
            s = s + $" \n with oral mark min mark {OralMark.Min}, with max mark {OralMark.Max}";
            s = s + $" \n with total mark {TotalMark.TotalMarkk}";
            return s;
        }
    }
}
