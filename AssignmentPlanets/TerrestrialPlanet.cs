using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPlanets
{
    class TerrestrialPlanet:Planet,IHasMoons,IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool m_oxygen;
        //PUBLIC PROPERTIES
        //CONSTRUCTOR(S)
        public TerrestrialPlanet(string name, double diameter, double mass,bool oxygen)
            :base(name,diameter,mass)
        {
            m_oxygen = oxygen; 
        }

        

        //PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Habitable()
        {
            if(m_oxygen==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //PRIVATE METHODS
    }
}
