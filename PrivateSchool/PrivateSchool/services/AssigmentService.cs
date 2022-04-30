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

            for(int i=0; i<numOfAssigments; i++)
            {
                assigments.Add(new RandomAssigment(_assigmentDetails));
            }
            return assigments;
        }




    }
}
