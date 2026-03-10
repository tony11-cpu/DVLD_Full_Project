namespace MyDVLD_PeresentationTier.Licenses
{
    partial class ShowLicensesHistoryFRM
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
            this.pbManagePeopleIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlLicensesHistory1 = new MyDVLD_PeresentationTier.Licenses.Licenses_CTRL.ctrlLicensesHistory();
            this.ctrlShowPersonDetailsWithSearch1 = new MyDVLD_PeresentationTier.People_FRMs.People_Controls.ctrlShowPersonDetailsWithSearch();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(417, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "Licneses History";
            // 
            // pbManagePeopleIcon
            // 
            this.pbManagePeopleIcon.Image = global::MyDVLD_PeresentationTier.Properties.Resources.PersonLicenseHistory_512;
            this.pbManagePeopleIcon.Location = new System.Drawing.Point(440, 12);
            this.pbManagePeopleIcon.Name = "pbManagePeopleIcon";
            this.pbManagePeopleIcon.Size = new System.Drawing.Size(397, 161);
            this.pbManagePeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeopleIcon.TabIndex = 14;
            this.pbManagePeopleIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 8);
            this.panel1.TabIndex = 18;
            // 
            // ctrlLicensesHistory1
            // 
            this.ctrlLicensesHistory1.AutoSize = true;
            this.ctrlLicensesHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlLicensesHistory1.Location = new System.Drawing.Point(12, 1107);
            this.ctrlLicensesHistory1.Name = "ctrlLicensesHistory1";
            this.ctrlLicensesHistory1.Size = new System.Drawing.Size(1322, 392);
            this.ctrlLicensesHistory1.TabIndex = 19;
            // 
            // ctrlShowPersonDetailsWithSearch1
            // 
            this.ctrlShowPersonDetailsWithSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowPersonDetailsWithSearch1.FilterEnabled = true;
            this.ctrlShowPersonDetailsWithSearch1.Location = new System.Drawing.Point(1, 231);
            this.ctrlShowPersonDetailsWithSearch1.Name = "ctrlShowPersonDetailsWithSearch1";
            this.ctrlShowPersonDetailsWithSearch1.PersonId = -1;
            this.ctrlShowPersonDetailsWithSearch1.Size = new System.Drawing.Size(1334, 870);
            this.ctrlShowPersonDetailsWithSearch1.TabIndex = 16;
            // 
            // ShowLicensesHistoryFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1347, 1519);
            this.Controls.Add(this.ctrlLicensesHistory1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlShowPersonDetailsWithSearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbManagePeopleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowLicensesHistoryFRM";
            this.Text = "ShowLicensesHistoryFRM";
            this.Load += new System.EventHandler(this.ShowLicensesHistoryFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeopleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbManagePeopleIcon;
        private People_FRMs.People_Controls.ctrlShowPersonDetailsWithSearch ctrlShowPersonDetailsWithSearch1;
        private System.Windows.Forms.Panel panel1;
        private Licenses_CTRL.ctrlLicensesHistory ctrlLicensesHistory1;
    }
}