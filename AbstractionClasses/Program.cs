using System;

namespace AbstractionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura();
            Square square = new Square(10.0);
            Circle circle = new Circle(5.0);

            Console.WriteLine("SQUARE: ");
            Console.WriteLine(square.ObliczPole());
            Console.WriteLine(square.ObliczObwod());

            Console.WriteLine("CIRCLE: ");
            Console.WriteLine(circle.ObliczPole());
            Console.WriteLine(circle.ObliczObwod());
        }
    }
}