using System;

namespace AdapterPattern
{
    // Adapter Pattern - Pluggable Judith Bishop Oct 2007
    // Adapter can accept any number of pluggable adaptees and targets
    // and route the requests via a delegate, in some cases using the
    // anonymous delegate construct

    // Existing way requests are implemented
    internal class Adaptee2
    {
        public double Precise(double a, double b)
        {
            return a/b;
        }
    }

    // New standard for requests
    internal class Target
    {
        public string Estimate(int i)
        {
            return "Estimate is " + (int) Math.Round(i/3.0);
        }
    }

    // Implementing new requests via old
    internal class Adapter2 : Adaptee2
    {
        public Func<int, string> Request;

        // Different constructors for the expected targets/adaptees

        // Adapter-Adaptee
        public Adapter2(Adaptee2 adaptee)
        {
            // Set the delegate to the new standard
            Request = i => string.Format("Estimate based on precision is {0}", (int) Math.Round(Precise(i, 3)));
        }

        // Adapter-Target
        public Adapter2(Target target)
        {
            // Set the delegate to the existing standard
            Request = target.Estimate;
        }
    }

    internal class Client
    {
/*
        private static void Main()
        {

            Adapter2 adapter1 = new Adapter2(new Adaptee2());
            Console.WriteLine(adapter1.Request(5));

            Adapter2 adapter2 = new Adapter2(new Target());
            Console.WriteLine(adapter2.Request(5));

        }
*/
    }
}
