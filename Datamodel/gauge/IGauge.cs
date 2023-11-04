using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallUI.Datamodel.gauge
{
    public interface IGauge
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string Location { get; set; }
    }
}
