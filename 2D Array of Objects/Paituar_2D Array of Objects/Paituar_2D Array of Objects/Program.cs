using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_2D_Array_of_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituat
            //Problem: ACTIVITY 4:  2D Array of Objects

            // Asking for dimensions for the 2D Array
            Console.Write("Enter how many groups of countries: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter how many countries per group: ");
            int cols = int.Parse(Console.ReadLine());

            // Declaring the 2D Array of objects
            Country[,] countries = new Country[rows, cols];

            // Outer loop for Rows (Groups)
            for (int i = 0; i < rows; i++)
            {
                // Inner loop for Columns (Individual Countries)
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("\nFilling Group " + (i + 1) + ", Slot " + (j + 1) + ":");

                    Console.Write("Continent: ");
                    string cont = Console.ReadLine();

                    Console.Write("Language: ");
                    string lang = Console.ReadLine();

                    Console.Write("Known Figure in the Country: ");
                    string hero = Console.ReadLine();

                    // Storing object in 2D space
                    countries[i, j] = new Philippines(cont, lang, hero);
                }
            }
            Console.WriteLine("\n\t\t\t--- Countries Information ---");
            Console.WriteLine("\n\tContinent " + "\tLanguage " + "\tKnown Figure");

            // Accessing the 2D array using nested loops
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    countries[i, j].DisplayCountriesInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
