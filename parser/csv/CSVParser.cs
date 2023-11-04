using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using RainFallUI.Datamodel.data;
using RainFallUI.Datamodel.gauge;

namespace RainFallUI.parser.csv
{
    public class CSVParser
    {
        private List<DataRecord> dataRecords = new();

        internal List<DataRecord> DataRecords { get => dataRecords; set => dataRecords = value; }

        private List<GaugeRecord> gaugeRecords = new();

        internal List<GaugeRecord> GaugeRecords { get => gaugeRecords; set => gaugeRecords = value; }
        public void ParseCSV(string deviceFilePath, string dataFilePath) //csv file would be passed through arg
        {

            ////This  Device Records
            using (var reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), deviceFilePath)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {


                csv.Context.RegisterClassMap<GaugeRecordMap>();
                var isHeader = true;
                while (csv.Read())
                {
                    if (isHeader)
                    {
                        csv.ReadHeader();
                        isHeader = false;
                        continue;
                    }
                    else
                    {
                        gaugeRecords.Add(item: csv.GetRecord<GaugeRecord>()!);
                    }
                }

            }

            using (var reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), dataFilePath)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //This could be replace with config file Header set to false don't need the below logic


                csv.Context.RegisterClassMap<DataRecordMap>();

                var isHeader = true;
                while (csv.Read())
               {
                  if (isHeader)
                  {
                      csv.ReadHeader();
                      isHeader = false;
                       continue;
                   }
                   else
                   {
                       dataRecords.Add(item: csv.GetRecord<DataRecord>()!);
                   }
               }

           }
        }
    }
}