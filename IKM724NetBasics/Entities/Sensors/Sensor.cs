﻿using IKM724NetBasics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public abstract class Sensor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; protected set; }
        public abstract SensorType Type { get; }
        public Sensor(string name, string description) 
        {
            Name = name;
            Description = description;
        }

        public abstract void ReadValue();
    }
}