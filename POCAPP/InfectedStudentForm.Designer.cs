namespace POCAPP
{
    partial class XEnterId
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
            this.XStudentIDLabel = new System.Windows.Forms.Label();
            this.xFirstNameLabel = new System.Windows.Forms.Label();
            this.XLastNameLabel = new System.Windows.Forms.Label();
            this.XLastText = new System.Windows.Forms.TextBox();
            this.XFirstText = new System.Windows.Forms.TextBox();
            this.xStudentIdText = new System.Windows.Forms.TextBox();
            this.XSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XStudentIDLabel
            // 
            this.XStudentIDLabel.AutoSize = true;
            this.XStudentIDLabel.Location = new System.Drawing.Point(64, 49);
            this.XStudentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XStudentIDLabel.Name = "XStudentIDLabel";
            this.XStudentIDLabel.Size = new System.Drawing.Size(82, 17);
            this.XStudentIDLabel.TabIndex = 0;
            this.XStudentIDLabel.Text = "Student ID :";
            this.XStudentIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // xFirstNameLabel
            // 
            this.xFirstNameLabel.AutoSize = true;
            this.xFirstNameLabel.Location = new System.Drawing.Point(61, 85);
            this.xFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xFirstNameLabel.Name = "xFirstNameLabel";
            this.xFirstNameLabel.Size = new System.Drawing.Size(88, 17);
            this.xFirstNameLabel.TabIndex = 1;
            this.xFirstNameLabel.Text = "First Name : ";
            this.xFirstNameLabel.Click += new System.EventHandler(this.xFirstNameLabel_Click);
            // 
            // XLastNameLabel
            // 
            this.XLastNameLabel.AutoSize = true;
            this.XLastNameLabel.Location = new System.Drawing.Point(64, 129);
            this.XLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLastNameLabel.Name = "XLastNameLabel";
            this.XLastNameLabel.Size = new System.Drawing.Size(84, 17);
            this.XLastNameLabel.TabIndex = 2;
            this.XLastNameLabel.Text = "Last Name :";
            this.XLastNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // XLastText
            // 
            this.XLastText.Location = new System.Drawing.Point(157, 126);
            this.XLastText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XLastText.Name = "XLastText";
            this.XLastText.Size = new System.Drawing.Size(132, 22);
            this.XLastText.TabIndex = 3;
            // 
            // XFirstText
            // 
            this.XFirstText.Location = new System.Drawing.Point(157, 85);
            this.XFirstText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XFirstText.Name = "XFirstText";
            this.XFirstText.Size = new System.Drawing.Size(132, 22);
            this.XFirstText.TabIndex = 2;
            // 
            // xStudentIdText
            // 
            this.xStudentIdText.Location = new System.Drawing.Point(157, 46);
            this.xStudentIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xStudentIdText.Name = "xStudentIdText";
            this.xStudentIdText.Size = new System.Drawing.Size(132, 22);
            this.xStudentIdText.TabIndex = 1;
            // 
            // XSubmitButton
            // 
            this.XSubmitButton.Location = new System.Drawing.Point(157, 180);
            this.XSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XSubmitButton.Name = "XSubmitButton";
            this.XSubmitButton.Size = new System.Drawing.Size(100, 28);
            this.XSubmitButton.TabIndex = 4;
            this.XSubmitButton.Text = "Submit";
            this.XSubmitButton.UseVisualStyleBackColor = true;
            this.XSubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // XEnterId
            // 
            this.AcceptButton = this.XSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 236);
            this.Controls.Add(this.XSubmitButton);
            this.Controls.Add(this.xStudentIdText);
            this.Controls.Add(this.XFirstText);
            this.Controls.Add(this.XLastText);
            this.Controls.Add(this.XLastNameLabel);
            this.Controls.Add(this.xFirstNameLabel);
            this.Controls.Add(this.XStudentIDLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XEnterId";
            this.Text = "Infected Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XStudentIDLabel;
        private System.Windows.Forms.Label xFirstNameLabel;
        private System.Windows.Forms.Label XLastNameLabel;
        private System.Windows.Forms.TextBox XLastText;
        private System.Windows.Forms.TextBox XFirstText;
        private System.Windows.Forms.TextBox xStudentIdText;
        private System.Windows.Forms.Button XSubmitButton;
    }
}