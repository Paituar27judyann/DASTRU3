using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkesListInOOP
{
    class Country
    {
        public string NationalSport { get; set; }
        public string Language { get; set; }

        public Country(string nationalSport, string language)
        {
            NationalSport = nationalSport;
            Language = language;
        }
        //Base class method
        public virtual void DisplayInfo()
        {
            //Ensure that the output will be align 
            Console.Write($"{NationalSport,-20} {Language,-20}");
        }
    }
    //Derived Class
    class Asia : Country
    {
        public string KnownFigure { get; set; }

        public Asia(string nationalSport, string language, string knownFigure)
            : base(nationalSport, language)
        {
            KnownFigure = knownFigure;
        }
        //Derived method from base class
        public override void DisplayInfo()
        {           
            base.DisplayInfo();
           
            Console.WriteLine($"{KnownFigure,-20}");
        }
    }

    class CountryManager
    {
        private LinkedList<Country> countryList = new LinkedList<Country>();

        public void Insert(Country country)
        {
            countryList.AddLast(country);
            Console.WriteLine("\n>> Successfully added.");
        }

        //Condition if you want to remove record
        public void Remove(string language)
        {
            var node = countryList.First;
            bool found = false;

            while (node != null)
            {
                if (node.Value.Language.Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    countryList.Remove(node);
                    Console.WriteLine($"\n>> Record with language '{language}' has been removed.");
                    found = true;
                    break;
                }
                node = node.Next;
            }

            if (!found) Console.WriteLine("\n>> Error: No record found with that language.");
        }
        

        public void DisplayAll()
        {

            if (countryList.Count == 0)
            {
                Console.WriteLine("\n>> List is empty.");
                return;
            }

            Console.WriteLine("\n" + new string('=', 60));
         
            Console.WriteLine($"{"NATONAL SPORT",-20} {"LANGUAGE",-20} {"KNOWN FIGURE",-20}");
            Console.WriteLine(new string('-', 60));

            foreach (var country in countryList)
            {
                country.DisplayInfo();
            }
            Console.WriteLine(new string('=', 60));
        }
    }
}



