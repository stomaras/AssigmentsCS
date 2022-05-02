using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain.Assigments;
using PrivateSchool.domain;
namespace PrivateSchool.services
{
    class AssigmentDetailsInputService
    {
        private MinMaxAssigment _aid;

        public MinMaxAssigment Aid
        {
            get { return _aid; }
            set { _aid = value; }
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

        public AssigmentDetailsInputService()
        {
            Aid = InitializeAssigment();
            AssigmentTitle = new AssigmentTitle();
            Description = InitializeDescription();
            SubDateTime = InitializeSubmissionDateTime();
            OralMark = InitializeOralMark();
            TotalMark = InitializeTotalMark(Aid.Max);
            
        }

        public MinMaxAssigment InitializeAssigment()
        {
            Console.WriteLine("Enter min assigment id:\n");
            int minAid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max assigment id:\n");
            int maxAid = Convert.ToInt32(Console.ReadLine());
            return new MinMaxAssigment(minAid, maxAid);
        }

        public NameMinMax InitializeDescription()
        {
            Console.WriteLine("Enter min ascii description:\n");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max ascii description:\n");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Length of Description:\n");
            int description = Convert.ToInt32(Console.ReadLine());
            return new NameMinMax(min, max, description);
        }

        public SubDateTime InitializeSubmissionDateTime()
        {
            Console.WriteLine("Enter a year:\n");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter min month:\n");
            int minMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max month:\n");
            int maxMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter min day:\n");
            int minDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max day:\n");
            int maxDay = Convert.ToInt32(Console.ReadLine());
            return new SubDateTime(year, minMonth, maxMonth, minDay, maxDay);
        }

        public OralMark InitializeOralMark()
        {
            Console.WriteLine("Enter min oral mark:\n");
            int minOral = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max oral mark:\n");
            int maxOral = Convert.ToInt32(Console.ReadLine());
            return new OralMark(minOral, maxOral);
        }

        public TotalMark InitializeTotalMark(int num)
        {
            return new TotalMark(num);
        }

    }
}
