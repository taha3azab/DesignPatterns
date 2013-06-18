using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheesType CheesType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            if (IsToasted)
                Console.WriteLine("Toasted");
            if (HasMayo)
                Console.WriteLine("With Mayo");
            if (HasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", MeatType);
            Console.WriteLine("Chees: {0}", CheesType);
            Console.WriteLine("Veggies: ");
            foreach (var vegetable in Vegetables)
            {
                Console.WriteLine("   {0}", vegetable);
            }
        }

    }


    public class Sandwich1
    {
        private readonly BreadType breadType;
        private readonly bool isToasted;
        private readonly CheesType cheesType;
        private readonly MeatType meatType;
        private readonly bool hasMustard;
        private readonly bool hasMayo;
        private readonly List<string> vegetables;

        public Sandwich1(BreadType breadType, bool isToasted, CheesType cheesType, MeatType meatType, bool hasMustard, bool hasMayo, List<string> vegetables)
        {
            this.breadType = breadType;
            this.isToasted = isToasted;
            this.cheesType = cheesType;
            this.meatType = meatType;
            this.hasMustard = hasMustard;
            this.hasMayo = hasMayo;
            this.vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", breadType);
            if (isToasted)
                Console.WriteLine("Toasted");
            if (hasMayo)
                Console.WriteLine("With Mayo");
            if (hasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", meatType);
            Console.WriteLine("Chees: {0}", cheesType);
            Console.WriteLine("Veggies: ");
            foreach (var vegetable in vegetables)
            {
                Console.WriteLine("   {0}", vegetable);
            }
        }

    }



    public enum MeatType
    {
        Turkey,
        Chicken,
        Salami
    }

    public enum CheesType
    {
        American,
        Swiss,
        Cheddar,
        Provolone
    }

    public enum BreadType
    {
        White,
        Wheat
    }
}
