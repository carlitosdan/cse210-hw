using System;


class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(12, "red");
        Console.WriteLine($"Area Square: {square1.GetArea()}");
        Console.WriteLine($"Color Square: {square1.GetColor()}\n");

        Rectangle rectangle1 = new Rectangle(8.5, 10.5, "green");
        Console.WriteLine($"Area rectangle: {rectangle1.GetArea()}");
        Console.WriteLine($"Color rectangle: {rectangle1.GetColor()}\n");

        Circle circle1 = new Circle(10.4, "Black");
        Console.WriteLine($"Area Circle: {circle1.GetArea()}");
        Console.WriteLine($"Color circle: {circle1.GetColor()}\n");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Color: {color} and Area: {area}.\n");   
        }



    }
}