using IKM724NetBasics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class TemperatureSensor : Sensor
    {
        public override SensorType Type => SensorType.Temperature;
        public TemperatureSensor(string name, string description)
            : base(name, description) { }
        
        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 50;
            Console.WriteLine($"{Name} Temperature: {Value} C");
        }
    }
}