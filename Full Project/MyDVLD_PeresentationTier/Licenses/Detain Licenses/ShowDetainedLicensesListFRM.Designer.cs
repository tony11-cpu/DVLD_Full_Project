namespace MyDVLD_PeresentationTier.Licenses.Detain_Licenses
{
    partial class ShowDetainedLicensesListFRM
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
            this.lblNumberOfDetainedLicenses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFillterValue = new System.Windows.Forms.TextBox();
            this.cbFillterOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetainedLicensesManagment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseDetainedLicenseToolStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReleasebtnDetainLicense = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesManagment)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfDetainedLicenses
            // 
            this.lblNumberOfDetainedLicenses.AutoSize = true;
            this.lblNumberOfDetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDetainedLicenses.ForeColor = System.Drawing.Color.Aqua;
            this.lblNumberOfDetainedLicenses.Location = new System.Drawing.Point(663, 1073);
            this.lblNumberOfDetainedLicenses.Name = "lblNumberOfDetainedLicenses";
            this.lblNumberOfDetainedLicenses.Size = new System.Drawing.Size(59, 40);
            this.lblNumberOfDetainedLicenses.TabIndex = 42;
            this.lblNumberOfDetainedLicenses.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(107, 1073);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 40);
            this.label3.TabIndex = 41;
            this.label3.Text = "# Number Of Detained Licnese:";
            // 
            // tbFillterValue
            // 
            this.tbFillterValue.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFillterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFillterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFillterValue.Location = new System.Drawing.Point(561, 475);
            this.tbFillterValue.Name = "tbFillterValue";
            this.tbFillterValue.Size = new System.Drawing.Size(299, 39);
            this.tbFillterValue.TabIndex = 40;
            this.tbFillterValue.Visible = false;
            this.tbFillterValue.TextChanged += new System.EventHandler(this.tbFillterValue_TextChanged);
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
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cbFillterOptions.Location = new System.Drawing.Point(165, 474);
            this.cbFillterOptions.Name = "cbFillterOptions";
            this.cbFillterOptions.Size = new System.Drawing.Size(390, 40);
            this.cbFillterOptions.TabIndex = 39;
            this.cbFillterOptions.SelectedIndexChanged += new System.EventHandler(this.cbFillterOptions_SelectedIndexChanged);
            this.cbFillterOptions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFillterOptions_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(10, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(684, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 57);
            this.label1.TabIndex = 37;
            this.label1.Text = "List Detained Licenses";
            // 
            // dgvDetainedLicensesManagment
            // 
            this.dgvDetainedLicensesManagment.AllowUserToAddRows = false;
            this.dgvDetainedLicensesManagment.AllowUserToDeleteRows = false;
            this.dgvDetainedLicensesManagment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetainedLicensesManagment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicensesManagment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicensesManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicensesManagment.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicensesManagment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicensesManagment.Location = new System.Drawing.Point(4, 532);
            this.dgvDetainedLicensesManagment.MultiSelect = false;
            this.dgvDetainedLicensesManagment.Name = "dgvDetainedLicensesManagment";
            this.dgvDetainedLicensesManagment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicensesManagment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicensesManagment.RowHeadersWidth = 62;
            this.dgvDetainedLicensesManagment.RowTemplate.Height = 28;
            this.dgvDetainedLicensesManagment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicensesManagment.Size = new System.Drawing.Size(1916, 511);
            this.dgvDetainedLicensesManagment.TabIndex = 36;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showLicenseInToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.ReleaseDetainedLicenseToolStripe});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(326, 182);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // showPerToolStripMenuItem
            // 
            this.showPerToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonDetails_32;
            this.showPerToolStripMenuItem.Name = "showPerToolStripMenuItem";
            this.showPerToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPerToolStripMenuItem.Text = "Show Person Info";
            this.showPerToolStripMenuItem.Click += new System.EventHandler(this.showPerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(322, 6);
            // 
            // showLicenseInToolStripMenuItem
            // 
            this.showLicenseInToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_View_32;
            this.showLicenseInToolStripMenuItem.Name = "showLicenseInToolStripMenuItem";
            this.showLicenseInToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showLicenseInToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(322, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(322, 6);
            // 
            // ReleaseDetainedLicenseToolStripe
            // 
            this.ReleaseDetainedLicenseToolStripe.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Release_Detained_License_32;
            this.ReleaseDetainedLicenseToolStripe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetainedLicenseToolStripe.Name = "ReleaseDetainedLicenseToolStripe";
            this.ReleaseDetainedLicenseToolStripe.Size = new System.Drawing.Size(325, 40);
            this.ReleaseDetainedLicenseToolStripe.Text = "Release Detained License";
            this.ReleaseDetainedLicenseToolStripe.Click += new System.EventHandler(this.ReleaseDetainedLicenseToolStripe_Click);
            // 
            // btnReleasebtnDetainLicense
            // 
            this.btnReleasebtnDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReleasebtnDetainLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReleasebtnDetainLicense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReleasebtnDetainLicense.FlatAppearance.BorderSize = 3;
            this.btnReleasebtnDetainLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReleasebtnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleasebtnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleasebtnDetainLicense.ForeColor = System.Drawing.Color.Black;
            this.btnReleasebtnDetainLicense.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Release_Detained_License_64;
            this.btnReleasebtnDetainLicense.Location = new System.Drawing.Point(1662, 406);
            this.btnReleasebtnDetainLicense.Name = "btnReleasebtnDetainLicense";
            this.btnReleasebtnDetainLicense.Size = new System.Drawing.Size(126, 120);
            this.btnReleasebtnDetainLicense.TabIndex = 47;
            this.btnReleasebtnDetainLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReleasebtnDetainLicense.UseVisualStyleBackColor = false;
            this.btnReleasebtnDetainLicense.Click += new System.EventHandler(this.btnReleasebtnDetainLicense_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDetainLicense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetainLicense.FlatAppearance.BorderSize = 3;
            this.btnDetainLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicense.ForeColor = System.Drawing.Color.Black;
            this.btnDetainLicense.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Detain_64;
            this.btnDetainLicense.Location = new System.Drawing.Point(1794, 406);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(126, 120);
            this.btnDetainLicense.TabIndex = 45;
            this.btnDetainLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Count_32;
            this.pictureBox1.Location = new System.Drawing.Point(42, 1049);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
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
            this.btnCloseFRM.Location = new System.Drawing.Point(1794, 1050);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(126, 120);
            this.btnCloseFRM.TabIndex = 43;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Detain_512;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(763, 23);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(490, 298);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 35;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(561, 477);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(161, 37);
            this.cbIsReleased.TabIndex = 160;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // ShowDetainedLicensesListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 1182);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.btnReleasebtnDetainLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.lblNumberOfDetainedLicenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFillterValue);
            this.Controls.Add(this.cbFillterOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetainedLicensesManagment);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowDetainedLicensesListFRM";
            this.Text = "Show Detained Licenses List";
            this.Load += new System.EventHandler(this.ShowDetainedLicensesListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesManagment)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label lblNumberOfDetainedLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFillterValue;
        private System.Windows.Forms.ComboBox cbFillterOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetainedLicensesManagment;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
        private System.Windows.Forms.Button btnReleasebtnDetainLicense;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.ToolStripMenuItem showPerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedLicenseToolStripe;
    }
}