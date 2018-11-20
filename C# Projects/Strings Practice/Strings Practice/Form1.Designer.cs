namespace Strings_Practice
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.palindromeOutputLabel = new System.Windows.Forms.Label();
            this.consonantsOutputLabel = new System.Windows.Forms.Label();
            this.doubleLetterOutputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(117, 62);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // palindromeOutputLabel
            // 
            this.palindromeOutputLabel.AutoSize = true;
            this.palindromeOutputLabel.Location = new System.Drawing.Point(148, 152);
            this.palindromeOutputLabel.Name = "palindromeOutputLabel";
            this.palindromeOutputLabel.Size = new System.Drawing.Size(35, 13);
            this.palindromeOutputLabel.TabIndex = 1;
            this.palindromeOutputLabel.Text = "label1";
            // 
            // consonantsOutputLabel
            // 
            this.consonantsOutputLabel.AutoSize = true;
            this.consonantsOutputLabel.Location = new System.Drawing.Point(148, 179);
            this.consonantsOutputLabel.Name = "consonantsOutputLabel";
            this.consonantsOutputLabel.Size = new System.Drawing.Size(35, 13);
            this.consonantsOutputLabel.TabIndex = 2;
            this.consonantsOutputLabel.Text = "label1";
            // 
            // doubleLetterOutputLabel
            // 
            this.doubleLetterOutputLabel.AutoSize = true;
            this.doubleLetterOutputLabel.Location = new System.Drawing.Point(148, 210);
            this.doubleLetterOutputLabel.Name = "doubleLetterOutputLabel";
            this.doubleLetterOutputLabel.Size = new System.Drawing.Size(35, 13);
            this.doubleLetterOutputLabel.TabIndex = 3;
            this.doubleLetterOutputLabel.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doubleLetterOutputLabel);
            this.Controls.Add(this.consonantsOutputLabel);
            this.Controls.Add(this.palindromeOutputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label palindromeOutputLabel;
        private System.Windows.Forms.Label consonantsOutputLabel;
        private System.Windows.Forms.Label doubleLetterOutputLabel;
        private System.Windows.Forms.Button button1;
    }
}

