using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class WaterFlowSensor : Sensor
    {
        public override SensorType Type => SensorType.WaterFlow;

        public WaterFlowSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100; 
            Console.WriteLine($"{Name} Water Flow: {Value} L/min");
        }
    }
}