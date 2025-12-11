using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review2
{
    public class Shape
    {
        //Base Class
        public class shape
        {
            public string Color { get; set; }
            public virtual double GetArea()
            { return 0.0; }
            
        }
        //Derived Class
        public class Circle : shape
        {
            public double Radius { get; set; }
            public override double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
        //Drived class
        public class Rectangle : shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea()
            {
                return Height * Width;
            }
        }
    }
}
