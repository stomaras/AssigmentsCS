using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.domain.Assigments;


namespace PrivateSchool.services
{
    class AssigmentService
    {
        private int numOfAssigments = 7;

        private AssigmentDetails _assigmentDetails;

        public AssigmentDetails AssigmentDetails
        {
            get { return _assigmentDetails; }
            set { _assigmentDetails = value; }
        }


        public List<Assigment> Assigments {get; private set;}

        public AssigmentService(AssigmentDetails assigmentDetails)
        {
            _assigmentDetails = assigmentDetails;
            numOfAssigments = 7;
            Assigments = GenerateAssigments();
        }

        public List<Assigment> GenerateAssigments()
        {
            List<Assigment> assigments = new List<Assigment>();
            assigments.Add(new RandomAssigment(_assigmentDetails));

            for(int i=0; i<numOfAssigments; i++)
            {
                
                assigments.Add(new RandomAssigment(_assigmentDetails, GenerateUniqueId(GetAssigmentsIds(assigments))));
            }
            return assigments;
        }

     
        private List<int> GetAssigmentsIds(List<Assigment> assigments)
        {
            return (new List<int>(assigments.Select(assigment => assigment.Aid)));
        }

        private int GenerateUniqueId(List<int> ids)
        {
            var newId = RandomService.Number(_assigmentDetails.Id.Min, _assigmentDetails.Id.Max);
            while (ids.Contains(newId))
            {
                newId = RandomService.Number(_assigmentDetails.Id.Min, _assigmentDetails.Id.Max);
            }
            return newId;
        }

        private string[] GetAssigmentsTitles(List<Assigment> assigments)
        {
            List<string> titles = new List<string>(assigments.Select(assigment => assigment.Title));
            Console.WriteLine(titles.Count);
            string[] array = titles.ToArray();
            for(int i=0; i<= titles.Count-1; i++)
            {
                array[i] = titles[i];
            }
          
            return array;
        }

        private string GenerateUniqueTitle(string[] titles)
        {
            List<string> listNames = new List<string>(titles.Length);
            for (int i = 0; i <= titles.Length-1; i++)
            {
                listNames.Add(titles[i]);
            }


            string newAssigmentName = RandomService.Course(titles);
            while (listNames.Contains(newAssigmentName))
            {
                newAssigmentName = RandomService.Course(titles);
            }
            return newAssigmentName;
        }



    }
}
