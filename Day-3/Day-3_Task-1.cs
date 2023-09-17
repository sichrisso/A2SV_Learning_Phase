using System;

class Shape
{
    public string Name { get; set; }

    public virtual double CalculateArea()
    {
        return 0; 
    }
}

// Circle class derived from Shape
class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius; // Area of a circle
    }
}

// Rectangle class derived from Shape
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height; // Area of a rectangle
    }
}

// Triangle class derived from Shape
class Triangle : Shape
{
    public double Base { get; set; }
    public double TriangleHeight { get; set; }

    public override double CalculateArea()
    {
        return (Base * TriangleHeight) / 2; // Area of a triangle
    }
}

class Program
{
    // Method to print shape's name and area using polymorphism
    static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"Shape: {shape.Name}");
        Console.WriteLine($"Area: {shape.CalculateArea()}\n");
    }

    static void Main()
    {
        // Create instances of Circle, Rectangle, and Triangle
        Circle circle = new Circle { Name = "Circle", Radius = 5.0 };
        Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 4.0, Height = 6.0 };
        Triangle triangle = new Triangle { Name = "Triangle", Base = 8.0, TriangleHeight = 4.0 };

        // Use the PrintShapeArea method to display the name and area of each shape
        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
    }
}
