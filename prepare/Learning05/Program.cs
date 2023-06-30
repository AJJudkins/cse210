using System;

class Program
{
    static void Main(string[] args)
    {
        var square = new Square(4, "Green");
        square.getColor();
        double answer1 = square.getArea();
        Console.WriteLine(answer1);

        var rectangle = new Rectangle(4, 5, "Blue");
        rectangle.getColor();
        double answer2 = rectangle.getArea();
        Console.WriteLine(answer2);
    }
}