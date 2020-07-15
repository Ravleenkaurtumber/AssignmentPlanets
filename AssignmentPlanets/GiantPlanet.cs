using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPlanets
{
    class GiantPlanet:Planet,IHasMoons,IHasRings
    {

        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private string m_type;

        

        //PUBLIC PROPERTIES

        //CONSTRUCTOR(S)
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            m_type = type;
        }
        //PUBLIC METHODS
        public  bool HasMoons()
        {
        if(MoonCount>0)
            {
                return true;
            }
            else
            {
            return false;
            }
        }
        public bool HasRings()
        {
            if(RingCount>0)
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
