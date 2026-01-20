using System.Drawing;

namespace ProjectTimeCalculator
{
    partial class ProjectCalculator
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
            this.BtnsBox = new System.Windows.Forms.GroupBox();
            this.EmployeeProjectsData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectDateFormat = new System.Windows.Forms.Button();
            this.LoadCSVFile = new System.Windows.Forms.Button();
            this.BtnsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnsBox
            // 
            this.BtnsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.BtnsBox.Controls.Add(this.SelectDateFormat);
            this.BtnsBox.Controls.Add(this.LoadCSVFile);
            this.BtnsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsBox.Location = new System.Drawing.Point(4, 3);
            this.BtnsBox.Margin = new System.Windows.Forms.Padding(4);
            this.BtnsBox.Name = "BtnsBox";
            this.BtnsBox.Padding = new System.Windows.Forms.Padding(0);
            this.BtnsBox.Size = new System.Drawing.Size(201, 671);
            this.BtnsBox.TabIndex = 0;
            this.BtnsBox.TabStop = false;
            // 
            // EmployeeProjectsData
            // 
            this.EmployeeProjectsData.AllowUserToAddRows = false;
            this.EmployeeProjectsData.AllowUserToDeleteRows = false;
            this.EmployeeProjectsData.AllowUserToOrderColumns = true;
            this.EmployeeProjectsData.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeProjectsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeProjectsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeProjectsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeProjectsData.GridColor = System.Drawing.Color.White;
            this.EmployeeProjectsData.Location = new System.Drawing.Point(213, 52);
            this.EmployeeProjectsData.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeProjectsData.Name = "EmployeeProjectsData";
            this.EmployeeProjectsData.RowHeadersVisible = false;
            this.EmployeeProjectsData.RowHeadersWidth = 51;
            this.EmployeeProjectsData.RowTemplate.Height = 24;
            this.EmployeeProjectsData.Size = new System.Drawing.Size(826, 626);
            this.EmployeeProjectsData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Projects Development Time";
            // 
            // SelectDateFormat
            // 
            this.SelectDateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.SelectDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectDateFormat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDateFormat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectDateFormat.Image = global::ProjectTimeCalculator.Properties.Resources.Settings;
            this.SelectDateFormat.Location = new System.Drawing.Point(6, 70);
            this.SelectDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.SelectDateFormat.Name = "SelectDateFormat";
            this.SelectDateFormat.Size = new System.Drawing.Size(191, 51);
            this.SelectDateFormat.TabIndex = 1;
            this.SelectDateFormat.Text = "Select Date Format";
            this.SelectDateFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectDateFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectDateFormat.UseVisualStyleBackColor = false;
            this.SelectDateFormat.Click += new System.EventHandler(this.SelectDateFormat_Click);
            // 
            // LoadCSVFile
            // 
            this.LoadCSVFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.LoadCSVFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadCSVFile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCSVFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadCSVFile.Image = global::ProjectTimeCalculator.Properties.Resources.XLSGlassLgo;
            this.LoadCSVFile.Location = new System.Drawing.Point(6, 11);
            this.LoadCSVFile.Margin = new System.Windows.Forms.Padding(4);
            this.LoadCSVFile.Name = "LoadCSVFile";
            this.LoadCSVFile.Size = new System.Drawing.Size(191, 51);
            this.LoadCSVFile.TabIndex = 0;
            this.LoadCSVFile.Text = "Load CSV";
            this.LoadCSVFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadCSVFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadCSVFile.UseVisualStyleBackColor = false;
            this.LoadCSVFile.Click += new System.EventHandler(this.LoadCSVFile_Click);
            // 
            // ProjectCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeProjectsData);
            this.Controls.Add(this.BtnsBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project calculator";
            this.BtnsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BtnsBox;
        private System.Windows.Forms.Button LoadCSVFile;
        private System.Windows.Forms.DataGridView EmployeeProjectsData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectDateFormat;
    }
}

