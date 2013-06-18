using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Sandwich1(BreadType.Wheat, false, CheesType.American, MeatType.Turkey, false, false,
            //             new List<string> {"Tomato"}).Display();

            //var sandwich = new Sandwich();
            //sandwich.BreadType= BreadType.Wheat;
            //sandwich.MeatType= MeatType.Turkey;
            //sandwich.CheesType=CheesType.American;
            //sandwich.HasMayo = false;
            //sandwich.HasMustard = false;
            //sandwich.HasMustard = true;
            //sandwich.Vegetables = new List<string> {"Tomato", "Onion"};
            //sandwich.Display();

            //var builder = new MySandwichBuilder();
            //builder.CreateSandwich();
            //var sandwich = builder.GetSandwich();
            //sandwich.Display();

            var maker = new SandwichMaker(new MySandwichBuilder());
            maker.BuildSandwich();
            var sandwich = maker.GetSandwich();
            sandwich.Display();

            var maker2 = new SandwichMaker(new ClubSandwichBuilder());
            maker2.BuildSandwich();
            var sandwich2 = maker2.GetSandwich();
            sandwich2.Display();


            Console.ReadKey();
        }
    }
}
