using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_Single_Dimensional_Array_of_Objects_in_OOP
{
    internal class Country
    {
        // Countries Properties
        public string Continent { get; set; }
        public string Language { get; set; }

        public Country(string continent, string language)
        {
            Continent = continent;
            Language = language;
        }

        public virtual void DisplayCountriesInfo()
        {
            Console.WriteLine("Continent: " + Continent);
            Console.WriteLine("Language: " + Language);
        }
    }

    class Philippines : Country
    {
        public string NationalHero { get; set; }
        public Philippines(string continent, string language, string nationalHero)
            : base(continent, language)
        {
            NationalHero = nationalHero;
        }

        public override void DisplayCountriesInfo()
        {
            Console.WriteLine("\n\t\t\t\t--- Countries Information ---");
            Console.WriteLine("\t\t\t\tContinent: " + Continent);
            Console.WriteLine("\t\t\t\tLanguage: " + Language);
            Console.WriteLine("\t\t\t\tNational Hero: " + NationalHero);

        }
    }
}
