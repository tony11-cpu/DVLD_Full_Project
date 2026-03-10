namespace MyDVLD_PeresentationTier.Applications.Manage_Applications
{
    using MyDVLD_PeresentationTier.Applications.Application_User_CTRL;

    partial class LocalDrivingLicenseApplicationInfoFRM
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
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.ctrlShowLocalApplicationDetails1 = new MyDVLD_PeresentationTier.Applications.Application_User_CTRL.ctrlShowLocalApplicationDetails();
            this.SuspendLayout();
            // 
            // btnCloseFRM
            // 
            this.btnCloseFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCloseFRM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseFRM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseFRM.FlatAppearance.BorderSize = 3;
            this.btnCloseFRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCloseFRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFRM.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFRM.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Close_32;
            this.btnCloseFRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseFRM.Location = new System.Drawing.Point(1238, 691);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(165, 71);
            this.btnCloseFRM.TabIndex = 9;
            this.btnCloseFRM.Text = "Close";
            this.btnCloseFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // ctrlShowLocalApplicationDetails1
            // 
            this.ctrlShowLocalApplicationDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowLocalApplicationDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowLocalApplicationDetails1.Name = "ctrlShowLocalApplicationDetails1";
            this.ctrlShowLocalApplicationDetails1.Size = new System.Drawing.Size(1403, 696);
            this.ctrlShowLocalApplicationDetails1.TabIndex = 0;
            // 
            // LocalDrivingLicenseApplicationInfoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1409, 774);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.ctrlShowLocalApplicationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseApplicationInfoFRM";
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationInfoFRM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowLocalApplicationDetails ctrlShowLocalApplicationDetails1;
        private System.Windows.Forms.Button btnCloseFRM;
    }
}