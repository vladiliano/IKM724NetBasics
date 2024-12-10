using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class PumpPowerSensor : Sensor
    {
        public override SensorType Type => SensorType.PumpPower;

        public PumpPowerSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 500; 
            Console.WriteLine($"{Name} Pump Power: {Value} W");
        }
    }
}