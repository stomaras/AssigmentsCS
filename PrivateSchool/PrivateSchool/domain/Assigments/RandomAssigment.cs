using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;
using PrivateSchool.domain.Assigments;

namespace PrivateSchool.domain
{
    class RandomAssigment : Assigment
    {

        private AssigmentDetails _assigmentDetails;


        public RandomAssigment (AssigmentDetails assigmentDetails)
        {
            _assigmentDetails = assigmentDetails;
            Aid = RandomService.Number(_assigmentDetails.Id.Min, _assigmentDetails.Id.Max);
            Title = RandomService.RandomAssigment(_assigmentDetails.AssigmentTitle.AssigmentsTitles);
            Description = RandomService.Name(_assigmentDetails.Description.Min, _assigmentDetails.Description.Max, _assigmentDetails.Description.Length);
            SubDateTime = RandomService.RandomSubmissionDateTime(_assigmentDetails.SubDateTime.MinMonth, _assigmentDetails.SubDateTime.MaxMonth, _assigmentDetails.SubDateTime.MinDay, _assigmentDetails.SubDateTime.MaxDay);
            OralMark = RandomService.Number(_assigmentDetails.OralMark.Min, _assigmentDetails.OralMark.Max);
            TotalMark = _assigmentDetails.TotalMark.TotalMarkk;
        }

        public RandomAssigment (AssigmentDetails assigmentDetails, int id)
        {
            _assigmentDetails = assigmentDetails;
            Aid = id;
            Title = RandomService.RandomAssigment(_assigmentDetails.AssigmentTitle.AssigmentsTitles);
            Description = RandomService.Name(_assigmentDetails.Description.Min, _assigmentDetails.Description.Max, _assigmentDetails.Description.Length);
            SubDateTime = RandomService.RandomSubmissionDateTime(_assigmentDetails.SubDateTime.MinMonth, _assigmentDetails.SubDateTime.MaxMonth, _assigmentDetails.SubDateTime.MinDay, _assigmentDetails.SubDateTime.MaxDay);
            OralMark = RandomService.Number(_assigmentDetails.OralMark.Min, _assigmentDetails.OralMark.Max);
            TotalMark = _assigmentDetails.TotalMark.TotalMarkk;
        }

        public RandomAssigment(AssigmentDetails assigmentDetails, int id, string title)
        {
            _assigmentDetails = assigmentDetails;
            Aid = id;
            Title = title;
            Description = RandomService.Name(_assigmentDetails.Description.Min, _assigmentDetails.Description.Max, _assigmentDetails.Description.Length);
            SubDateTime = RandomService.RandomSubmissionDateTime(_assigmentDetails.SubDateTime.MinMonth, _assigmentDetails.SubDateTime.MaxMonth, _assigmentDetails.SubDateTime.MinDay, _assigmentDetails.SubDateTime.MaxDay);
            OralMark = RandomService.Number(_assigmentDetails.OralMark.Min, _assigmentDetails.OralMark.Max);
            TotalMark = _assigmentDetails.TotalMark.TotalMarkk;
        }

        public override string ToString()
        {
           string s = $"Assigment {{ Id : {Aid}, Title : {Title}, Description : {Description}, DateTime : {SubDateTime}, Oral Mark : {OralMark} / Total Mark : {TotalMark} }}";
            return s;
        }
    }
}
