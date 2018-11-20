namespace simple_mandelbrot
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
            this.mandelbrotPictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelbrotPictureBox
            // 
            this.mandelbrotPictureBox.Location = new System.Drawing.Point(21, 12);
            this.mandelbrotPictureBox.Name = "mandelbrotPictureBox";
            this.mandelbrotPictureBox.Size = new System.Drawing.Size(800, 600);
            this.mandelbrotPictureBox.TabIndex = 0;
            this.mandelbrotPictureBox.TabStop = false;
            this.mandelbrotPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mandelbrotPictureBox_Paint);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(827, 198);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "button1";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 636);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.mandelbrotPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelbrotPictureBox;
        private System.Windows.Forms.Button drawButton;
    }
}

