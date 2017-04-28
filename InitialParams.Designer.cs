using System.Windows.Forms;

namespace California_Instruments_CSW5550_Software
{
    partial class InitialParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.VoltageScroll = new System.Windows.Forms.HScrollBar();
            this.FrequencyScroll = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltageScroll
            // 
            this.VoltageScroll.Location = new System.Drawing.Point(7, 42);
            this.VoltageScroll.Maximum = 300;
            this.VoltageScroll.Name = "VoltageScroll";
            this.VoltageScroll.Size = new System.Drawing.Size(128, 23);
            this.VoltageScroll.TabIndex = 0;
            this.VoltageScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VoltageScroll_ValueChanged);
            // 
            // FrequencyScroll
            // 
            this.FrequencyScroll.Location = new System.Drawing.Point(7, 98);
            this.FrequencyScroll.Maximum = 5000;
            this.FrequencyScroll.Minimum = 40;
            this.FrequencyScroll.Name = "FrequencyScroll";
            this.FrequencyScroll.Size = new System.Drawing.Size(128, 21);
            this.FrequencyScroll.TabIndex = 1;
            this.FrequencyScroll.Value = 40;
            this.FrequencyScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FrequencyScroll_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voltage (RMS)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frequency (Hz)";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(12, 157);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(80, 41);
            this.OkBtn.TabIndex = 6;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(122, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelVoltage
            // 
            this.labelVoltage.BackColor = System.Drawing.SystemColors.Window;
            this.labelVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVoltage.Location = new System.Drawing.Point(146, 42);
            this.labelVoltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(46, 19);
            this.labelVoltage.TabIndex = 8;
            this.labelVoltage.Text = "0";
            // 
            // labelFrequency
            // 
            this.labelFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.labelFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFrequency.Location = new System.Drawing.Point(146, 97);
            this.labelFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(46, 19);
            this.labelFrequency.TabIndex = 9;
            this.labelFrequency.Text = "0";
            // 
            // InitialParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 207);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelVoltage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrequencyScroll);
            this.Controls.Add(this.VoltageScroll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitialParams";
            this.Text = "Nominal Parameters";
            this.Load += new System.EventHandler(this.InitialParams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.HScrollBar VoltageScroll;
        public System.Windows.Forms.HScrollBar FrequencyScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Label labelFrequency;
    }
}