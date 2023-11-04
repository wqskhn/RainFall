using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace RainFallUI.Datamodel.Display
{
    public class DisplayResult
    {

        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceLocation { get; set; }
        public double Average { get; set; }

    }
}
