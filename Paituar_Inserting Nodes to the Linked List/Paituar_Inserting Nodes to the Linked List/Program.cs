using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_Inserting_Nodes_to_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Problem:ACTIVITY 6: Inserting Nodes to the Linked List

            //Declare a linkList
            LinkedList<string> classmates = new LinkedList<string>();
            int numberOfClassmates = 0;

            //Get the number of classmates (5-10)
            Console.Write("Enter no. of classmates (5-10 names only)? ");
            numberOfClassmates = int.Parse(Console.ReadLine());

            // Use IF-ELSE to check the range
            if (numberOfClassmates < 5 || numberOfClassmates > 10)
            {
              Console.WriteLine("Error: You can only enter between 5 and 10 names.");
                // Stops the program if the input is invalid
                return; 
            }
            else
            {
              Console.WriteLine("Great! Please enter "+ numberOfClassmates+" names.");
            }

           // Use a for loop to collect the names
           for (int i = 1; i <= numberOfClassmates; i++)
           {
              Console.Write("Enter name " + i+": " );
                string name = Console.ReadLine();
                // Adding to the LinkedList
                classmates.AddLast(name);
           }

            // Display the results
            Console.WriteLine("\n--- Classmate List ---");

           // Display using a loop
           foreach (string name in classmates)
           {
             Console.Write(name+"\t");
             
            }
            Console.ReadKey();
            
        }
    }
}
    
