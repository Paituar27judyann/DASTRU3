using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_Single_Dimensional_Array_of_Objects_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Judy Ann Paituar
            // Problem: ACTIVITY 2: Single Dimensional Array of Objects in OOP

            Console.Write("Enter how many countries you want to input: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Defaulting to 1.");
                size = 1;
            }

            Country[] countries = new Country[size];

            // Loop
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nEnter details for Country #{i + 1}:");

                Console.Write("Continent: ");
                string cont = Console.ReadLine();

                Console.Write("Language: ");
                string lang = Console.ReadLine();

                Console.Write("National Hero: ");
                string hero = Console.ReadLine();


                countries[i] = new Philippines(cont, lang, hero);
            }

            foreach (Country country in countries)
            {
                country.DisplayCountriesInfo();
            }

           
            Console.ReadKey();
        }

    }
    
}
