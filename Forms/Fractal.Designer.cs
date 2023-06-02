namespace Fractals
{
    partial class Fractal
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlN = new System.Windows.Forms.TrackBar();
            this.LabelN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlN
            // 
            this.ControlN.Location = new System.Drawing.Point(805, 47);
            this.ControlN.Name = "ControlN";
            this.ControlN.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ControlN.Size = new System.Drawing.Size(45, 353);
            this.ControlN.TabIndex = 1;
            this.ControlN.Scroll += new System.EventHandler(this.ControlN_Scroll);
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Location = new System.Drawing.Point(805, 28);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(35, 13);
            this.LabelN.TabIndex = 2;
            this.LabelN.Text = "label1";
            // 
            // Fractal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.ControlN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fractal";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fractal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar ControlN;
        private System.Windows.Forms.Label LabelN;
    }
}

