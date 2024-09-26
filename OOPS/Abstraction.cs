using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Shape
    {
        // Abstract method (must be overridden in derived class)
        public abstract double Area();
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementing the abstract method
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing the abstract method
        public override double Area()
        {
            return Width * Height;
        }
    }

    class Abstraction
    {
        static void Main()
        {
            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("Circle Area: " + circle.Area());       // Output: Circle Area: 78.53981633974483
            Console.WriteLine("Rectangle Area: " + rectangle.Area()); // Output: Rectangle Area: 24
        }
    }
}
