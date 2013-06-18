using System.Collections.Generic;

namespace BuilderPattern
{
    public class MySandwichBuilder : SandwichBuilder
    {
        //private Sandwich sandwich;
        //public Sandwich GetSandwich()
        //{
        //    return sandwich;
        //}

        //public void CreateSandwich()
        //{
        //    sandwich = new Sandwich();
        //    PrepareBread();
        //    ApplyMeatAndCheese();
        //    ApplyVegetables();
        //    AddCondiments();
        //}

        public override void AddCondiments()
        {
            Sandwich.HasMayo = false;
            Sandwich.HasMustard = false;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.MeatType = MeatType.Turkey;
            Sandwich.CheesType = CheesType.American;
        }

        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.Wheat;
            Sandwich.IsToasted = false;
        }
    }
}
