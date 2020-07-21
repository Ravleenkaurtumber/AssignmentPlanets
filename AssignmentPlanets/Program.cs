using System;

namespace AssignmentPlanets
{
    class Program
    /*Name:Ravleen kaur
     student number:301101894
    last time modified at 12:20 am 21 july*/
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
            //CREATING THE OBJECT OF CLASS TERRESTRIALPANET
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth",12742, 5.97E27,true);
            Console.WriteLine(Earth.ToString());
        }
       

    }
}
