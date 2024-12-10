using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class TankLevelSensor : Sensor
    {
        public override SensorType Type => SensorType.TankLevel;

        public TankLevelSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100; // Уровень жидкости в процентах
            Console.WriteLine($"{Name} Tank Level: {Value}%");
        }
    }
}