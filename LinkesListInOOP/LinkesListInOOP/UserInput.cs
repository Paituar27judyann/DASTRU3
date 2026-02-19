using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkesListInOOP
{
    class UserInput
    {
        public static string GetString(string prompt)
        {
            //Exception if you left the user input empty
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        throw new Exception("Input cannot be empty.");
                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Input Error: {ex.Message}");
                }
            }
        }
        //Exception if you input invalid number for example the choices are only 4 and you enter number that is greater than 4
        public static int GetInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input Error: Please enter a valid number.");
                }
            }
        }
    }
}
