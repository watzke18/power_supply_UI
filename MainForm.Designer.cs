using System;

namespace California_Instruments_CSW5550_Software
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCSW5550ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureCommPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.InitialParamBtn = new System.Windows.Forms.Button();
            this.TestModeBtn = new System.Windows.Forms.Button();
            this.DropOutBtn = new System.Windows.Forms.Button();
            this.RunTestBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActualVoltage = new System.Windows.Forms.Label();
            this.ActualFrequency = new System.Windows.Forms.Label();
            this.ActualCurrent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openCom = new System.Windows.Forms.Button();
            this.HighVoltageBox = new System.Windows.Forms.TextBox();
            this.StatusMsg = new System.Windows.Forms.TextBox();
            this.CautionTimer = new System.Windows.Forms.Timer(this.components);
            this.incrementTestTimer = new System.Windows.Forms.Timer(this.components);
            this.multipleTestTimer = new System.Windows.Forms.Timer(this.components);
            this.labelNextDropoutVoltage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNextDropoutTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLoopNumber = new System.Windows.Forms.Label();
            this.buttonAbortTest = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.stateTimer = new System.Windows.Forms.Timer(this.components);
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(539, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openCtrlOToolStripMenuItem,
            this.importCSVToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetCSW5550ToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.openCtrlOToolStripMenuItem.Text = "Open";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.importCSVToolStripMenuItem.Text = "Import Test .CSV File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.saveToolStripMenuItem.Text = "Save         ";
            // 
            // resetCSW5550ToolStripMenuItem
            // 
            this.resetCSW5550ToolStripMenuItem.Name = "resetCSW5550ToolStripMenuItem";
            this.resetCSW5550ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.resetCSW5550ToolStripMenuItem.Text = "Reset CSW5550";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureCommPortToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.configToolStripMenuItem.Text = "Setup";
            // 
            // configureCommPortToolStripMenuItem
            // 
            this.configureCommPortToolStripMenuItem.Name = "configureCommPortToolStripMenuItem";
            this.configureCommPortToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.configureCommPortToolStripMenuItem.Text = "Configure Comm Port";
            this.configureCommPortToolStripMenuItem.Click += new System.EventHandler(this.configureCommPortToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // InitialParamBtn
            // 
            this.InitialParamBtn.Enabled = false;
            this.InitialParamBtn.Location = new System.Drawing.Point(12, 102);
            this.InitialParamBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InitialParamBtn.Name = "InitialParamBtn";
            this.InitialParamBtn.Size = new System.Drawing.Size(197, 44);
            this.InitialParamBtn.TabIndex = 1;
            this.InitialParamBtn.Text = "Set Initial Test Parameters";
            this.InitialParamBtn.UseVisualStyleBackColor = true;
            this.InitialParamBtn.Click += new System.EventHandler(this.InitialParamBtn_Click);
            // 
            // TestModeBtn
            // 
            this.TestModeBtn.Enabled = false;
            this.TestModeBtn.Location = new System.Drawing.Point(12, 162);
            this.TestModeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestModeBtn.Name = "TestModeBtn";
            this.TestModeBtn.Size = new System.Drawing.Size(197, 44);
            this.TestModeBtn.TabIndex = 2;
            this.TestModeBtn.Text = "Set Test Mode";
            this.TestModeBtn.UseVisualStyleBackColor = true;
            this.TestModeBtn.Click += new System.EventHandler(this.TestModeBtn_Click);
            // 
            // DropOutBtn
            // 
            this.DropOutBtn.Enabled = false;
            this.DropOutBtn.Location = new System.Drawing.Point(12, 223);
            this.DropOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DropOutBtn.Name = "DropOutBtn";
            this.DropOutBtn.Size = new System.Drawing.Size(197, 44);
            this.DropOutBtn.TabIndex = 3;
            this.DropOutBtn.Text = "Set Drop Out Parameters";
            this.DropOutBtn.UseVisualStyleBackColor = true;
            this.DropOutBtn.Click += new System.EventHandler(this.DropOutBtn_Click);
            // 
            // RunTestBtn
            // 
            this.RunTestBtn.Enabled = false;
            this.RunTestBtn.Location = new System.Drawing.Point(12, 284);
            this.RunTestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunTestBtn.Name = "RunTestBtn";
            this.RunTestBtn.Size = new System.Drawing.Size(197, 44);
            this.RunTestBtn.TabIndex = 4;
            this.RunTestBtn.Text = "Run Test";
            this.RunTestBtn.UseVisualStyleBackColor = true;
            this.RunTestBtn.Click += new System.EventHandler(this.RunTestBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(12, 346);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(197, 44);
            this.QuitBtn.TabIndex = 5;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // console
            // 
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.Location = new System.Drawing.Point(272, 47);
            this.console.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(233, 138);
            this.console.TabIndex = 6;
            this.console.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Console";
            // 
            // ActualVoltage
            // 
            this.ActualVoltage.BackColor = System.Drawing.SystemColors.Window;
            this.ActualVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ActualVoltage.Enabled = false;
            this.ActualVoltage.Location = new System.Drawing.Point(379, 433);
            this.ActualVoltage.Name = "ActualVoltage";
            this.ActualVoltage.Size = new System.Drawing.Size(127, 26);
            this.ActualVoltage.TabIndex = 9;
            this.ActualVoltage.Text = "0";
            this.ActualVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActualFrequency
            // 
            this.ActualFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.ActualFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ActualFrequency.Enabled = false;
            this.ActualFrequency.Location = new System.Drawing.Point(379, 471);
            this.ActualFrequency.Name = "ActualFrequency";
            this.ActualFrequency.Size = new System.Drawing.Size(127, 26);
            this.ActualFrequency.TabIndex = 10;
            this.ActualFrequency.Text = "0";
            this.ActualFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActualCurrent
            // 
            this.ActualCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.ActualCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ActualCurrent.Enabled = false;
            this.ActualCurrent.Location = new System.Drawing.Point(379, 508);
            this.ActualCurrent.Name = "ActualCurrent";
            this.ActualCurrent.Size = new System.Drawing.Size(127, 26);
            this.ActualCurrent.TabIndex = 11;
            this.ActualCurrent.Text = "0";
            this.ActualCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output Measurements";
            // 
            // openCom
            // 
            this.openCom.Location = new System.Drawing.Point(12, 43);
            this.openCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openCom.Name = "openCom";
            this.openCom.Size = new System.Drawing.Size(197, 44);
            this.openCom.TabIndex = 13;
            this.openCom.Text = "Open Comm Channel";
            this.openCom.UseVisualStyleBackColor = true;
            this.openCom.Click += new System.EventHandler(this.openCom_Click);
            // 
            // HighVoltageBox
            // 
            this.HighVoltageBox.BackColor = System.Drawing.Color.Red;
            this.HighVoltageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighVoltageBox.Location = new System.Drawing.Point(20, 454);
            this.HighVoltageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HighVoltageBox.Multiline = true;
            this.HighVoltageBox.Name = "HighVoltageBox";
            this.HighVoltageBox.Size = new System.Drawing.Size(308, 58);
            this.HighVoltageBox.TabIndex = 16;
            this.HighVoltageBox.Text = "!!!  CAUTION  !!!\r\nHigh Voltage ON\r\n";
            this.HighVoltageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighVoltageBox.Visible = false;
            // 
            // StatusMsg
            // 
            this.StatusMsg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StatusMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMsg.ForeColor = System.Drawing.SystemColors.Window;
            this.StatusMsg.Location = new System.Drawing.Point(0, 561);
            this.StatusMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.ReadOnly = true;
            this.StatusMsg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.StatusMsg.Size = new System.Drawing.Size(539, 22);
            this.StatusMsg.TabIndex = 17;
            this.StatusMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CautionTimer
            // 
            this.CautionTimer.Interval = 1000;
            this.CautionTimer.Tick += new System.EventHandler(this.CautionTimer_Tick);
            // 
            // incrementTestTimer
            // 
            this.incrementTestTimer.Tick += new System.EventHandler(this.incrementTestTimer_Tick);
            // 
            // multipleTestTimer
            // 
            this.multipleTestTimer.Tick += new System.EventHandler(this.multipleTestTimer_Tick);
            // 
            // labelNextDropoutVoltage
            // 
            this.labelNextDropoutVoltage.BackColor = System.Drawing.SystemColors.Window;
            this.labelNextDropoutVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNextDropoutVoltage.Enabled = false;
            this.labelNextDropoutVoltage.Location = new System.Drawing.Point(434, 189);
            this.labelNextDropoutVoltage.Name = "labelNextDropoutVoltage";
            this.labelNextDropoutVoltage.Size = new System.Drawing.Size(71, 26);
            this.labelNextDropoutVoltage.TabIndex = 22;
            this.labelNextDropoutVoltage.Text = "0";
            this.labelNextDropoutVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(269, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Next Dropout Voltage:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(269, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Next Dropout Time:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNextDropoutTime
            // 
            this.labelNextDropoutTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelNextDropoutTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNextDropoutTime.Enabled = false;
            this.labelNextDropoutTime.Location = new System.Drawing.Point(434, 215);
            this.labelNextDropoutTime.Name = "labelNextDropoutTime";
            this.labelNextDropoutTime.Size = new System.Drawing.Size(71, 26);
            this.labelNextDropoutTime.TabIndex = 24;
            this.labelNextDropoutTime.Text = "0";
            this.labelNextDropoutTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(269, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Loop Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoopNumber
            // 
            this.labelLoopNumber.BackColor = System.Drawing.SystemColors.Window;
            this.labelLoopNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoopNumber.Enabled = false;
            this.labelLoopNumber.Location = new System.Drawing.Point(434, 241);
            this.labelLoopNumber.Name = "labelLoopNumber";
            this.labelLoopNumber.Size = new System.Drawing.Size(71, 26);
            this.labelLoopNumber.TabIndex = 28;
            this.labelLoopNumber.Text = "0";
            this.labelLoopNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAbortTest
            // 
            this.buttonAbortTest.Location = new System.Drawing.Point(272, 346);
            this.buttonAbortTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbortTest.Name = "buttonAbortTest";
            this.buttonAbortTest.Size = new System.Drawing.Size(233, 44);
            this.buttonAbortTest.TabIndex = 30;
            this.buttonAbortTest.Text = "Abort Test";
            this.buttonAbortTest.UseVisualStyleBackColor = true;
            this.buttonAbortTest.Click += new System.EventHandler(this.buttonAbortTest_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(272, 284);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(233, 45);
            this.PauseBtn.TabIndex = 31;
            this.PauseBtn.Text = "Pause Test";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Visible = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // stateTimer
            // 
            this.stateTimer.Interval = 1000;
            this.stateTimer.Tick += new System.EventHandler(this.stateTimer_Tick);
            // 
            // countTimer
            // 
            this.countTimer.Interval = 500;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 585);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.buttonAbortTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLoopNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNextDropoutTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNextDropoutVoltage);
            this.Controls.Add(this.StatusMsg);
            this.Controls.Add(this.HighVoltageBox);
            this.Controls.Add(this.openCom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActualCurrent);
            this.Controls.Add(this.ActualFrequency);
            this.Controls.Add(this.ActualVoltage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.RunTestBtn);
            this.Controls.Add(this.DropOutBtn);
            this.Controls.Add(this.TestModeBtn);
            this.Controls.Add(this.InitialParamBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Brown Out/Black Out Test Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCSW5550ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Button InitialParamBtn;
        public System.Windows.Forms.Button TestModeBtn;
        public System.Windows.Forms.Button DropOutBtn;
        public System.Windows.Forms.Button RunTestBtn;
        private System.Windows.Forms.Button QuitBtn;
        public System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ActualVoltage;
        public System.Windows.Forms.Label ActualFrequency;
        public System.Windows.Forms.Label ActualCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openCom;
        public System.Windows.Forms.TextBox HighVoltageBox;
        public System.Windows.Forms.TextBox StatusMsg;
        public System.Windows.Forms.Timer CautionTimer;
        private System.Windows.Forms.Timer incrementTestTimer;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureCommPortToolStripMenuItem;
        private System.Windows.Forms.Timer multipleTestTimer;
        public System.Windows.Forms.Label labelNextDropoutVoltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelNextDropoutTime;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelLoopNumber;
        private System.Windows.Forms.Button buttonAbortTest;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.Timer stateTimer;
        private System.Windows.Forms.Timer countTimer;
    }
}

