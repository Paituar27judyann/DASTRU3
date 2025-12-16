using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Problem:ACTIVITY 1 Single Dimensional Array in Procedural Programming

            //declare an array 
            string[] countries = new string[5];
            
            //Use loop to get user input
            for(int asia =0; asia < countries.Length; asia++)
            {
                Console.Write("Enter Country in Asia: ", asia + 1);
                countries[asia] = Console.ReadLine();
            }
            //sorting your output alphabetically
            Array.Sort(countries);
            Console.WriteLine("\nThe Countries in Asia that you entered are:");

            //Display Input
            foreach(string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.ReadKey();
        }
    }
}
