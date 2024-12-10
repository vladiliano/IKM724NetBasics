using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Enums;
using System.Xml.Linq;

public class LiquidCollectorSensor : Sensor
{
    public override SensorType Type => SensorType.TankLevel;

    public LiquidCollectorSensor(string name, string description)
        : base(name, description) { }

    public override void ReadValue()
    {
        Value = new Random().NextDouble() * 100; // Уровень жидкости в процентах
        Console.WriteLine($"{Name} Liquid Collector Level: {Value}%");
    }
}