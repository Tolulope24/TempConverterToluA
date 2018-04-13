namespace TempConverterToluA
{
    partial class frmTempConverter
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblEnterCelsius = new System.Windows.Forms.Label();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(15, 75);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblEnterCelsius
            // 
            this.lblEnterCelsius.AutoSize = true;
            this.lblEnterCelsius.Location = new System.Drawing.Point(12, 35);
            this.lblEnterCelsius.Name = "lblEnterCelsius";
            this.lblEnterCelsius.Size = new System.Drawing.Size(141, 13);
            this.lblEnterCelsius.TabIndex = 1;
            this.lblEnterCelsius.Text = "Enter the Degree (in Celsius)";
            // 
            // txtDegrees
            // 
            this.txtDegrees.Location = new System.Drawing.Point(159, 32);
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.Size = new System.Drawing.Size(51, 20);
            this.txtDegrees.TabIndex = 3;
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 176);
            this.Controls.Add(this.txtDegrees);
            this.Controls.Add(this.lblEnterCelsius);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmTempConverter";
            this.Text = "TempConverter";
            this.Load += new System.EventHandler(this.frmTempConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblEnterCelsius;
        private System.Windows.Forms.TextBox txtDegrees;
    }
}

