namespace MyDVLD_PeresentationTier.Application_Types
{
    partial class EditApplicationFRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApplicationTitle = new System.Windows.Forms.TextBox();
            this.tbApplicationFees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSavePersonInfo = new System.Windows.Forms.Button();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edit Application Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(68, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.Cyan;
            this.lblAppID.Location = new System.Drawing.Point(190, 130);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(43, 38);
            this.lblAppID.TabIndex = 5;
            this.lblAppID.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(40, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title:";
            // 
            // tbApplicationTitle
            // 
            this.tbApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplicationTitle.Location = new System.Drawing.Point(197, 192);
            this.tbApplicationTitle.Name = "tbApplicationTitle";
            this.tbApplicationTitle.Size = new System.Drawing.Size(392, 35);
            this.tbApplicationTitle.TabIndex = 7;
            this.tbApplicationTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationTitle_Validating);
            // 
            // tbApplicationFees
            // 
            this.tbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplicationFees.Location = new System.Drawing.Point(197, 259);
            this.tbApplicationFees.Name = "tbApplicationFees";
            this.tbApplicationFees.Size = new System.Drawing.Size(392, 35);
            this.tbApplicationFees.TabIndex = 9;
            this.tbApplicationFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationFees_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(40, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyDVLD_PeresentationTier.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(128, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLD_PeresentationTier.Properties.Resources.ApplicationTitle;
            this.pictureBox2.Location = new System.Drawing.Point(128, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(128, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSavePersonInfo
            // 
            this.btnSavePersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePersonInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSavePersonInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavePersonInfo.FlatAppearance.BorderSize = 3;
            this.btnSavePersonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSavePersonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePersonInfo.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Save_32;
            this.btnSavePersonInfo.Location = new System.Drawing.Point(373, 327);
            this.btnSavePersonInfo.Name = "btnSavePersonInfo";
            this.btnSavePersonInfo.Size = new System.Drawing.Size(133, 71);
            this.btnSavePersonInfo.TabIndex = 14;
            this.btnSavePersonInfo.Text = "Save";
            this.btnSavePersonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePersonInfo.UseVisualStyleBackColor = false;
            this.btnSavePersonInfo.Click += new System.EventHandler(this.btnSavePersonInfo_Click_1);
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
            this.btnCloseFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFRM.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Close_32;
            this.btnCloseFRM.Location = new System.Drawing.Point(521, 327);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(140, 71);
            this.btnCloseFRM.TabIndex = 13;
            this.btnCloseFRM.Text = "Close";
            this.btnCloseFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditApplicationFRM
            // 
            this.AcceptButton = this.btnSavePersonInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCloseFRM;
            this.ClientSize = new System.Drawing.Size(673, 411);
            this.Controls.Add(this.btnSavePersonInfo);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbApplicationFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbApplicationTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAppID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditApplicationFRM";
            this.Text = "Edit Application";
            this.Load += new System.EventHandler(this.EditApplicationFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApplicationTitle;
        private System.Windows.Forms.TextBox tbApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSavePersonInfo;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}