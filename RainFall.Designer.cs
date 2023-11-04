namespace RainFall
{
    partial class RainFall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDevice = new Button();
            buttonData = new Button();
            textDeviceFilePath = new TextBox();
            textDataFilePath = new TextBox();
            buttonCalAvgRainFall = new Button();
            SuspendLayout();
            // 
            // buttonDevice
            // 
            buttonDevice.Location = new Point(447, 42);
            buttonDevice.Name = "buttonDevice";
            buttonDevice.Size = new Size(233, 34);
            buttonDevice.TabIndex = 0;
            buttonDevice.Text = "Select Device csv File";
            buttonDevice.UseVisualStyleBackColor = true;
            buttonDevice.Click += buttonDevice_Click;
            // 
            // buttonData
            // 
            buttonData.Location = new Point(447, 93);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(233, 34);
            buttonData.TabIndex = 1;
            buttonData.Text = "Select Data csv File";
            buttonData.UseVisualStyleBackColor = true;
            buttonData.Click += buttonData_Click;
            // 
            // textDeviceFilePath
            // 
            textDeviceFilePath.Location = new Point(35, 45);
            textDeviceFilePath.Name = "textDeviceFilePath";
            textDeviceFilePath.Size = new Size(406, 31);
            textDeviceFilePath.TabIndex = 2;
            // 
            // textDataFilePath
            // 
            textDataFilePath.Location = new Point(34, 94);
            textDataFilePath.Name = "textDataFilePath";
            textDataFilePath.Size = new Size(407, 31);
            textDataFilePath.TabIndex = 3;
            // 
            // buttonCalAvgRainFall
            // 
            buttonCalAvgRainFall.Location = new Point(208, 162);
            buttonCalAvgRainFall.Name = "buttonCalAvgRainFall";
            buttonCalAvgRainFall.Size = new Size(320, 34);
            buttonCalAvgRainFall.TabIndex = 4;
            buttonCalAvgRainFall.Text = "Calculate Average RainFall";
            buttonCalAvgRainFall.UseVisualStyleBackColor = true;
            buttonCalAvgRainFall.Click += buttonCalAvgRainFall_Click;
            // 
            // RainFall
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalAvgRainFall);
            Controls.Add(textDataFilePath);
            Controls.Add(textDeviceFilePath);
            Controls.Add(buttonData);
            Controls.Add(buttonDevice);
            Name = "RainFall";
            Text = "Average RainFall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDevice;
        private Button buttonData;
        private TextBox textDeviceFilePath;
        private TextBox textDataFilePath;
        private Button buttonCalAvgRainFall;
    }
}