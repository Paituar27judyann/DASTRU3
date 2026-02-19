using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkesListInOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryManager manager = new CountryManager();
            bool running = true;

            while (running)
            {
                
                Console.WriteLine("\n--- COUNTRY MANAGEMENT SYSTEM ---");
                Console.WriteLine("1. Add New Entry");
                Console.WriteLine("2. Remove Entry (by Language)");
                Console.WriteLine("3. Display All Entries");
                Console.WriteLine("4. Exit");

                int choice = UserInput.GetInt("Choose an option: ");
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        string sport = UserInput.GetString("Enter Continent: ");
                        string lang = UserInput.GetString("Enter Language: ");
                        string fig = UserInput.GetString("Enter Known Figure: ");
                        manager.Insert(new Asia(sport, lang, fig));
                        break;
                    case 2:
                        string target = UserInput.GetString("Enter Language to delete: ");
                        manager.Remove(target);
                        break;
                    case 3:
                        manager.DisplayAll();
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
            }
        }
    }
}
    

