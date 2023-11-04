using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RainFallUI.Datamodel.data
{
    public class DataRecord
    {
        [Name("Device ID")]
        public int DeviceID { get ; set ; }
        [Name("Time")]
        public DateTime Time { get ; set ; }
        [Name("Rainfall")]
        public double RainFall { get ; set ; }
    }

    sealed class DataRecordMap : ClassMap<DataRecord>
    {
        public DataRecordMap()
        {
            Map(m => m.DeviceID).Name("Device ID");
            Map(m => m.Time).Name("Time");
            Map(m => m.RainFall).Name("Rainfall");
        }
    }
}
