using System.Collections.Generic;

namespace BuilderPattern
{
    public class ClubSandwichBuilder: SandwichBuilder
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
            Sandwich.MeatType = MeatType.Salami;
            Sandwich.CheesType = CheesType.Swiss;
        }

        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.Wheat;
            Sandwich.IsToasted = false;
        }
    }
}
