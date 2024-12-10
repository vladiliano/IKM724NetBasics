using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Enums;
using System.Xml.Linq;

public class GasRegulatorSensor : Sensor
{
    public override SensorType Type => SensorType.PipePressure;

    public GasRegulatorSensor(string name, string description)
        : base(name, description) { }

    public override void ReadValue()
    {
        Value = new Random().NextDouble() * 10; // Давление газа в барах
        Console.WriteLine($"{Name} Gas Regulator Pressure: {Value} bar");
    }
}
