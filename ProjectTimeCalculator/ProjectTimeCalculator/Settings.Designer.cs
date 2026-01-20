using System.Drawing;

namespace ProjectTimeCalculator
{
    partial class Settings
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
            this.SelectDateFormat = new System.Windows.Forms.Button();
            this.EmployeeProjectsData = new System.Windows.Forms.DataGridView();
            this.DateFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnsBox
            // 
            this.BtnsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.BtnsBox.Controls.Add(this.SelectDateFormat);
            this.BtnsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsBox.Location = new System.Drawing.Point(4, 3);
            this.BtnsBox.Margin = new System.Windows.Forms.Padding(4);
            this.BtnsBox.Name = "BtnsBox";
            this.BtnsBox.Padding = new System.Windows.Forms.Padding(0);
            this.BtnsBox.Size = new System.Drawing.Size(201, 671);
            this.BtnsBox.TabIndex = 0;
            this.BtnsBox.TabStop = false;
            // 
            // SelectDateFormat
            // 
            this.SelectDateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.SelectDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectDateFormat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDateFormat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectDateFormat.Image = global::ProjectTimeCalculator.Properties.Resources.XLSGlassLgo;
            this.SelectDateFormat.Location = new System.Drawing.Point(6, 11);
            this.SelectDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.SelectDateFormat.Name = "SelectDateFormat";
            this.SelectDateFormat.Size = new System.Drawing.Size(191, 51);
            this.SelectDateFormat.TabIndex = 0;
            this.SelectDateFormat.Text = "Select";
            this.SelectDateFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectDateFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectDateFormat.UseVisualStyleBackColor = false;
            this.SelectDateFormat.Click += new System.EventHandler(this.SelectDateFormat_Click);
            // 
            // EmployeeProjectsData
            // 
            this.EmployeeProjectsData.AllowUserToAddRows = false;
            this.EmployeeProjectsData.AllowUserToDeleteRows = false;
            this.EmployeeProjectsData.AllowUserToOrderColumns = true;
            this.EmployeeProjectsData.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeProjectsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeProjectsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeProjectsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateFormat});
            this.EmployeeProjectsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeProjectsData.GridColor = System.Drawing.Color.White;
            this.EmployeeProjectsData.Location = new System.Drawing.Point(213, 3);
            this.EmployeeProjectsData.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeProjectsData.Name = "EmployeeProjectsData";
            this.EmployeeProjectsData.RowHeadersVisible = false;
            this.EmployeeProjectsData.RowHeadersWidth = 51;
            this.EmployeeProjectsData.RowTemplate.Height = 24;
            this.EmployeeProjectsData.Size = new System.Drawing.Size(261, 675);
            this.EmployeeProjectsData.TabIndex = 1;
            this.EmployeeProjectsData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeProjectsData_CellContentDoubleClick);
            // 
            // DateFormat
            // 
            this.DateFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateFormat.HeaderText = "Date Format";
            this.DateFormat.MinimumWidth = 6;
            this.DateFormat.Name = "DateFormat";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 680);
            this.Controls.Add(this.EmployeeProjectsData);
            this.Controls.Add(this.BtnsBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.BtnsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BtnsBox;
        private System.Windows.Forms.Button SelectDateFormat;
        private System.Windows.Forms.DataGridView EmployeeProjectsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFormat;
    }
}

