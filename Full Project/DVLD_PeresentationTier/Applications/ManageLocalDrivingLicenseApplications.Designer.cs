namespace MyDVLD_PeresentationTier.Applications.Manage_Applications
{
    partial class ManageLocalDrivingLicenseApplications
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
            this.lblNumberOfApps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbFillterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalApplicationsManagment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.squToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfillter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.btnAddApplicaiton = new System.Windows.Forms.Button();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDriverLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplicationsManagment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfApps
            // 
            this.lblNumberOfApps.AutoSize = true;
            this.lblNumberOfApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfApps.ForeColor = System.Drawing.Color.Aqua;
            this.lblNumberOfApps.Location = new System.Drawing.Point(534, 1172);
            this.lblNumberOfApps.Name = "lblNumberOfApps";
            this.lblNumberOfApps.Size = new System.Drawing.Size(59, 40);
            this.lblNumberOfApps.TabIndex = 19;
            this.lblNumberOfApps.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(66, 1172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Number Of Applications:";
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(495, 485);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(299, 39);
            this.txtFilterBy.TabIndex = 17;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbFillterBy
            // 
            this.cbFillterBy.BackColor = System.Drawing.Color.Gainsboro;
            this.cbFillterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFillterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFillterBy.FormattingEnabled = true;
            this.cbFillterBy.Items.AddRange(new object[] {
            "None",
            "National No.",
            "L.D.L AppID",
            "Full Name",
            "Status"});
            this.cbFillterBy.Location = new System.Drawing.Point(173, 484);
            this.cbFillterBy.Name = "cbFillterBy";
            this.cbFillterBy.Size = new System.Drawing.Size(316, 40);
            this.cbFillterBy.TabIndex = 16;
            this.cbFillterBy.SelectedIndexChanged += new System.EventHandler(this.cbFillterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(-157, 411);
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
            this.label1.Location = new System.Drawing.Point(427, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(949, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "Local Driving LIcense Applications";
            // 
            // dgvLocalApplicationsManagment
            // 
            this.dgvLocalApplicationsManagment.AllowUserToAddRows = false;
            this.dgvLocalApplicationsManagment.AllowUserToDeleteRows = false;
            this.dgvLocalApplicationsManagment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLocalApplicationsManagment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalApplicationsManagment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalApplicationsManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalApplicationsManagment.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalApplicationsManagment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalApplicationsManagment.Location = new System.Drawing.Point(6, 541);
            this.dgvLocalApplicationsManagment.MultiSelect = false;
            this.dgvLocalApplicationsManagment.Name = "dgvLocalApplicationsManagment";
            this.dgvLocalApplicationsManagment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalApplicationsManagment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalApplicationsManagment.RowHeadersWidth = 62;
            this.dgvLocalApplicationsManagment.RowTemplate.Height = 28;
            this.dgvLocalApplicationsManagment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalApplicationsManagment.Size = new System.Drawing.Size(1702, 588);
            this.dgvLocalApplicationsManagment.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.editApplicationsToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cancelApplicationToolStripMenuItem,
            this.squToolStripMenuItem,
            this.sechduleTestToolStripMenuItem,
            this.toolStripMenuItem2,
            this.issueDriverLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(337, 329);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 6);
            // 
            // squToolStripMenuItem
            // 
            this.squToolStripMenuItem.Name = "squToolStripMenuItem";
            this.squToolStripMenuItem.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(333, 6);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(25, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filter By:";
            // 
            // btnfillter
            // 
            this.btnfillter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfillter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnfillter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfillter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfillter.FlatAppearance.BorderSize = 3;
            this.btnfillter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnfillter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnfillter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillter.Location = new System.Drawing.Point(800, 481);
            this.btnfillter.Name = "btnfillter";
            this.btnfillter.Size = new System.Drawing.Size(105, 51);
            this.btnfillter.TabIndex = 23;
            this.btnfillter.Text = "Search";
            this.btnfillter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfillter.UseVisualStyleBackColor = false;
            this.btnfillter.Visible = false;
            this.btnfillter.Click += new System.EventHandler(this.btnfillter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Count_32;
            this.pictureBox1.Location = new System.Drawing.Point(-125, 983);
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
            this.btnCloseFRM.Location = new System.Drawing.Point(1574, 1135);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(134, 120);
            this.btnCloseFRM.TabIndex = 20;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click_1);
            // 
            // btnAddApplicaiton
            // 
            this.btnAddApplicaiton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddApplicaiton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddApplicaiton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddApplicaiton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddApplicaiton.FlatAppearance.BorderSize = 3;
            this.btnAddApplicaiton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAddApplicaiton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddApplicaiton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApplicaiton.Image = global::MyDVLD_PeresentationTier.Properties.Resources.New_Application_64;
            this.btnAddApplicaiton.Location = new System.Drawing.Point(1534, 415);
            this.btnAddApplicaiton.Name = "btnAddApplicaiton";
            this.btnAddApplicaiton.Size = new System.Drawing.Size(174, 117);
            this.btnAddApplicaiton.TabIndex = 14;
            this.btnAddApplicaiton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddApplicaiton.UseVisualStyleBackColor = false;
            this.btnAddApplicaiton.Click += new System.EventHandler(this.btnAddApplicaiton_Click);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationsToolStripMenuItem
            // 
            this.editApplicationsToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.edit_32;
            this.editApplicationsToolStripMenuItem.Name = "editApplicationsToolStripMenuItem";
            this.editApplicationsToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.editApplicationsToolStripMenuItem.Text = "Edit Applications";
            this.editApplicationsToolStripMenuItem.Click += new System.EventHandler(this.editApplicationsToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schdualVisionTestToolStripMenuItem,
            this.schedualWrittenTestToolStripMenuItem,
            this.schedualStreetTestToolStripMenuItem});
            this.sechduleTestToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.TestType_512;
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.sechduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // schdualVisionTestToolStripMenuItem
            // 
            this.schdualVisionTestToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Vision_Test_32;
            this.schdualVisionTestToolStripMenuItem.Name = "schdualVisionTestToolStripMenuItem";
            this.schdualVisionTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.schdualVisionTestToolStripMenuItem.Tag = "VisionTest";
            this.schdualVisionTestToolStripMenuItem.Text = "Schedual Vision Test";
            this.schdualVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schdualTestToolStripMenuItem_Click);
            // 
            // schedualWrittenTestToolStripMenuItem
            // 
            this.schedualWrittenTestToolStripMenuItem.Enabled = false;
            this.schedualWrittenTestToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Written_Test_512;
            this.schedualWrittenTestToolStripMenuItem.Name = "schedualWrittenTestToolStripMenuItem";
            this.schedualWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.schedualWrittenTestToolStripMenuItem.Tag = "WrittenTest";
            this.schedualWrittenTestToolStripMenuItem.Text = "Schedual Written Test";
            this.schedualWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.schdualTestToolStripMenuItem_Click);
            // 
            // schedualStreetTestToolStripMenuItem
            // 
            this.schedualStreetTestToolStripMenuItem.Enabled = false;
            this.schedualStreetTestToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Street_Test_32;
            this.schedualStreetTestToolStripMenuItem.Name = "schedualStreetTestToolStripMenuItem";
            this.schedualStreetTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.schedualStreetTestToolStripMenuItem.Tag = "StreetTest";
            this.schedualStreetTestToolStripMenuItem.Text = "Schedual Street Test";
            this.schedualStreetTestToolStripMenuItem.Click += new System.EventHandler(this.schdualTestToolStripMenuItem_Click);
            // 
            // issueDriverLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.IssueDrivingLicense_32;
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Name = "issueDriverLicenseFirstTimeToolStripMenuItem";
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Text = "Issue Driver License (First Time)";
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDriverLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Enabled = false;
            this.showToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_View_32;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.showToolStripMenuItem.Text = "Show License";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Manage_Applications_64;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(657, 27);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(435, 269);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 11;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // ManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1720, 1267);
            this.Controls.Add(this.btnfillter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.lblNumberOfApps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFillterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddApplicaiton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLocalApplicationsManagment);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageLocalDrivingLicenseApplications";
            this.Text = "Manage Local Driving License Applications";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplicationsManagment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label lblNumberOfApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbFillterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddApplicaiton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalApplicationsManagment;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator squToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schdualVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem issueDriverLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Button btnfillter;
    }
}