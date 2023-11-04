using RainFallUI.parser.csv;
using RainFallUI.service.average;

namespace RainFall
{
    public partial class RainFall : Form
    {
        public RainFall()
        {
            InitializeComponent();
        }

        private void buttonDevice_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textDeviceFilePath.Text = ofd.FileName;
            }

        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textDataFilePath.Text = ofd.FileName;
            }
        }

        private void buttonCalAvgRainFall_Click(object sender, EventArgs e)
        {
            if (textDataFilePath.Text == "" || textDeviceFilePath.Text == "")
            {
                MessageBox.Show("Select Both Files");
                return;
            }

            var parse = new CSVParser();
            // Validate needed before passing to Parse or change parser to Generic 
            parse.ParseCSV(textDeviceFilePath.Text, textDataFilePath.Text);
            var datarecords = parse.DataRecords;
            var guageRecords = parse.GaugeRecords;
            var calculationAvg = new RainFallFourHrs();
            var result = calculationAvg.FourHrsAverageCalculation(datarecords);

            //check for color
            // display to screen 
          
        }
    }
}