namespace MyDVLD_PeresentationTier
{
    partial class UsersShowMainFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFillterOptions = new System.Windows.Forms.ComboBox();
            this.tbFillterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsersData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbUserActive = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(103, 894);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Users:";
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.ForeColor = System.Drawing.Color.Cyan;
            this.lblNumberOfUsers.Location = new System.Drawing.Point(348, 894);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(46, 32);
            this.lblNumberOfUsers.TabIndex = 3;
            this.lblNumberOfUsers.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(42, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fillter:";
            // 
            // cbFillterOptions
            // 
            this.cbFillterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFillterOptions.FormattingEnabled = true;
            this.cbFillterOptions.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFillterOptions.Location = new System.Drawing.Point(152, 337);
            this.cbFillterOptions.Name = "cbFillterOptions";
            this.cbFillterOptions.Size = new System.Drawing.Size(279, 40);
            this.cbFillterOptions.TabIndex = 6;
            this.cbFillterOptions.SelectedIndexChanged += new System.EventHandler(this.cbFillterOptions_SelectedIndexChanged);
            // 
            // tbFillterValue
            // 
            this.tbFillterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFillterValue.Location = new System.Drawing.Point(437, 338);
            this.tbFillterValue.Name = "tbFillterValue";
            this.tbFillterValue.Size = new System.Drawing.Size(279, 39);
            this.tbFillterValue.TabIndex = 7;
            this.tbFillterValue.Visible = false;
            this.tbFillterValue.TextChanged += new System.EventHandler(this.tbFillterValue_TextChanged);
            this.tbFillterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFillterValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(426, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 67);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Users";
            // 
            // dgvUsersData
            // 
            this.dgvUsersData.AllowUserToAddRows = false;
            this.dgvUsersData.AllowUserToDeleteRows = false;
            this.dgvUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsersData.Location = new System.Drawing.Point(12, 400);
            this.dgvUsersData.MultiSelect = false;
            this.dgvUsersData.Name = "dgvUsersData";
            this.dgvUsersData.ReadOnly = true;
            this.dgvUsersData.RowHeadersWidth = 62;
            this.dgvUsersData.RowTemplate.Height = 28;
            this.dgvUsersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersData.Size = new System.Drawing.Size(1296, 470);
            this.dgvUsersData.TabIndex = 11;
            this.dgvUsersData.DoubleClick += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AddToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.sendPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 240);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Users_2_64;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Add_New_User_32;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.AddToolStripMenuItem.Text = "Add New User";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Edit_User_32;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Delete_User_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // sendPasswordToolStripMenuItem
            // 
            this.sendPasswordToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.call_32;
            this.sendPasswordToolStripMenuItem.Name = "sendPasswordToolStripMenuItem";
            this.sendPasswordToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.sendPasswordToolStripMenuItem.Text = "Phone Call";
            this.sendPasswordToolStripMenuItem.Click += new System.EventHandler(this.sendPasswordToolStripMenuItem_Click);
            // 
            // cbUserActive
            // 
            this.cbUserActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserActive.FormattingEnabled = true;
            this.cbUserActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbUserActive.Location = new System.Drawing.Point(437, 337);
            this.cbUserActive.Name = "cbUserActive";
            this.cbUserActive.Size = new System.Drawing.Size(196, 40);
            this.cbUserActive.TabIndex = 12;
            this.cbUserActive.Visible = false;
            this.cbUserActive.SelectedIndexChanged += new System.EventHandler(this.cbUserActive_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Count_32;
            this.pictureBox2.Location = new System.Drawing.Point(39, 878);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddUser.FlatAppearance.BorderSize = 3;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Add_New_User_32;
            this.btnAddUser.Location = new System.Drawing.Point(1122, 326);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(186, 68);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.AddUser_Click);
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
            this.btnCloseFRM.Location = new System.Drawing.Point(1159, 876);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(149, 71);
            this.btnCloseFRM.TabIndex = 1;
            this.btnCloseFRM.Text = "Close";
            this.btnCloseFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // UsersShowMainFRM
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCloseFRM;
            this.ClientSize = new System.Drawing.Size(1320, 954);
            this.Controls.Add(this.cbUserActive);
            this.Controls.Add(this.dgvUsersData);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFillterValue);
            this.Controls.Add(this.cbFillterOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblNumberOfUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersShowMainFRM";
            this.Text = "UsersShowMainFRM";
            this.Load += new System.EventHandler(this.UsersShowMainFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFillterOptions;
        private System.Windows.Forms.TextBox tbFillterValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvUsersData;
        private System.Windows.Forms.ComboBox cbUserActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPasswordToolStripMenuItem;
    }
}