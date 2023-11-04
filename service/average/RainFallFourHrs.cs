using RainFallUI.Datamodel.Average;
using RainFallUI.Datamodel.data;

namespace RainFallUI.service.average
{
    public class RainFallFourHrs
    {
        public dynamic FourHrsAverageCalculation(List<DataRecord> rainfalls)
        {
            var result = from avgRain in rainfalls
                         group avgRain by avgRain.DeviceID into avgRainData
                         select new
                         {
                             Id = avgRainData.Key,
                             AverageScore = avgRainData.Average(row => row.RainFall)
                         };

            return result.ToList();
        }

    }
}