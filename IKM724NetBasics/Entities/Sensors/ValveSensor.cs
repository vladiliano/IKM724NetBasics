using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Enums;
using System.Xml.Linq;

public class ValveSensor : Sensor
{
    public override SensorType Type => SensorType.ValveStatus;

    public ValveSensor(string name, string description)
        : base(name, description) { }

    public override void ReadValue()
    {
        Value = new Random().Next(0, 2); // 0 - закрыт, 1 - открыт
        string status = Value == 1 ? "Open" : "Closed";
        Console.WriteLine($"{Name} Valve Status: {status}");
    }
}
