using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_Two_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Country = new string[3, 3]
            {
                {"\nR1: \tAsia","\tJapan","\tJapanese"},
                {"\nR2:\tEurope","\tPoland","\tPolish" },
                {"\nR3:\tAfrica","\tEgpyt","\tArabic"}
            };

            Console.WriteLine("-------Countries Information------");
            Console.WriteLine("\n     Continent\tCountry\tLanguage");

            for ( int r =0; r < 3 ; r++)
            {
                for (int c =0; c < 3;c++)
                {
                    Console.Write(Country[r, c]);
                }
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
