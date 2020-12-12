using System;
namespace AbstractionClasses
{
    public class Circle : Figura
    {
        public double R { get; set; }

        public Circle(double r) : base()
        {
            R = r;
        }

        public override double ObliczPole()
        {
            return Math.Round(Math.PI * Math.Pow(R, 2), 2);
        }

        public override double ObliczObwod()
        {
            return Math.Round(2 * Math.PI * R, 2);
        }
    }
}
