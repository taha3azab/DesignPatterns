using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Showing the Adapteee in standalone mode
            Adaptee first = new Adaptee();
            Console.Write("Before the new standard\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5, 3));

            // What the client really wants
            ITarget second = new Adapter();
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));


            Console.Read();
        }
    }

    public interface ITarget
    {
        string Request(int i);
    }

    public class Adaptee
    {
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }

    public class Adapter : Adaptee, ITarget
    {
        public string Request(int i)
        {
            return "Rough estimate is " + (int)Math.Round(SpecificRequest(i, 3));
        }
    }
}
