namespace CheckerBoard
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
            this.checkerBoardPictureBox = new System.Windows.Forms.PictureBox();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.checkerBoardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // checkerBoardPictureBox
            // 
            this.checkerBoardPictureBox.Location = new System.Drawing.Point(12, 12);
            this.checkerBoardPictureBox.Name = "checkerBoardPictureBox";
            this.checkerBoardPictureBox.Size = new System.Drawing.Size(400, 400);
            this.checkerBoardPictureBox.TabIndex = 0;
            this.checkerBoardPictureBox.TabStop = false;
            this.checkerBoardPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.checkerBoardPictureBox_Paint);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(438, 282);
            this.sizeTrackBar.Maximum = 400;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(192, 45);
            this.sizeTrackBar.TabIndex = 2;
            this.sizeTrackBar.TickFrequency = 100;
            this.sizeTrackBar.Scroll += new System.EventHandler(this.sizeTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 436);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.checkerBoardPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.checkerBoardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox checkerBoardPictureBox;
        private System.Windows.Forms.TrackBar sizeTrackBar;
    }
}

