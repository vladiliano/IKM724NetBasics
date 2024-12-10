using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class GreenHouse
    {
        public List<Sensor> Sensors { get; set; }
        public IrrigationSystem Irrigation { get; set; }
        public LightingSystem Lighting { get; set; }
        public VentilationSystem Ventilation { get; set; }

        public GreenHouse()
        {
            Sensors = new List<Sensor>();
            Irrigation = new IrrigationSystem();
            Lighting = new LightingSystem();
            Ventilation = new VentilationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue(); 
            }
        }
    }
}