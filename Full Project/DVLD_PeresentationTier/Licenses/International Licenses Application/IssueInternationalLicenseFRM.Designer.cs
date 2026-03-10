namespace MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application
{
    partial class IssueInternationalLicenseFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblShowInternationalLicense = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ctrlShowLicenseWithDriverInfoWithFillter1 = new MyDVLD_PeresentationTier.Licenses.Licenses_CTRL.ctrlShowLicenseWithDriverInfoWithFillter();
            this.ctrlInternationalLicenseApplicationInfo1 = new MyDVLD_PeresentationTier.Licenses.Licenses_CTRL.ctrlInternationalLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(305, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "International License Application";
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLicenseHistory.Location = new System.Drawing.Point(28, 1327);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(433, 36);
            this.lblLicenseHistory.TabIndex = 19;
            this.lblLicenseHistory.TabStop = true;
            this.lblLicenseHistory.Text = "Show Person License History";
            this.lblLicenseHistory.Visible = false;
            this.lblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLicenseHistory_LinkClicked);
            // 
            // lblShowInternationalLicense
            // 
            this.lblShowInternationalLicense.AutoSize = true;
            this.lblShowInternationalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInternationalLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblShowInternationalLicense.Location = new System.Drawing.Point(476, 1327);
            this.lblShowInternationalLicense.Name = "lblShowInternationalLicense";
            this.lblShowInternationalLicense.Size = new System.Drawing.Size(214, 36);
            this.lblShowInternationalLicense.TabIndex = 20;
            this.lblShowInternationalLicense.TabStop = true;
            this.lblShowInternationalLicense.Text = "Show License";
            this.lblShowInternationalLicense.Visible = false;
            this.lblShowInternationalLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowInternationalLicense_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 8);
            this.panel1.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1077, 1315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 64);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIssue.FlatAppearance.BorderSize = 3;
            this.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::MyDVLD_PeresentationTier.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1250, 1315);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(156, 64);
            this.btnIssue.TabIndex = 21;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlShowLicenseWithDriverInfoWithFillter1
            // 
            this.ctrlShowLicenseWithDriverInfoWithFillter1.AutoSize = true;
            this.ctrlShowLicenseWithDriverInfoWithFillter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowLicenseWithDriverInfoWithFillter1.Location = new System.Drawing.Point(4, 120);
            this.ctrlShowLicenseWithDriverInfoWithFillter1.Name = "ctrlShowLicenseWithDriverInfoWithFillter1";
            this.ctrlShowLicenseWithDriverInfoWithFillter1.Size = new System.Drawing.Size(1415, 792);
            this.ctrlShowLicenseWithDriverInfoWithFillter1.TabIndex = 17;
            this.ctrlShowLicenseWithDriverInfoWithFillter1.OnLicenseSelected += new System.Action<int>(this.ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected_1);
            // 
            // ctrlInternationalLicenseApplicationInfo1
            // 
            this.ctrlInternationalLicenseApplicationInfo1.AutoSize = true;
            this.ctrlInternationalLicenseApplicationInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlInternationalLicenseApplicationInfo1.Location = new System.Drawing.Point(4, 911);
            this.ctrlInternationalLicenseApplicationInfo1.Name = "ctrlInternationalLicenseApplicationInfo1";
            this.ctrlInternationalLicenseApplicationInfo1.Size = new System.Drawing.Size(1417, 398);
            this.ctrlInternationalLicenseApplicationInfo1.TabIndex = 24;
            // 
            // IssueInternationalLicenseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1425, 1396);
            this.Controls.Add(this.ctrlInternationalLicenseApplicationInfo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblShowInternationalLicense);
            this.Controls.Add(this.lblLicenseHistory);
            this.Controls.Add(this.ctrlShowLicenseWithDriverInfoWithFillter1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IssueInternationalLicenseFRM";
            this.Text = "Issue International License";
            this.Load += new System.EventHandler(this.IssueInternationalLicenseFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Licenses_CTRL.ctrlShowLicenseWithDriverInfoWithFillter ctrlShowLicenseWithDriverInfoWithFillter1;
        private System.Windows.Forms.LinkLabel lblLicenseHistory;
        private System.Windows.Forms.LinkLabel lblShowInternationalLicense;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private Licenses.Licenses_CTRL.ctrlInternationalLicenseApplicationInfo ctrlInternationalLicenseApplicationInfo1;
    }
}