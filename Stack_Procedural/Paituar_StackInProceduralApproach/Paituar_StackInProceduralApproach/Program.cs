using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_StackInProceduralApproach
{
    internal class Program
    {
        // Global stack list to be accessed by procedural methods
        static List<int> stack = new List<int>();
        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("--- Procedural Stack Manager ---");

            while (running)
            {
                Console.WriteLine("\n\t-------Choose an option------ \n\t[1] Push \n\t[2] Pop \n\t[3] Peek \n\t[4] Display \n\t[5] Exit");
                Console.Write("\nEnter Choice: ");


               string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        PushOperation();
                        break;
                    case "2":
                        PopOperation();
                        break;
                    case "3":
                        PeekOperation();
                        break;
                    case "4":
                        DisplayStack();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
           
        }

        static void PushOperation()
        {
            try
            {
                Console.Write("Enter an integer to push: ");
                int value = int.Parse(Console.ReadLine());
                stack.Add(value);
                Console.WriteLine (value + (" added to the stack."));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }

        static void PopOperation()
        {
            try
            {
                if (stack.Count == 0)
                    throw new InvalidOperationException("Stack Underflow: Cannot pop from an empty stack.");

                int lastIndex = stack.Count - 1;
                int removedValue = stack[lastIndex];
                stack.RemoveAt(lastIndex);
                Console.WriteLine($"Popped value: {removedValue}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PeekOperation()
        {
            if (stack.Count > 0)
            {
                Console.WriteLine($"Top element is: {stack[stack.Count - 1]}");
            }
            else
            {
                Console.WriteLine("The stack is empty.");
            }
        }

        static void DisplayStack()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is currently empty.");
                return;
            }

            Console.WriteLine("Current Stack (Top to Bottom):");
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"| {stack[i]} |");
            }
           
        }
    }
    
}
