using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_2D_Array_of_Objects
{
    class Country
    {
         public string Continent { get; set; }
        public string Language { get; set; }

        public Country(string continent, string language)
        {
            Continent = continent;
            Language = language;
        }

        public virtual void DisplayCountriesInfo()
        {
            Console.WriteLine("Continent: "+Continent);
            Console.WriteLine("Language: "+Language);
        }
    }

    class Philippines : Country
    {
        public string KnownFigure { get; set; }

        public Philippines(string continent, string language, string knownfigure)
            : base(continent, language)
        {
            KnownFigure = knownfigure;
        }

        public override void DisplayCountriesInfo()
        {
           Console.WriteLine("\t" + Continent + "\t\t" + Language + "\t\t"+KnownFigure);
        }
    }
}
