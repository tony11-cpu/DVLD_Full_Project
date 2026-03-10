namespace MyDVLD_PeresentationTier.Licenses
{
    partial class ShowLocalLicenseInfoFRM
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
            this.ctrlShowLicenseInfo1 = new MyDVLD_PeresentationTier.Licenses.ctrlLocalShowLicenseInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlShowLicenseInfo1
            // 
            this.ctrlShowLicenseInfo1.AutoSize = true;
            this.ctrlShowLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowLicenseInfo1.Location = new System.Drawing.Point(1, 268);
            this.ctrlShowLicenseInfo1.Name = "ctrlShowLicenseInfo1";
            this.ctrlShowLicenseInfo1.Size = new System.Drawing.Size(1412, 638);
            this.ctrlShowLicenseInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(436, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Driver License Info";
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.LicenseView_400;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(497, 12);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(397, 188);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 16;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // ShowLocalLicenseInfoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1421, 912);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.Controls.Add(this.ctrlShowLicenseInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowLocalLicenseInfoFRM";
            this.Text = "ShowLicenseInfoFRM";
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLocalShowLicenseInfo ctrlShowLicenseInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
    }
}