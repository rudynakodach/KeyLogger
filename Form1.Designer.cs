namespace KeyLoggerGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartKeyloggerButton = new System.Windows.Forms.Button();
            this.TestLabel = new System.Windows.Forms.Label();
            this.AppStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartKeyloggerButton
            // 
            this.StartKeyloggerButton.Location = new System.Drawing.Point(84, 228);
            this.StartKeyloggerButton.Name = "StartKeyloggerButton";
            this.StartKeyloggerButton.Size = new System.Drawing.Size(75, 23);
            this.StartKeyloggerButton.TabIndex = 0;
            this.StartKeyloggerButton.Text = "Start";
            this.StartKeyloggerButton.UseVisualStyleBackColor = true;
            this.StartKeyloggerButton.Click += new System.EventHandler(this.StartKeyloggerButton_Click);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(202, 236);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(69, 15);
            this.TestLabel.TabIndex = 1;
            this.TestLabel.Text = "Current Key";
            // 
            // AppStatusLabel
            // 
            this.AppStatusLabel.AutoSize = true;
            this.AppStatusLabel.Location = new System.Drawing.Point(225, 102);
            this.AppStatusLabel.Name = "AppStatusLabel";
            this.AppStatusLabel.Size = new System.Drawing.Size(38, 15);
            this.AppStatusLabel.TabIndex = 2;
            this.AppStatusLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 393);
            this.Controls.Add(this.AppStatusLabel);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.StartKeyloggerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartKeyloggerButton;
        private Label TestLabel;
        private Label AppStatusLabel;
    }
}