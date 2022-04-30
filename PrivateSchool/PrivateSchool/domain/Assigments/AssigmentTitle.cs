using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Assigments
{
    class AssigmentTitle : INameTitle
    {
        private List<string> _assigmentsTitles;

        public List<string> AssigmentsTitles
        {
            get { return _assigmentsTitles; }
            set { _assigmentsTitles = value; }
        }


        public AssigmentTitle()
        {
            AssigmentsTitles = initializeList();
        }
        public List<string> initializeList()
        {
            List<string> assigmentTitle = new List<string>();
            assigmentTitle.Add("Assigment 1");
            assigmentTitle.Add("Assigment 2");
            assigmentTitle.Add("Assigment 3");
            assigmentTitle.Add("Assigment 4");
            assigmentTitle.Add("Individual Project Part A");
            assigmentTitle.Add("Individual Project Part B");
            assigmentTitle.Add("Group Project");

            return assigmentTitle;

        }

        public override string ToString()
        {
            string s = " NameMinMaxTitle :";
            Console.WriteLine("\n");
            for (int i = 0; i <= AssigmentsTitles.Count - 1; i++)
            {
                s += $" {i + 1}st Assigment name: {AssigmentsTitles[i]}, ";
                
            }
            
            return s;
        }
    }
}
