
namespace California_Instruments_CSW5550_Software
{
    partial class DropoutParams
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

            this.labelDropVoltMin = new System.Windows.Forms.Label();
            this.labelDropVoltStep = new System.Windows.Forms.Label();
            this.numericUpDownDropVoltStep = new System.Windows.Forms.NumericUpDown();
            this.labelDropVoltMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.comboBoxDropTimeMin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDropTimeMin = new System.Windows.Forms.Label();
            this.numericUpDownDropTimeMin = new System.Windows.Forms.NumericUpDown();
            this.labelDropTimeStep = new System.Windows.Forms.Label();
            this.numericUpDownDropTimeStep = new System.Windows.Forms.NumericUpDown();
            this.labelDropTimeMax = new System.Windows.Forms.Label();
            this.numericUpDownDropTimeMax = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDelay = new System.Windows.Forms.ComboBox();
            this.labelLoops = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddDropout = new System.Windows.Forms.Button();
            this.buttonDeleteLastEntry = new System.Windows.Forms.Button();
            this.comboBoxDropTimeMax = new System.Windows.Forms.ComboBox();
            this.comboBoxDropTimeStep = new System.Windows.Forms.ComboBox();
            this.listBoxDropOutSteps = new System.Windows.Forms.ListBox();
            this.labelLoopNote = new System.Windows.Forms.Label();
            this.numericUpDownLoops = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDropVoltMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDropVoltMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPhase = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhase)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDropVoltMin
            // 
            this.labelDropVoltMin.AutoSize = true;
            this.labelDropVoltMin.Location = new System.Drawing.Point(32, 32);
            this.labelDropVoltMin.Name = "labelDropVoltMin";
            this.labelDropVoltMin.Size = new System.Drawing.Size(227, 17);
            this.labelDropVoltMin.TabIndex = 0;
            this.labelDropVoltMin.Text = "Minimum Drop Out Voltage (Vrms):";
            // 
            // labelDropVoltStep
            // 
            this.labelDropVoltStep.AutoSize = true;
            this.labelDropVoltStep.Location = new System.Drawing.Point(32, 87);
            this.labelDropVoltStep.Name = "labelDropVoltStep";
            this.labelDropVoltStep.Size = new System.Drawing.Size(72, 17);
            this.labelDropVoltStep.TabIndex = 3;
            this.labelDropVoltStep.Text = "Step Size:";
            // 
            // numericUpDownDropVoltStep
            // 
            this.numericUpDownDropVoltStep.Location = new System.Drawing.Point(293, 85);
            this.numericUpDownDropVoltStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropVoltStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDropVoltStep.Name = "numericUpDownDropVoltStep";
            this.numericUpDownDropVoltStep.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownDropVoltStep.TabIndex = 4;
            this.numericUpDownDropVoltStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDropVoltMax
            // 
            this.labelDropVoltMax.AutoSize = true;
            this.labelDropVoltMax.Location = new System.Drawing.Point(32, 144);
            this.labelDropVoltMax.Name = "labelDropVoltMax";
            this.labelDropVoltMax.Size = new System.Drawing.Size(184, 17);
            this.labelDropVoltMax.TabIndex = 5;
            this.labelDropVoltMax.Text = "Maximum Drop Out Voltage:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 2);
            this.label4.TabIndex = 7;
            // 
            // labelPhase
            // 
            this.labelPhase.AutoSize = true;
            this.labelPhase.Location = new System.Drawing.Point(32, 199);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(154, 17);
            this.labelPhase.TabIndex = 8;
            this.labelPhase.Text = "Drop Out Phase (Deg):";
            // 
            // comboBoxDropTimeMin
            // 
            this.comboBoxDropTimeMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropTimeMin.FormattingEnabled = true;
            this.comboBoxDropTimeMin.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.comboBoxDropTimeMin.Location = new System.Drawing.Point(293, 256);
            this.comboBoxDropTimeMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDropTimeMin.Name = "comboBoxDropTimeMin";
            this.comboBoxDropTimeMin.Size = new System.Drawing.Size(85, 24);
            this.comboBoxDropTimeMin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(25, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 2);
            this.label6.TabIndex = 10;
            // 
            // labelDropTimeMin
            // 
            this.labelDropTimeMin.AutoSize = true;
            this.labelDropTimeMin.Location = new System.Drawing.Point(32, 258);
            this.labelDropTimeMin.Name = "labelDropTimeMin";
            this.labelDropTimeMin.Size = new System.Drawing.Size(164, 17);
            this.labelDropTimeMin.TabIndex = 11;
            this.labelDropTimeMin.Text = "Minimum Drop Out Time:";
            // 
            // numericUpDownDropTimeMin
            // 
            this.numericUpDownDropTimeMin.Location = new System.Drawing.Point(220, 257);
            this.numericUpDownDropTimeMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropTimeMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDropTimeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDropTimeMin.Name = "numericUpDownDropTimeMin";
            this.numericUpDownDropTimeMin.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownDropTimeMin.TabIndex = 12;
            this.numericUpDownDropTimeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDropTimeStep
            // 
            this.labelDropTimeStep.AutoSize = true;
            this.labelDropTimeStep.Location = new System.Drawing.Point(32, 311);
            this.labelDropTimeStep.Name = "labelDropTimeStep";
            this.labelDropTimeStep.Size = new System.Drawing.Size(72, 17);
            this.labelDropTimeStep.TabIndex = 13;
            this.labelDropTimeStep.Text = "Step Size:";
            // 
            // numericUpDownDropTimeStep
            // 
            this.numericUpDownDropTimeStep.Location = new System.Drawing.Point(220, 306);
            this.numericUpDownDropTimeStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropTimeStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDropTimeStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDropTimeStep.Name = "numericUpDownDropTimeStep";
            this.numericUpDownDropTimeStep.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownDropTimeStep.TabIndex = 14;
            this.numericUpDownDropTimeStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDropTimeMax
            // 
            this.labelDropTimeMax.AutoSize = true;
            this.labelDropTimeMax.Location = new System.Drawing.Point(32, 364);
            this.labelDropTimeMax.Name = "labelDropTimeMax";
            this.labelDropTimeMax.Size = new System.Drawing.Size(167, 17);
            this.labelDropTimeMax.TabIndex = 15;
            this.labelDropTimeMax.Text = "Maximum Drop Out Time:";
            // 
            // numericUpDownDropTimeMax
            // 
            this.numericUpDownDropTimeMax.Location = new System.Drawing.Point(220, 359);
            this.numericUpDownDropTimeMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropTimeMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDropTimeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDropTimeMax.Name = "numericUpDownDropTimeMax";
            this.numericUpDownDropTimeMax.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownDropTimeMax.TabIndex = 16;
            this.numericUpDownDropTimeMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(25, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(371, 2);
            this.label10.TabIndex = 17;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(32, 417);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(175, 17);
            this.labelDelay.TabIndex = 18;
            this.labelDelay.Text = "Delay Between Drop Outs:";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(220, 415);
            this.numericUpDownDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownDelay.TabIndex = 19;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.numericUpDownDelay_ValueChanged);
            // 
            // comboBoxDelay
            // 
            this.comboBoxDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelay.FormattingEnabled = true;
            this.comboBoxDelay.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.comboBoxDelay.Location = new System.Drawing.Point(293, 414);
            this.comboBoxDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDelay.Name = "comboBoxDelay";
            this.comboBoxDelay.Size = new System.Drawing.Size(85, 24);
            this.comboBoxDelay.TabIndex = 20;
            this.comboBoxDelay.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelay_SelectedIndexChanged);
            // 
            // labelLoops
            // 
            this.labelLoops.AutoSize = true;
            this.labelLoops.Location = new System.Drawing.Point(32, 453);
            this.labelLoops.Name = "labelLoops";
            this.labelLoops.Size = new System.Drawing.Size(121, 17);
            this.labelLoops.TabIndex = 21;
            this.labelLoops.Text = "Number of Loops:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(52, 533);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(81, 32);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(176, 533);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 32);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddDropout
            // 
            this.buttonAddDropout.Location = new System.Drawing.Point(427, 533);
            this.buttonAddDropout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDropout.Name = "buttonAddDropout";
            this.buttonAddDropout.Size = new System.Drawing.Size(112, 32);
            this.buttonAddDropout.TabIndex = 28;
            this.buttonAddDropout.Text = "Add Drop Out";
            this.buttonAddDropout.UseVisualStyleBackColor = true;
            this.buttonAddDropout.Click += new System.EventHandler(this.buttonAddDropout_Click);


            // 
            // buttonDeleteLastEntry
            // 
            this.buttonDeleteLastEntry.Location = new System.Drawing.Point(545, 533);
            this.buttonDeleteLastEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteLastEntry.Name = "buttonDeleteLastEntry";
            this.buttonDeleteLastEntry.Size = new System.Drawing.Size(132, 32);
            this.buttonDeleteLastEntry.TabIndex = 29;
            this.buttonDeleteLastEntry.Text = "Delete Last Entry";
            this.buttonDeleteLastEntry.UseVisualStyleBackColor = true;
            this.buttonDeleteLastEntry.Click += new System.EventHandler(this.buttonDeleteLastEntry_Click);
            // 
            // comboBoxDropTimeMax
            // 
            this.comboBoxDropTimeMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropTimeMax.FormattingEnabled = true;
            this.comboBoxDropTimeMax.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.comboBoxDropTimeMax.Location = new System.Drawing.Point(293, 358);
            this.comboBoxDropTimeMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDropTimeMax.Name = "comboBoxDropTimeMax";
            this.comboBoxDropTimeMax.Size = new System.Drawing.Size(85, 24);
            this.comboBoxDropTimeMax.TabIndex = 31;
            // 
            // comboBoxDropTimeStep
            // 
            this.comboBoxDropTimeStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropTimeStep.FormattingEnabled = true;
            this.comboBoxDropTimeStep.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.comboBoxDropTimeStep.Location = new System.Drawing.Point(293, 305);
            this.comboBoxDropTimeStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDropTimeStep.Name = "comboBoxDropTimeStep";
            this.comboBoxDropTimeStep.Size = new System.Drawing.Size(85, 24);
            this.comboBoxDropTimeStep.TabIndex = 32;
            // 
            // listBoxDropOutSteps
            // 
            this.listBoxDropOutSteps.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxDropOutSteps.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxDropOutSteps.FormattingEnabled = true;
            this.listBoxDropOutSteps.ItemHeight = 16;
            this.listBoxDropOutSteps.Location = new System.Drawing.Point(428, 30);
            this.listBoxDropOutSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDropOutSteps.Name = "listBoxDropOutSteps";
            this.listBoxDropOutSteps.Size = new System.Drawing.Size(249, 484);
            this.listBoxDropOutSteps.TabIndex = 33;
            // 
            // labelLoopNote
            // 
            this.labelLoopNote.AutoSize = true;
            this.labelLoopNote.Location = new System.Drawing.Point(32, 491);
            this.labelLoopNote.Name = "labelLoopNote";
            this.labelLoopNote.Size = new System.Drawing.Size(219, 17);
            this.labelLoopNote.TabIndex = 34;
            this.labelLoopNote.Text = "*delay/num loops are test specific";
            // 
            // numericUpDownLoops
            // 
            this.numericUpDownLoops.Location = new System.Drawing.Point(293, 450);
            this.numericUpDownLoops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLoops.Name = "numericUpDownLoops";
            this.numericUpDownLoops.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownLoops.TabIndex = 35;
            this.numericUpDownLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLoops.ValueChanged += new System.EventHandler(this.numericUpDownLoops_ValueChanged);
            // 
            // numericUpDownDropVoltMin
            // 
            this.numericUpDownDropVoltMin.Location = new System.Drawing.Point(293, 30);
            this.numericUpDownDropVoltMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropVoltMin.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDropVoltMin.Name = "numericUpDownDropVoltMin";
            this.numericUpDownDropVoltMin.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownDropVoltMin.TabIndex = 36;
            // 
            // numericUpDownDropVoltMax
            // 
            this.numericUpDownDropVoltMax.Location = new System.Drawing.Point(293, 142);
            this.numericUpDownDropVoltMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDropVoltMax.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownDropVoltMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDropVoltMax.Name = "numericUpDownDropVoltMax";
            this.numericUpDownDropVoltMax.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownDropVoltMax.TabIndex = 37;
            this.numericUpDownDropVoltMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPhase
            // 
            this.numericUpDownPhase.Location = new System.Drawing.Point(293, 197);
            this.numericUpDownPhase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPhase.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDownPhase.Name = "numericUpDownPhase";
            this.numericUpDownPhase.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownPhase.TabIndex = 38;
            // 
            // DropoutParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 578);
            this.Controls.Add(this.numericUpDownPhase);
            this.Controls.Add(this.numericUpDownDropVoltMax);
            this.Controls.Add(this.numericUpDownDropVoltMin);
            this.Controls.Add(this.numericUpDownLoops);
            this.Controls.Add(this.labelLoopNote);
            this.Controls.Add(this.listBoxDropOutSteps);
            this.Controls.Add(this.comboBoxDropTimeStep);
            this.Controls.Add(this.comboBoxDropTimeMax);
            this.Controls.Add(this.buttonDeleteLastEntry);
            this.Controls.Add(this.buttonAddDropout);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelLoops);
            this.Controls.Add(this.comboBoxDelay);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownDropTimeMax);
            this.Controls.Add(this.labelDropTimeMax);
            this.Controls.Add(this.numericUpDownDropTimeStep);
            this.Controls.Add(this.labelDropTimeStep);
            this.Controls.Add(this.numericUpDownDropTimeMin);
            this.Controls.Add(this.labelDropTimeMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDropTimeMin);
            this.Controls.Add(this.labelPhase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDropVoltMax);
            this.Controls.Add(this.numericUpDownDropVoltStep);
            this.Controls.Add(this.labelDropVoltStep);
            this.Controls.Add(this.labelDropVoltMin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DropoutParams";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Set Test Parameters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DropoutParams_FormClosing);
            this.Load += new System.EventHandler(this.dropoutParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDropVoltMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDropVoltMin;
        private System.Windows.Forms.Label labelDropVoltStep;
        public System.Windows.Forms.NumericUpDown numericUpDownDropVoltStep;
        private System.Windows.Forms.Label labelDropVoltMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPhase;
        public System.Windows.Forms.ComboBox comboBoxDropTimeMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDropTimeMin;
        public System.Windows.Forms.NumericUpDown numericUpDownDropTimeMin;
        private System.Windows.Forms.Label labelDropTimeStep;
        public System.Windows.Forms.NumericUpDown numericUpDownDropTimeStep;
        private System.Windows.Forms.Label labelDropTimeMax;
        public System.Windows.Forms.NumericUpDown numericUpDownDropTimeMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDelay;
        public System.Windows.Forms.NumericUpDown numericUpDownDelay;
        public System.Windows.Forms.ComboBox comboBoxDelay;
        private System.Windows.Forms.Label labelLoops;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddDropout;
        private System.Windows.Forms.Button buttonDeleteLastEntry;
        public System.Windows.Forms.ComboBox comboBoxDropTimeMax;
        public System.Windows.Forms.ComboBox comboBoxDropTimeStep;
        public System.Windows.Forms.ListBox listBoxDropOutSteps;
        private System.Windows.Forms.Label labelLoopNote;
        public System.Windows.Forms.NumericUpDown numericUpDownLoops;
        public System.Windows.Forms.NumericUpDown numericUpDownDropVoltMin;
        public System.Windows.Forms.NumericUpDown numericUpDownDropVoltMax;
        public System.Windows.Forms.NumericUpDown numericUpDownPhase;
    }
}