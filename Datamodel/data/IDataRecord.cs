using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallUI.Datamodel.data
{
    public interface IDataRecord
    {
        public int DeviceID { get; set; }
        public DateTime Time { get; set; }
        public double RainFall { get; set; }
    }
}
