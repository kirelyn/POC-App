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
            this.pbLogo.Location = new System.Drawing.Point(10, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblUniv
            // 
            this.lblUniv.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniv.Location = new System.Drawing.Point(116, 11);
            this.lblUniv.Name = "lblUniv";
            this.lblUniv.Size = new System.Drawing.Size(360, 100);
            this.lblUniv.TabIndex = 2;
            this.lblUniv.Text = "Langston University";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(194, 136);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(194, 27);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Enter Student ID: ";
            // 
            // TBStudentID
            // 
            this.TBStudentID.Location = new System.Drawing.Point(379, 142);
            this.TBStudentID.Name = "TBStudentID";
            this.TBStudentID.Size = new System.Drawing.Size(193, 20);
            this.TBStudentID.TabIndex = 4;
            // 
            // btnIdEnter
            // 
            this.btnIdEnter.Location = new System.Drawing.Point(578, 140);
            this.btnIdEnter.Name = "btnIdEnter";
            this.btnIdEnter.Size = new System.Drawing.Size(75, 23);
            this.btnIdEnter.TabIndex = 5;
            this.btnIdEnter.Text = "Enter";
            this.btnIdEnter.UseVisualStyleBackColor = true;
            this.btnIdEnter.Click += new System.EventHandler(this.btnIdEnter_Click);
            // 
            // DGVDataTable
            // 
            this.DGVDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDataTable.Location = new System.Drawing.Point(10, 170);
            this.DGVDataTable.Name = "DGVDataTable";
            this.DGVDataTable.RowHeadersWidth = 51;
            this.DGVDataTable.Size = new System.Drawing.Size(817, 380);
            this.DGVDataTable.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 561);
            this.Controls.Add(this.DGVDataTable);
            this.Controls.Add(this.btnIdEnter);
            this.Controls.Add(this.TBStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblUniv);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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