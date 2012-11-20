using System;

namespace AdapterPattern
{
    // Two-Way Adapter Pattern Pierre-Henri Kuate and Judith Bishop Aug 2007
    // Embedded system for a Seabird flying plane
    
    // ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
    }

    // Target
    public sealed class Aircraft : IAircraft
    {
        public Aircraft()
        {
            Height = 0;
            Airborne = false;
        }
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            Airborne = true;
            Height = 200; // Meters
        }

        public bool Airborne { get; private set; }

        public int Height { get; private set; }
    }

    // Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
    }
   
    // Adaptee implementation
    public class Seacraft : ISeacraft
    {
        public Seacraft()
        {
            Speed = 0;
        }

        public virtual void IncreaseRevs()
        {
            Speed += 10;
            Console.WriteLine("Seacraft engine increases revs to " + Speed + " knots");
        }

        public int Speed { get; private set; }
    }

    // Adapter
    public class Seabird : Seacraft, IAircraft
    {
        public Seabird()
        {
            Height = 0;
        }

        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
                IncreaseRevs();
        }

        // Routes this straight back to the Aircraft
        public int Height { get; private set; }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > 40)
                Height += 100;
        }

        public bool Airborne
        {
            get { return Height > 50; }
        }
    }


    internal class ExperimentMakeSeaBirdFly
    {
        private static void Main2()
        {
            // No adapter
            Console.WriteLine("Experiment 1: test the aircraft engine");
            IAircraft aircraft = new Aircraft();
            aircraft.TakeOff();
            if (aircraft.Airborne)
                Console.WriteLine("The aircraft engine is fine, flying at {0}meters", aircraft.Height);

            // Classic usage of an adapter
            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
            IAircraft seabird = new Seabird();
            seabird.TakeOff(); // And automatically increases speed
            Console.WriteLine("The Seabird took off");

            // Two-way adapter: using seacraft instructions on an IAircraft object
            // (where they are not in the IAircraft interface)
            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
            (seabird as ISeacraft).IncreaseRevs();
            (seabird as ISeacraft).IncreaseRevs();
            if (seabird.Airborne)
                Console.WriteLine("Seabird flying at height {0} meters and speed {1} knots", seabird.Height, (seabird as ISeacraft).Speed);
            
            Console.WriteLine("Experiments successful; the Seabird flies!");
        }
    }
}
