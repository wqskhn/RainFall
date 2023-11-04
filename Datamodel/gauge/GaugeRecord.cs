using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using RainFallUI.Datamodel.data;

namespace RainFallUI.Datamodel.gauge
{
    public class GaugeRecord
    {
        [Name("Device ID")]
        public int DeviceID { get ; set ; }
        [Name("Device Name")]
        public string DeviceName { get; set; }
        [Name("Location")]
        public string Location { get ; set; }
    }

    //this could also be done through annotation over the properties in the GaugeRecord Class
    sealed class GaugeRecordMap : ClassMap<GaugeRecord>
    {
        public GaugeRecordMap()
        {
            Map(m => m.DeviceID).Name("Device ID");
            Map(m => m.DeviceName).Name("Device Name");
            Map(m => m.Location).Name("Location");
        }
    }
}