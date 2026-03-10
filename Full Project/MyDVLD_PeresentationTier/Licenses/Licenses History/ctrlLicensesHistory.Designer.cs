namespace MyDVLD_PeresentationTier.Licenses.Licenses_CTRL
{
    partial class ctrlLicensesHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcLicenses = new System.Windows.Forms.TabControl();
            this.tbLocalLicense = new System.Windows.Forms.TabPage();
            this.lblLocalLicenseHistory = new System.Windows.Forms.Label();
            this.lblNumberOfLocalLicenses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInternationalLicenses = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfInternationalLicenses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcLicenses.SuspendLayout();
            this.tbLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.cmsLocalLicenseInfo.SuspendLayout();
            this.tbInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcLicenses
            // 
            this.tbcLicenses.Controls.Add(this.tbLocalLicense);
            this.tbcLicenses.Controls.Add(this.tbInternationalLicenses);
            this.tbcLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcLicenses.Location = new System.Drawing.Point(3, 3);
            this.tbcLicenses.Name = "tbcLicenses";
            this.tbcLicenses.SelectedIndex = 0;
            this.tbcLicenses.Size = new System.Drawing.Size(1316, 386);
            this.tbcLicenses.TabIndex = 25;
            // 
            // tbLocalLicense
            // 
            this.tbLocalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLocalLicense.Controls.Add(this.lblLocalLicenseHistory);
            this.tbLocalLicense.Controls.Add(this.lblNumberOfLocalLicenses);
            this.tbLocalLicense.Controls.Add(this.label3);
            this.tbLocalLicense.Controls.Add(this.dgvLocalLicensesHistory);
            this.tbLocalLicense.Location = new System.Drawing.Point(4, 34);
            this.tbLocalLicense.Name = "tbLocalLicense";
            this.tbLocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocalLicense.Size = new System.Drawing.Size(1308, 348);
            this.tbLocalLicense.TabIndex = 0;
            this.tbLocalLicense.Text = "Local";
            // 
            // lblLocalLicenseHistory
            // 
            this.lblLocalLicenseHistory.AutoSize = true;
            this.lblLocalLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLocalLicenseHistory.Location = new System.Drawing.Point(14, 12);
            this.lblLocalLicenseHistory.Name = "lblLocalLicenseHistory";
            this.lblLocalLicenseHistory.Size = new System.Drawing.Size(267, 26);
            this.lblLocalLicenseHistory.TabIndex = 25;
            this.lblLocalLicenseHistory.Text = "# Local License History:";
            // 
            // lblNumberOfLocalLicenses
            // 
            this.lblNumberOfLocalLicenses.AutoSize = true;
            this.lblNumberOfLocalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLocalLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumberOfLocalLicenses.Location = new System.Drawing.Point(276, 305);
            this.lblNumberOfLocalLicenses.Name = "lblNumberOfLocalLicenses";
            this.lblNumberOfLocalLicenses.Size = new System.Drawing.Size(38, 26);
            this.lblNumberOfLocalLicenses.TabIndex = 24;
            this.lblNumberOfLocalLicenses.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(14, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "# Number Of Licenses:";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.cmsLocalLicenseInfo;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(6, 53);
            this.dgvLocalLicensesHistory.MultiSelect = false;
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 62;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 28;
            this.dgvLocalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1296, 240);
            this.dgvLocalLicensesHistory.TabIndex = 0;
            // 
            // cmsLocalLicenseInfo
            // 
            this.cmsLocalLicenseInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLocalLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenseInfo.Name = "cmsLocalLicenseInfo";
            this.cmsLocalLicenseInfo.Size = new System.Drawing.Size(249, 69);
            this.cmsLocalLicenseInfo.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuLocalLicenses_Opening);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_Type_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tbInternationalLicenses
            // 
            this.tbInternationalLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbInternationalLicenses.Controls.Add(this.label1);
            this.tbInternationalLicenses.Controls.Add(this.lblNumberOfInternationalLicenses);
            this.tbInternationalLicenses.Controls.Add(this.label4);
            this.tbInternationalLicenses.Controls.Add(this.dgvInternationalLicenses);
            this.tbInternationalLicenses.Location = new System.Drawing.Point(4, 34);
            this.tbInternationalLicenses.Name = "tbInternationalLicenses";
            this.tbInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternationalLicenses.Size = new System.Drawing.Size(1308, 348);
            this.tbInternationalLicenses.TabIndex = 1;
            this.tbInternationalLicenses.Text = "International";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "# International License History:";
            // 
            // lblNumberOfInternationalLicenses
            // 
            this.lblNumberOfInternationalLicenses.AutoSize = true;
            this.lblNumberOfInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInternationalLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumberOfInternationalLicenses.Location = new System.Drawing.Point(278, 304);
            this.lblNumberOfInternationalLicenses.Name = "lblNumberOfInternationalLicenses";
            this.lblNumberOfInternationalLicenses.Size = new System.Drawing.Size(38, 26);
            this.lblNumberOfInternationalLicenses.TabIndex = 26;
            this.lblNumberOfInternationalLicenses.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(16, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "# Number Of Licenses:";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicenseInfo;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 56);
            this.dgvInternationalLicenses.MultiSelect = false;
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidth = 62;
            this.dgvInternationalLicenses.RowTemplate.Height = 28;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1299, 236);
            this.dgvInternationalLicenses.TabIndex = 1;
            // 
            // cmsInternationalLicenseInfo
            // 
            this.cmsInternationalLicenseInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsInternationalLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem1});
            this.cmsInternationalLicenseInfo.Name = "cmsInternationalLicenseInfo";
            this.cmsInternationalLicenseInfo.Size = new System.Drawing.Size(235, 36);
            this.cmsInternationalLicenseInfo.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuLocalLicenses_Opening);
            // 
            // showLicenseInfoToolStripMenuItem1
            // 
            this.showLicenseInfoToolStripMenuItem1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_Type_32;
            this.showLicenseInfoToolStripMenuItem1.Name = "showLicenseInfoToolStripMenuItem1";
            this.showLicenseInfoToolStripMenuItem1.Size = new System.Drawing.Size(234, 32);
            this.showLicenseInfoToolStripMenuItem1.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem1.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem1_Click);
            // 
            // ctrlLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tbcLicenses);
            this.Name = "ctrlLicensesHistory";
            this.Size = new System.Drawing.Size(1322, 392);
            this.tbcLicenses.ResumeLayout(false);
            this.tbLocalLicense.ResumeLayout(false);
            this.tbLocalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.cmsLocalLicenseInfo.ResumeLayout(false);
            this.tbInternationalLicenses.ResumeLayout(false);
            this.tbInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalLicenseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcLicenses;
        private System.Windows.Forms.TabPage tbLocalLicense;
        private System.Windows.Forms.Label lblNumberOfLocalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.TabPage tbInternationalLicenses;
        private System.Windows.Forms.Label lblNumberOfInternationalLicenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblLocalLicenseHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem1;
    }
}
