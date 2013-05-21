using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitorGrid
{
    class Sensor
    {
        public Sensor() { }

        public double LowThreshold { get; set; }
        public double HiThreshold { get; set; }
        public double CurrentTemperature { get; set; }
        public string Location { get; set; }
    }
}
