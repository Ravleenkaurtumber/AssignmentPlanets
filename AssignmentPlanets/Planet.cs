﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPlanets
{
    class Planet
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private double m_diameter;
        private double m_mass;
        private int m_moonCount;
        private string m_name;
        private double m_orbitalPeriod;
        private int m_ringCount;
        private double m_rotationPeriod;
        //PUBLIC PROPERTIES
        public double Diameter 
        { 
            get
            {
                return m_diameter;
            }
                
        }
        public double Mass
        {
            get
            {
                return m_mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return m_moonCount;
            }
            set
            {
                m_moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return m_name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return m_orbitalPeriod;
            }
            set
            {
                m_orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return m_ringCount;
            }
            set
            {
                m_ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return m_rotationPeriod;
            }
            set
            {
                m_rotationPeriod = value;
            }
        }

        //CONSTRUCTOR(S)
        //PRIVATE METHODS
        //PUBLIC METHODS
    }
}
