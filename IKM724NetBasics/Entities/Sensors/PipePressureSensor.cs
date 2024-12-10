using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class PipePressureSensor : Sensor
    {
        public override SensorType Type => SensorType.PipePressure;

        public PipePressureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 10; // Давление в барах
            Console.WriteLine($"{Name} Pipe Pressure: {Value} bar");
        }
    }
}
