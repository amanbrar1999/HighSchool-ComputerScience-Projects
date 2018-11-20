namespace CreditCardValidation
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
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ValidateLabel = new System.Windows.Forms.Label();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VisaRadioButton = new System.Windows.Forms.RadioButton();
            this.DinersClubRadioButton = new System.Windows.Forms.RadioButton();
            this.DiscoverRadioButton = new System.Windows.Forms.RadioButton();
            this.MasterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.AMEXradioButton = new System.Windows.Forms.RadioButton();
            this.generatedNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(126, 51);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.CardNumberTextBox.TabIndex = 0;
            // 
            // ValidateLabel
            // 
            this.ValidateLabel.AutoSize = true;
            this.ValidateLabel.Location = new System.Drawing.Point(123, 303);
            this.ValidateLabel.Name = "ValidateLabel";
            this.ValidateLabel.Size = new System.Drawing.Size(0, 13);
            this.ValidateLabel.TabIndex = 1;
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(126, 111);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(204, 134);
            this.ValidateButton.TabIndex = 2;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(105, 111);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(206, 134);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate Valid Credit Card Number";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ValidateButton);
            this.groupBox1.Controls.Add(this.CardNumberTextBox);
            this.groupBox1.Controls.Add(this.ValidateLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check If A Card Number Is Valid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.generatedNumberLabel);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Location = new System.Drawing.Point(500, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 372);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate a Random, Valid Credit Card Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VisaRadioButton);
            this.groupBox3.Controls.Add(this.DinersClubRadioButton);
            this.groupBox3.Controls.Add(this.DiscoverRadioButton);
            this.groupBox3.Controls.Add(this.MasterCardRadioButton);
            this.groupBox3.Controls.Add(this.AMEXradioButton);
            this.groupBox3.Location = new System.Drawing.Point(27, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Card Type";
            // 
            // VisaRadioButton
            // 
            this.VisaRadioButton.AutoSize = true;
            this.VisaRadioButton.Location = new System.Drawing.Point(20, 28);
            this.VisaRadioButton.Name = "VisaRadioButton";
            this.VisaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.VisaRadioButton.TabIndex = 5;
            this.VisaRadioButton.TabStop = true;
            this.VisaRadioButton.Text = "Visa";
            this.VisaRadioButton.UseVisualStyleBackColor = true;
            // 
            // DinersClubRadioButton
            // 
            this.DinersClubRadioButton.AutoSize = true;
            this.DinersClubRadioButton.Location = new System.Drawing.Point(252, 28);
            this.DinersClubRadioButton.Name = "DinersClubRadioButton";
            this.DinersClubRadioButton.Size = new System.Drawing.Size(79, 17);
            this.DinersClubRadioButton.TabIndex = 7;
            this.DinersClubRadioButton.TabStop = true;
            this.DinersClubRadioButton.Text = "Diners Club";
            this.DinersClubRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiscoverRadioButton
            // 
            this.DiscoverRadioButton.AutoSize = true;
            this.DiscoverRadioButton.Location = new System.Drawing.Point(123, 51);
            this.DiscoverRadioButton.Name = "DiscoverRadioButton";
            this.DiscoverRadioButton.Size = new System.Drawing.Size(67, 17);
            this.DiscoverRadioButton.TabIndex = 9;
            this.DiscoverRadioButton.TabStop = true;
            this.DiscoverRadioButton.Text = "Discover";
            this.DiscoverRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasterCardRadioButton
            // 
            this.MasterCardRadioButton.AutoSize = true;
            this.MasterCardRadioButton.Location = new System.Drawing.Point(20, 51);
            this.MasterCardRadioButton.Name = "MasterCardRadioButton";
            this.MasterCardRadioButton.Size = new System.Drawing.Size(82, 17);
            this.MasterCardRadioButton.TabIndex = 6;
            this.MasterCardRadioButton.TabStop = true;
            this.MasterCardRadioButton.Text = "Master Card";
            this.MasterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // AMEXradioButton
            // 
            this.AMEXradioButton.AutoSize = true;
            this.AMEXradioButton.Location = new System.Drawing.Point(123, 28);
            this.AMEXradioButton.Name = "AMEXradioButton";
            this.AMEXradioButton.Size = new System.Drawing.Size(109, 17);
            this.AMEXradioButton.TabIndex = 8;
            this.AMEXradioButton.TabStop = true;
            this.AMEXradioButton.Text = "American Express";
            this.AMEXradioButton.UseVisualStyleBackColor = true;
            // 
            // generatedNumberLabel
            // 
            this.generatedNumberLabel.AutoSize = true;
            this.generatedNumberLabel.Location = new System.Drawing.Point(69, 273);
            this.generatedNumberLabel.Name = "generatedNumberLabel";
            this.generatedNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.generatedNumberLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label ValidateLabel;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label generatedNumberLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton VisaRadioButton;
        private System.Windows.Forms.RadioButton DinersClubRadioButton;
        private System.Windows.Forms.RadioButton DiscoverRadioButton;
        private System.Windows.Forms.RadioButton MasterCardRadioButton;
        private System.Windows.Forms.RadioButton AMEXradioButton;
    }
}

