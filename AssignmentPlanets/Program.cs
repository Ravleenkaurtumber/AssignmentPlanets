using System;

namespace AssignmentPlanets
{
    class Program
    {
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // CREATING THE OBJECT OF CLASS GIANTPLANET
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139820, 1.89813e2,"gas");
            Console.WriteLine(Jupiter.ToString());
            //CREATING THE OBJECT OF CLASS TERRESTRIAL
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth",12742, 5.97E27,true);
            Console.WriteLine(Earth.ToString());
        }
        
    }
}
