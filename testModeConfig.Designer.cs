namespace California_Instruments_CSW5550_Software
{
    partial class testModeConfig
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

            this.SingleButton = new System.Windows.Forms.RadioButton();
            this.MultipleButton = new System.Windows.Forms.RadioButton();
            this.AutomaticButton = new System.Windows.Forms.RadioButton();
            this.SpecialButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleButton
            // 
            this.SingleButton.AutoSize = true;
            this.SingleButton.Location = new System.Drawing.Point(29, 28);
            this.SingleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(130, 21);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.TabStop = true;
            this.SingleButton.Text = "Single Drop Out";
            this.SingleButton.UseVisualStyleBackColor = true;
            // 
            // MultipleButton
            // 
            this.MultipleButton.AutoSize = true;
            this.MultipleButton.Location = new System.Drawing.Point(29, 66);
            this.MultipleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(202, 21);
            this.MultipleButton.TabIndex = 1;
            this.MultipleButton.TabStop = true;
            this.MultipleButton.Text = "Multiple Identical Drop Outs";
            this.MultipleButton.UseVisualStyleBackColor = true;
            // 
            // AutomaticButton
            // 
            this.AutomaticButton.AutoSize = true;
            this.AutomaticButton.Location = new System.Drawing.Point(29, 126);
            this.AutomaticButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutomaticButton.Name = "AutomaticButton";
            this.AutomaticButton.Size = new System.Drawing.Size(322, 21);
            this.AutomaticButton.TabIndex = 2;
            this.AutomaticButton.TabStop = true;
            this.AutomaticButton.Text = "Multiple Drop Outs, Incrementing Time/Voltage";
            this.AutomaticButton.UseVisualStyleBackColor = true;
            // 
            // SpecialButton
            // 
            this.SpecialButton.AutoSize = true;
            this.SpecialButton.Location = new System.Drawing.Point(29, 167);
            this.SpecialButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(289, 21);
            this.SpecialButton.TabIndex = 3;
            this.SpecialButton.TabStop = true;
            this.SpecialButton.Text = "Multiple Drop Outs, Varying Time/Voltage";
            this.SpecialButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 2);
            this.label1.TabIndex = 5;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(52, 221);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(107, 39);
            this.OkBtn.TabIndex = 6;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(243, 221);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 39);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(29, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 2);
            this.label2.TabIndex = 8;
            // 
            // testModeConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpecialButton);
            this.Controls.Add(this.AutomaticButton);
            this.Controls.Add(this.MultipleButton);
            this.Controls.Add(this.SingleButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testModeConfig";
            this.Text = "Set Test Mode";
            this.Load += new System.EventHandler(this.testModeConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton SingleButton;
        public System.Windows.Forms.RadioButton MultipleButton;
        public System.Windows.Forms.RadioButton AutomaticButton;
        public System.Windows.Forms.RadioButton SpecialButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
    }
}