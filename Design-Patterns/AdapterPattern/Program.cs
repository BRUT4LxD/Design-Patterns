using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hole hole = new Hole(10);
            RoundThing roundThing = new RoundThing { Radius = 8 };
            SquareThing squareThing = new SquareThing(10);

            hole.Fits(roundThing);
            hole.Fits(new SquareThingAdapter(squareThing));

            Console.ReadKey();
        }
    }

    internal class SquareThingAdapter : RoundThing
    {
        private readonly SquareThing _squareThing;

        public SquareThingAdapter(SquareThing squareThing)
        {
            _squareThing = squareThing;
        }
    }

    internal class SquareThing
    {
        public SquareThing(int i)
        {
            throw new NotImplementedException();
        }
    }

    internal class RoundThing
    {
        public int Radius { get; set; }

    }

    internal class Hole
    {
        private readonly int _radius;

        public Hole(int radius)
        {
            _radius = radius;
        }

        public void Fits(RoundThing roundThing)
        {
            Console.WriteLine(_radius > roundThing.Radius ? "It FITS!!" : "It does not fit!");
        }
    }
}
