namespace POCAPP
{
    partial class ConnectionForm
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
            this.XConnectButton = new System.Windows.Forms.Button();
            this.XConnectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XConnectButton
            // 
            this.XConnectButton.Location = new System.Drawing.Point(166, 103);
            this.XConnectButton.Name = "XConnectButton";
            this.XConnectButton.Size = new System.Drawing.Size(75, 23);
            this.XConnectButton.TabIndex = 0;
            this.XConnectButton.Text = "Connect";
            this.XConnectButton.UseVisualStyleBackColor = true;
            this.XConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // XConnectLabel
            // 
            this.XConnectLabel.AutoSize = true;
            this.XConnectLabel.Location = new System.Drawing.Point(12, 58);
            this.XConnectLabel.Name = "XConnectLabel";
            this.XConnectLabel.Size = new System.Drawing.Size(386, 13);
            this.XConnectLabel.TabIndex = 1;
            this.XConnectLabel.Text = "Would you like to connect to the POC COVID database for Langston University?";
            this.XConnectLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(402, 176);
            this.Controls.Add(this.XConnectLabel);
            this.Controls.Add(this.XConnectButton);
            this.Name = "ConnectionForm";
            this.Text = "POC COVID Connect";
            //this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XConnectButton;
        private System.Windows.Forms.Label XConnectLabel;
    }
}

