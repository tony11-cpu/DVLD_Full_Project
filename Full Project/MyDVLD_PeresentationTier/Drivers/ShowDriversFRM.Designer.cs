namespace MyDVLD_PeresentationTier.Drivers
{
    partial class ShowDriversFRM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumberOfDrivers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFillterValue = new System.Windows.Forms.TextBox();
            this.cbFillterOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDriverManagment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverManagment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfDrivers
            // 
            this.lblNumberOfDrivers.AutoSize = true;
            this.lblNumberOfDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDrivers.ForeColor = System.Drawing.Color.Aqua;
            this.lblNumberOfDrivers.Location = new System.Drawing.Point(498, 1073);
            this.lblNumberOfDrivers.Name = "lblNumberOfDrivers";
            this.lblNumberOfDrivers.Size = new System.Drawing.Size(59, 40);
            this.lblNumberOfDrivers.TabIndex = 19;
            this.lblNumberOfDrivers.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(115, 1073);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Number Of Drivers:";
            // 
            // tbFillterValue
            // 
            this.tbFillterValue.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFillterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFillterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFillterValue.Location = new System.Drawing.Point(495, 475);
            this.tbFillterValue.Name = "tbFillterValue";
            this.tbFillterValue.Size = new System.Drawing.Size(299, 39);
            this.tbFillterValue.TabIndex = 17;
            this.tbFillterValue.Visible = false;
            this.tbFillterValue.TextChanged += new System.EventHandler(this.tbFillterValue_TextChanged);
            this.tbFillterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFillterValue_KeyPress);
            // 
            // cbFillterOptions
            // 
            this.cbFillterOptions.BackColor = System.Drawing.Color.Gainsboro;
            this.cbFillterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillterOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFillterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFillterOptions.FormattingEnabled = true;
            this.cbFillterOptions.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
            this.cbFillterOptions.Location = new System.Drawing.Point(173, 474);
            this.cbFillterOptions.Name = "cbFillterOptions";
            this.cbFillterOptions.Size = new System.Drawing.Size(316, 40);
            this.cbFillterOptions.TabIndex = 16;
            this.cbFillterOptions.SelectedIndexChanged += new System.EventHandler(this.cbFillterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(18, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(441, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Drivers";
            // 
            // dgvDriverManagment
            // 
            this.dgvDriverManagment.AllowUserToAddRows = false;
            this.dgvDriverManagment.AllowUserToDeleteRows = false;
            this.dgvDriverManagment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDriverManagment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriverManagment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDriverManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverManagment.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDriverManagment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDriverManagment.Location = new System.Drawing.Point(12, 532);
            this.dgvDriverManagment.MultiSelect = false;
            this.dgvDriverManagment.Name = "dgvDriverManagment";
            this.dgvDriverManagment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriverManagment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDriverManagment.RowHeadersWidth = 62;
            this.dgvDriverManagment.RowTemplate.Height = 28;
            this.dgvDriverManagment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriverManagment.Size = new System.Drawing.Size(1348, 511);
            this.dgvDriverManagment.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(318, 74);
            // 
            // showPerToolStripMenuItem
            // 
            this.showPerToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonDetails_32;
            this.showPerToolStripMenuItem.Name = "showPerToolStripMenuItem";
            this.showPerToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPerToolStripMenuItem.Text = "Show Person Info";
            this.showPerToolStripMenuItem.Click += new System.EventHandler(this.showPerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(314, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Count_32;
            this.pictureBox1.Location = new System.Drawing.Point(50, 1049);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseFRM
            // 
            this.btnCloseFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCloseFRM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseFRM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseFRM.FlatAppearance.BorderSize = 3;
            this.btnCloseFRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnCloseFRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCloseFRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFRM.Image = global::MyDVLD_PeresentationTier.Properties.Resources.cross_64;
            this.btnCloseFRM.Location = new System.Drawing.Point(1226, 1049);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(134, 120);
            this.btnCloseFRM.TabIndex = 20;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Driver_Main;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(447, 12);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(435, 337);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 11;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // ShowDriversFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1372, 1178);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.lblNumberOfDrivers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFillterValue);
            this.Controls.Add(this.cbFillterOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDriverManagment);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowDriversFRM";
            this.Text = "Show Drivers";
            this.Load += new System.EventHandler(this.ShowDriversFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverManagment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label lblNumberOfDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFillterValue;
        private System.Windows.Forms.ComboBox cbFillterOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDriverManagment;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}