namespace MyDVLD_PeresentationTier.Licenses.Licenses_CTRL
{
    partial class ctrlShowLicenseWithDriverInfoWithFillter
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
            this.gbSearchForLicense = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlLocalShowLicenseInfo1 = new MyDVLD_PeresentationTier.Licenses.ctrlLocalShowLicenseInfo();
            this.gbSearchForLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchForLicense
            // 
            this.gbSearchForLicense.Controls.Add(this.btnSearch);
            this.gbSearchForLicense.Controls.Add(this.tbLicenseID);
            this.gbSearchForLicense.Controls.Add(this.label1);
            this.gbSearchForLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchForLicense.ForeColor = System.Drawing.Color.Aqua;
            this.gbSearchForLicense.Location = new System.Drawing.Point(9, 3);
            this.gbSearchForLicense.Name = "gbSearchForLicense";
            this.gbSearchForLicense.Size = new System.Drawing.Size(1002, 142);
            this.gbSearchForLicense.TabIndex = 0;
            this.gbSearchForLicense.TabStop = false;
            this.gbSearchForLicense.Text = "Search For License";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::MyDVLD_PeresentationTier.Properties.Resources.License_View_32;
            this.btnSearch.Location = new System.Drawing.Point(830, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 78);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicenseID.Location = new System.Drawing.Point(232, 57);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(561, 41);
            this.tbLicenseID.TabIndex = 1;
            this.tbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicenseID_KeyPress);
            this.tbLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.tbLicenseID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlLocalShowLicenseInfo1
            // 
            this.ctrlLocalShowLicenseInfo1.AutoSize = true;
            this.ctrlLocalShowLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlLocalShowLicenseInfo1.Location = new System.Drawing.Point(0, 151);
            this.ctrlLocalShowLicenseInfo1.Name = "ctrlLocalShowLicenseInfo1";
            this.ctrlLocalShowLicenseInfo1.Size = new System.Drawing.Size(1412, 638);
            this.ctrlLocalShowLicenseInfo1.TabIndex = 1;
            // 
            // ctrlShowLicenseWithDriverInfoWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ctrlLocalShowLicenseInfo1);
            this.Controls.Add(this.gbSearchForLicense);
            this.Name = "ctrlShowLicenseWithDriverInfoWithFillter";
            this.Size = new System.Drawing.Size(1415, 792);
            this.Load += new System.EventHandler(this.ctrlShowLicenseWithDriverInfo_Load);
            this.gbSearchForLicense.ResumeLayout(false);
            this.gbSearchForLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchForLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.Button btnSearch;
        private ctrlLocalShowLicenseInfo ctrlLocalShowLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
