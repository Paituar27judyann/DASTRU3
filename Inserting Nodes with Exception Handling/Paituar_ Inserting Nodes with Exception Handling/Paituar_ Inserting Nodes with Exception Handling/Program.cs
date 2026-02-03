using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar__Inserting_Nodes_with_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Problem:ACTIVITY 7:  Inserting Nodes with Exception Handling

            LinkedList<string> classmates = new LinkedList<string>();
            int numberOfClassmates = 0;

            // Loop until valid input is received
            while (true)
            {
                try
                {
                    Console.Write("\nEnter no. of classmates (5-10 names only): ");
                    numberOfClassmates = int.Parse(Console.ReadLine());

                    if (numberOfClassmates >= 5 && numberOfClassmates <= 10)
                    {
                        // Input is valid, exit the loop
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a number between 5 and 10.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! That's not a number. Please try again.");
                }
            }

            Console.WriteLine("Great! Please enter " + numberOfClassmates + " names.");

            // Collect names
            for (int i = 1; i <= numberOfClassmates; i++)
            {
                Console.Write("Enter name " + i + ": ");
                string name = Console.ReadLine();
                classmates.AddLast(name);
            }

            // Original List
            Console.WriteLine("\n--- Classmate List ---");
            foreach (string name in classmates)
            {
                Console.Write(name + "\t");
            }

            // Sorting via Array
            string[] sortedNames = classmates.ToArray();
            Array.Sort(sortedNames);

            // Display Sorted
            Console.WriteLine("\n\n--- Sorted Classmate List ---");
            foreach (string name in sortedNames)
            {
                Console.Write(name + "\t");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
    

