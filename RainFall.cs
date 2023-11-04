using RainFallUI.parser.csv;

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

            var a =  new CSVParser();
            // Validate needed before passing to Parse or change parser to Generic 
            a.ParseCSV( textDeviceFilePath.Text, textDataFilePath.Text);
            var datarecords = a.DataRecords;
            var guageRecords = a.GaugeRecords;


        }
    }
}