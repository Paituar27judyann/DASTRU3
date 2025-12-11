using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_Review2.Shape;

namespace OOP_Review2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle object
            Circle circle = new Circle();
            circle.Color = "Red";
            circle.Radius = 20;

            Console.WriteLine("Shape: Circle");
            Console.WriteLine("Shapes color: "+ circle.Color );
            Console.WriteLine("Radius: " + circle.Radius );
            Console.WriteLine("GetArea: " + circle.GetArea().ToString("F2"));

          

            // Rectangle object
            Rectangle rect = new Rectangle();
            rect.Color = "Blue";
            rect.Width = 20;
            rect.Height = 10;


            Console.WriteLine("\nShape: Rectangle");
            Console.WriteLine("Shape color: " + rect.Color );
            Console.WriteLine("Dimention: " + rect.Width + " x " + rect.Height );
            Console.WriteLine("Area: " + rect.GetArea().ToString("F2") );

            Console.ReadKey();
        }
    }
}
