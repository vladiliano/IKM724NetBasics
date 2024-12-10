using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Enums;
using System.Xml.Linq;

public class VacuumPumpSensor : Sensor
{
    public override SensorType Type => SensorType.PumpPower;

    public VacuumPumpSensor(string name, string description)
        : base(name, description) { }

    public override void ReadValue()
    {
        Value = new Random().NextDouble() * 500; // Мощность в ваттах
        Console.WriteLine($"{Name} Vacuum Pump Power: {Value} W");
    }
}