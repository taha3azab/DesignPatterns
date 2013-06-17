using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new Sandwich(BreadType.Wheat, false, CheesType.American, MeatType.Turkey, false, false,
                         new List<string> {"Tomato"}).Display();


            Console.ReadKey();
        }
    }
}
