namespace MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application
{
    partial class ShowAllInternationalLicensesesFRM
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
            this.lblNumberOfInternationalLicenses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFillterValue = new System.Windows.Forms.TextBox();
            this.cbFillterOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesManagment = new System.Windows.Forms.DataGridView();
            this.cbLicenseActive = new System.Windows.Forms.ComboBox();
            this.btnAddNewInternationalApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            this.showPerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesManagment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfInternationalLicenses
            // 
            this.lblNumberOfInternationalLicenses.AutoSize = true;
            this.lblNumberOfInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInternationalLicenses.ForeColor = System.Drawing.Color.Aqua;
            this.lblNumberOfInternationalLicenses.Location = new System.Drawing.Point(727, 1073);
            this.lblNumberOfInternationalLicenses.Name = "lblNumberOfInternationalLicenses";
            this.lblNumberOfInternationalLicenses.Size = new System.Drawing.Size(59, 40);
            this.lblNumberOfInternationalLicenses.TabIndex = 29;
            this.lblNumberOfInternationalLicenses.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(113, 1073);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "# Number Of International Licnese:";
            // 
            // tbFillterValue
            // 
            this.tbFillterValue.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFillterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFillterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFillterValue.Location = new System.Drawing.Point(567, 475);
            this.tbFillterValue.Name = "tbFillterValue";
            this.tbFillterValue.Size = new System.Drawing.Size(299, 39);
            this.tbFillterValue.TabIndex = 27;
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
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbFillterOptions.Location = new System.Drawing.Point(171, 474);
            this.cbFillterOptions.Name = "cbFillterOptions";
            this.cbFillterOptions.Size = new System.Drawing.Size(390, 40);
            this.cbFillterOptions.TabIndex = 26;
            this.cbFillterOptions.SelectedIndexChanged += new System.EventHandler(this.cbFillterOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(16, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(397, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 57);
            this.label1.TabIndex = 24;
            this.label1.Text = "International License Apllications";
            // 
            // dgvInternationalLicensesManagment
            // 
            this.dgvInternationalLicensesManagment.AllowUserToAddRows = false;
            this.dgvInternationalLicensesManagment.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensesManagment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInternationalLicensesManagment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicensesManagment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalLicensesManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesManagment.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicensesManagment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicensesManagment.Location = new System.Drawing.Point(10, 532);
            this.dgvInternationalLicensesManagment.MultiSelect = false;
            this.dgvInternationalLicensesManagment.Name = "dgvInternationalLicensesManagment";
            this.dgvInternationalLicensesManagment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicensesManagment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalLicensesManagment.RowHeadersWidth = 62;
            this.dgvInternationalLicensesManagment.RowTemplate.Height = 28;
            this.dgvInternationalLicensesManagment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicensesManagment.Size = new System.Drawing.Size(1681, 511);
            this.dgvInternationalLicensesManagment.TabIndex = 23;
            // 
            // cbLicenseActive
            // 
            this.cbLicenseActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseActive.FormattingEnabled = true;
            this.cbLicenseActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbLicenseActive.Location = new System.Drawing.Point(567, 474);
            this.cbLicenseActive.Name = "cbLicenseActive";
            this.cbLicenseActive.Size = new System.Drawing.Size(196, 40);
            this.cbLicenseActive.TabIndex = 34;
            this.cbLicenseActive.Visible = false;
            this.cbLicenseActive.SelectedIndexChanged += new System.EventHandler(this.cbLicenseActive_SelectedIndexChanged);
            // 
            // btnAddNewInternationalApplication
            // 
            this.btnAddNewInternationalApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewInternationalApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewInternationalApplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewInternationalApplication.FlatAppearance.BorderSize = 3;
            this.btnAddNewInternationalApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewInternationalApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInternationalApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewInternationalApplication.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewInternationalApplication.Image = global::MyDVLD_PeresentationTier.Properties.Resources.New_Application_641;
            this.btnAddNewInternationalApplication.Location = new System.Drawing.Point(1565, 406);
            this.btnAddNewInternationalApplication.Name = "btnAddNewInternationalApplication";
            this.btnAddNewInternationalApplication.Size = new System.Drawing.Size(126, 120);
            this.btnAddNewInternationalApplication.TabIndex = 33;
            this.btnAddNewInternationalApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewInternationalApplication.UseVisualStyleBackColor = false;
            this.btnAddNewInternationalApplication.Click += new System.EventHandler(this.btnAddNewInternationalApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Count_32;
            this.pictureBox1.Location = new System.Drawing.Point(48, 1049);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
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
            this.btnCloseFRM.Location = new System.Drawing.Point(1565, 1049);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(126, 120);
            this.btnCloseFRM.TabIndex = 30;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Manage_Applications_64;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(647, 12);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(435, 337);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 22;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // showPerToolStripMenuItem
            // 
            this.showPerToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonDetails_32;
            this.showPerToolStripMenuItem.Name = "showPerToolStripMenuItem";
            this.showPerToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPerToolStripMenuItem.Text = "Show Person Info";
            this.showPerToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(314, 6);
            // 
            // showLicenseInToolStripMenuItem
            // 
            this.showLicenseInToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_View_32;
            this.showLicenseInToolStripMenuItem.Name = "showLicenseInToolStripMenuItem";
            this.showLicenseInToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showLicenseInToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(314, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showLicenseInToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(318, 145);
            // 
            // ShowAllInternationalLicensesesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1698, 1176);
            this.Controls.Add(this.cbLicenseActive);
            this.Controls.Add(this.btnAddNewInternationalApplication);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.lblNumberOfInternationalLicenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFillterValue);
            this.Controls.Add(this.cbFillterOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInternationalLicensesManagment);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowAllInternationalLicensesesFRM";
            this.Text = "Show All International Licenses";
            this.Load += new System.EventHandler(this.ShowAllInternationalLicensesesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesManagment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label lblNumberOfInternationalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFillterValue;
        private System.Windows.Forms.ComboBox cbFillterOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesManagment;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
        private System.Windows.Forms.Button btnAddNewInternationalApplication;
        private System.Windows.Forms.ComboBox cbLicenseActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showPerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}