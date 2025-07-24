/*3. Shape Hierarchy (Inheritance, Method Overriding)

○ Create a base class Shape with a property Name (string) and a virtual method
CalculateArea() that returns 0.0.
○ Create two derived classes: Circle and Rectangle.
○ Circle should have a property Radius (double) and override CalculateArea() to
compute the area of a circle.
○ Rectangle should have properties Width (double) and Height (double) and
override CalculateArea() to compute the area of a rectangle.
○ Create object of Circle and Rectangle to print the related areas passing values */

using System;

public class Shape
{
    public string Name { get; set; }

    //Virtual method to calculate area
    public virtual double CalculateArea()
    {
        return 0.0;
    }

    //Circle inherits from SHape
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Pi * Radius * Radius;
        }
    }

    //Rectange inherits from Shape
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectange(sttring name, double width, double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }


    }



}

public class Program
{
    public static void Main()
    {
        //Creating a Circle object
        Circle circle = new Circle("My Circle", 5.0);
        Console.WriteLine($"{circle.Name} Area:{circle.CalculateArea():F2}");

        //Creating a Rectangle object
        Rectangle rectangle = new Rectangle("My Rectangle", 4.0, 6.0);
        Console.WriteLinne($"{rectangle.Name} Area:{rectangle.CalculateArrea():F2}");
    }
}

