namespace POCAPP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblUniv = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.TBStudentID = new System.Windows.Forms.TextBox();
            this.btnIdEnter = new System.Windows.Forms.Button();
            this.DGVDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(13, 13);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(133, 123);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblUniv
            // 
            this.lblUniv.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniv.Location = new System.Drawing.Point(154, 13);
            this.lblUniv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniv.Name = "lblUniv";
            this.lblUniv.Size = new System.Drawing.Size(480, 123);
            this.lblUniv.TabIndex = 2;
            this.lblUniv.Text = "Langston University";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(259, 168);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(259, 33);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Enter Student ID: ";
            // 
            // TBStudentID
            // 
            this.TBStudentID.Location = new System.Drawing.Point(505, 175);
            this.TBStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.TBStudentID.Name = "TBStudentID";
            this.TBStudentID.Size = new System.Drawing.Size(256, 22);
            this.TBStudentID.TabIndex = 4;
            // 
            // btnIdEnter
            // 
            this.btnIdEnter.Location = new System.Drawing.Point(771, 172);
            this.btnIdEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdEnter.Name = "btnIdEnter";
            this.btnIdEnter.Size = new System.Drawing.Size(100, 28);
            this.btnIdEnter.TabIndex = 5;
            this.btnIdEnter.Text = "Enter";
            this.btnIdEnter.UseVisualStyleBackColor = true;
            // 
            // DGVDataTable
            // 
            this.DGVDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDataTable.Location = new System.Drawing.Point(13, 209);
            this.DGVDataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDataTable.Name = "DGVDataTable";
            this.DGVDataTable.RowHeadersWidth = 51;
            this.DGVDataTable.Size = new System.Drawing.Size(1089, 468);
            this.DGVDataTable.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 690);
            this.Controls.Add(this.DGVDataTable);
            this.Controls.Add(this.btnIdEnter);
            this.Controls.Add(this.TBStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblUniv);
            this.Controls.Add(this.pbLogo);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUniv;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox TBStudentID;
        private System.Windows.Forms.Button btnIdEnter;
        private System.Windows.Forms.DataGridView DGVDataTable;
    }
}