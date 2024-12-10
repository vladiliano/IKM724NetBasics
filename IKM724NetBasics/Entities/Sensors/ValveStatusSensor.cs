using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class ValveStatusSensor : Sensor
    {
        public override SensorType Type => SensorType.ValveStatus;

        public ValveStatusSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().Next(0, 2); // 0 - закрыт, 1 - открыт
            string status = Value == 1 ? "Open" : "Closed";
            Console.WriteLine($"{Name} Valve Status: {status}");
        }
    }
}