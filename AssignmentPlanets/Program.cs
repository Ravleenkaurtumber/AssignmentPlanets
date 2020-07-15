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
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139820, 1.89813e27);
            Jupiter.ToString();
        }
          
    }
}
