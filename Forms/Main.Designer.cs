namespace Fractals
{
    partial class Main
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
            this.Levi = new System.Windows.Forms.Button();
            this.Koch = new System.Windows.Forms.Button();
            this.BoxCurve = new System.Windows.Forms.GroupBox();
            this.BoxCurve.SuspendLayout();
            this.SuspendLayout();
            // 
            // Levi
            // 
            this.Levi.Location = new System.Drawing.Point(6, 19);
            this.Levi.Name = "Levi";
            this.Levi.Size = new System.Drawing.Size(75, 23);
            this.Levi.TabIndex = 0;
            this.Levi.Text = "Levi";
            this.Levi.UseVisualStyleBackColor = true;
            this.Levi.Click += new System.EventHandler(this.Levi_Click);
            // 
            // Koch
            // 
            this.Koch.Location = new System.Drawing.Point(6, 48);
            this.Koch.Name = "Koch";
            this.Koch.Size = new System.Drawing.Size(75, 23);
            this.Koch.TabIndex = 1;
            this.Koch.Text = "Koch";
            this.Koch.UseVisualStyleBackColor = true;
            this.Koch.Click += new System.EventHandler(this.Koch_Click);
            // 
            // BoxCurve
            // 
            this.BoxCurve.Controls.Add(this.Levi);
            this.BoxCurve.Controls.Add(this.Koch);
            this.BoxCurve.Location = new System.Drawing.Point(52, 12);
            this.BoxCurve.Name = "BoxCurve";
            this.BoxCurve.Size = new System.Drawing.Size(110, 82);
            this.BoxCurve.TabIndex = 2;
            this.BoxCurve.TabStop = false;
            this.BoxCurve.Text = "Curve";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 115);
            this.Controls.Add(this.BoxCurve);
            this.Name = "Main";
            this.Text = "Select";
            this.BoxCurve.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Levi;
        private System.Windows.Forms.Button Koch;
        private System.Windows.Forms.GroupBox BoxCurve;
    }
}