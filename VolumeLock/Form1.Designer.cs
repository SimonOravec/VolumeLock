namespace VolumeLock
{
    partial class Form1
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
            this.input_vol = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.enabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // input_vol
            // 
            this.input_vol.Location = new System.Drawing.Point(77, 40);
            this.input_vol.Name = "input_vol";
            this.input_vol.Size = new System.Drawing.Size(120, 22);
            this.input_vol.TabIndex = 0;
            this.input_vol.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.input_vol.ValueChanged += new System.EventHandler(this.input_vol_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume:";
            // 
            // enabled
            // 
            this.enabled.AutoSize = true;
            this.enabled.Location = new System.Drawing.Point(15, 12);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(82, 21);
            this.enabled.TabIndex = 2;
            this.enabled.Text = "Enabled";
            this.enabled.UseVisualStyleBackColor = true;
            this.enabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_vol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "VolumeLock";
            ((System.ComponentModel.ISupportInitialize)(this.input_vol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown input_vol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enabled;
    }
}

