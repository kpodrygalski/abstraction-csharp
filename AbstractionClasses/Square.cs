using System;
namespace AbstractionClasses
{
    public class Square : Figura
    {
        public double BokA { get; set; }

        public Square(double bokA) : base()
        {
            BokA = bokA;
        }

        public override double ObliczPole()
        {
            return Math.Pow(BokA, 2);
        }

        public override double ObliczObwod()
        {
            return 4 * BokA;
        }
    }
}
