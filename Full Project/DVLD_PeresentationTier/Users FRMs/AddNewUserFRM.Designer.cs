namespace MyDVLD_PeresentationTier.Users_FRMs
{
    partial class AddNewUserFRM
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
            this.pUserInfo = new System.Windows.Forms.Panel();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.rbIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblAddNewUserUI = new System.Windows.Forms.Label();
            this.AddNewUserTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextFRM = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlShowPersonDetailsWithSearch1 = new MyDVLD_PeresentationTier.People_FRMs.People_Controls.ctrlShowPersonDetailsWithSearch();
            this.pUserInfo.SuspendLayout();
            this.AddNewUserTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pUserInfo
            // 
            this.pUserInfo.Controls.Add(this.tbConfirmPassword);
            this.pUserInfo.Controls.Add(this.rbIsActiveCheckBox);
            this.pUserInfo.Controls.Add(this.tbPassword);
            this.pUserInfo.Controls.Add(this.tbUsername);
            this.pUserInfo.Enabled = false;
            this.pUserInfo.Location = new System.Drawing.Point(504, 222);
            this.pUserInfo.Name = "pUserInfo";
            this.pUserInfo.Size = new System.Drawing.Size(502, 349);
            this.pUserInfo.TabIndex = 14;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(14, 218);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(429, 48);
            this.tbConfirmPassword.TabIndex = 7;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // rbIsActiveCheckBox
            // 
            this.rbIsActiveCheckBox.AutoSize = true;
            this.rbIsActiveCheckBox.Checked = true;
            this.rbIsActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbIsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIsActiveCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbIsActiveCheckBox.Location = new System.Drawing.Point(19, 304);
            this.rbIsActiveCheckBox.Name = "rbIsActiveCheckBox";
            this.rbIsActiveCheckBox.Size = new System.Drawing.Size(155, 36);
            this.rbIsActiveCheckBox.TabIndex = 8;
            this.rbIsActiveCheckBox.Text = "Is Active";
            this.rbIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(10, 120);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(429, 48);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(10, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(429, 48);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // lblAddNewUserUI
            // 
            this.lblAddNewUserUI.AutoSize = true;
            this.lblAddNewUserUI.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Bold);
            this.lblAddNewUserUI.ForeColor = System.Drawing.Color.Aqua;
            this.lblAddNewUserUI.Location = new System.Drawing.Point(420, 160);
            this.lblAddNewUserUI.Name = "lblAddNewUserUI";
            this.lblAddNewUserUI.Size = new System.Drawing.Size(434, 67);
            this.lblAddNewUserUI.TabIndex = 1;
            this.lblAddNewUserUI.Text = "Add New User";
            // 
            // AddNewUserTabControl
            // 
            this.AddNewUserTabControl.Controls.Add(this.tabPage1);
            this.AddNewUserTabControl.Controls.Add(this.tpLoginInfo);
            this.AddNewUserTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUserTabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.AddNewUserTabControl.Location = new System.Drawing.Point(12, 253);
            this.AddNewUserTabControl.Multiline = true;
            this.AddNewUserTabControl.Name = "AddNewUserTabControl";
            this.AddNewUserTabControl.SelectedIndex = 0;
            this.AddNewUserTabControl.Size = new System.Drawing.Size(1348, 1017);
            this.AddNewUserTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.ctrlShowPersonDetailsWithSearch1);
            this.tabPage1.Controls.Add(this.btnNextFRM);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 975);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            // 
            // btnNextFRM
            // 
            this.btnNextFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNextFRM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextFRM.FlatAppearance.BorderSize = 3;
            this.btnNextFRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNextFRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFRM.ForeColor = System.Drawing.Color.Black;
            this.btnNextFRM.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Next_32;
            this.btnNextFRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextFRM.Location = new System.Drawing.Point(1099, 885);
            this.btnNextFRM.Name = "btnNextFRM";
            this.btnNextFRM.Size = new System.Drawing.Size(149, 71);
            this.btnNextFRM.TabIndex = 2;
            this.btnNextFRM.Text = "Next";
            this.btnNextFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextFRM.UseVisualStyleBackColor = false;
            this.btnNextFRM.Click += new System.EventHandler(this.btnNextFRM_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpLoginInfo.Controls.Add(this.pUserInfo);
            this.tpLoginInfo.Controls.Add(this.pictureBox5);
            this.tpLoginInfo.Controls.Add(this.pictureBox4);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.pictureBox2);
            this.tpLoginInfo.Controls.Add(this.lblUserId);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.label5);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 38);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1340, 975);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(427, 138);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Password_32;
            this.pictureBox4.Location = new System.Drawing.Point(441, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(441, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(248, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Id:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(441, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserId.Location = new System.Drawing.Point(500, 138);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 52);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(190, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 52);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(200, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(26, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnCloseFRM.Location = new System.Drawing.Point(1009, 1286);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(149, 92);
            this.btnCloseFRM.TabIndex = 5;
            this.btnCloseFRM.Text = "Close";
            this.btnCloseFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveUser.Enabled = false;
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveUser.FlatAppearance.BorderSize = 3;
            this.btnSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUser.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Save_32;
            this.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Location = new System.Drawing.Point(1187, 1286);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(149, 92);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Add_New_User_72;
            this.pictureBox1.Location = new System.Drawing.Point(422, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 8);
            this.panel1.TabIndex = 7;
            // 
            // ctrlShowPersonDetailsWithSearch1
            // 
            this.ctrlShowPersonDetailsWithSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowPersonDetailsWithSearch1.FilterEnabled = true;
            this.ctrlShowPersonDetailsWithSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShowPersonDetailsWithSearch1.Location = new System.Drawing.Point(5, 7);
            this.ctrlShowPersonDetailsWithSearch1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlShowPersonDetailsWithSearch1.Name = "ctrlShowPersonDetailsWithSearch1";
            this.ctrlShowPersonDetailsWithSearch1.PersonId = -1;
            this.ctrlShowPersonDetailsWithSearch1.Size = new System.Drawing.Size(1334, 871);
            this.ctrlShowPersonDetailsWithSearch1.TabIndex = 3;
            this.ctrlShowPersonDetailsWithSearch1.OnPersonSelected += new System.EventHandler<int>(this.ctrlShowPersonDetailsWithSearch1_OnPersonSelected);
            // 
            // AddNewUserFRM
            // 
            this.AcceptButton = this.btnSaveUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCloseFRM;
            this.ClientSize = new System.Drawing.Size(1370, 1393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.AddNewUserTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddNewUserUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewUserFRM";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddNewUserFRM_Load);
            this.pUserInfo.ResumeLayout(false);
            this.pUserInfo.PerformLayout();
            this.AddNewUserTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddNewUserUI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl AddNewUserTabControl;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbIsActiveCheckBox;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private People_FRMs.People_Controls.ctrlShowPersonDetailsWithSearch ctrlShowPersonDetailsWithSearch1;
        private System.Windows.Forms.Button btnNextFRM;
        private System.Windows.Forms.Panel pUserInfo;
    }
}