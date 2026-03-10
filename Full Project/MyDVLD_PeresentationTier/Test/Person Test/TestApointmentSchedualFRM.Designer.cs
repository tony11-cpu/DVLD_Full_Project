namespace MyDVLD_PeresentationTier.Test.Person_Test
{
    partial class TestApointmentSchedualFRM
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
            this.lblTestAppointmentName = new System.Windows.Forms.Label();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfVisionAppointments = new System.Windows.Forms.Label();
            this.btnAddVisionTestAppointemnt = new System.Windows.Forms.Button();
            this.btnCloseFRM = new System.Windows.Forms.Button();
            this.pbTestPicture = new System.Windows.Forms.PictureBox();
            this.ctrlShowLocalApplicationDetails1 = new MyDVLD_PeresentationTier.Applications.Application_User_CTRL.ctrlShowLocalApplicationDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestAppointmentName
            // 
            this.lblTestAppointmentName.AutoSize = true;
            this.lblTestAppointmentName.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.lblTestAppointmentName.ForeColor = System.Drawing.Color.Aqua;
            this.lblTestAppointmentName.Location = new System.Drawing.Point(357, 197);
            this.lblTestAppointmentName.Name = "lblTestAppointmentName";
            this.lblTestAppointmentName.Size = new System.Drawing.Size(670, 57);
            this.lblTestAppointmentName.TabIndex = 1;
            this.lblTestAppointmentName.Text = "Vision Test Appointment";
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            this.dgvTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestAppointments.Location = new System.Drawing.Point(27, 1073);
            this.dgvTestAppointments.MultiSelect = false;
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestAppointments.RowHeadersWidth = 62;
            this.dgvTestAppointments.RowTemplate.Height = 28;
            this.dgvTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestAppointments.Size = new System.Drawing.Size(1375, 273);
            this.dgvTestAppointments.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 1436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 10);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(33, 1024);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Appointments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(35, 1378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number Of Appointments:";
            // 
            // lblNumberOfVisionAppointments
            // 
            this.lblNumberOfVisionAppointments.AutoSize = true;
            this.lblNumberOfVisionAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfVisionAppointments.ForeColor = System.Drawing.Color.Aqua;
            this.lblNumberOfVisionAppointments.Location = new System.Drawing.Point(405, 1378);
            this.lblNumberOfVisionAppointments.Name = "lblNumberOfVisionAppointments";
            this.lblNumberOfVisionAppointments.Size = new System.Drawing.Size(48, 32);
            this.lblNumberOfVisionAppointments.TabIndex = 24;
            this.lblNumberOfVisionAppointments.Text = "00";
            // 
            // btnAddVisionTestAppointemnt
            // 
            this.btnAddVisionTestAppointemnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddVisionTestAppointemnt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddVisionTestAppointemnt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddVisionTestAppointemnt.FlatAppearance.BorderSize = 3;
            this.btnAddVisionTestAppointemnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAddVisionTestAppointemnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddVisionTestAppointemnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVisionTestAppointemnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVisionTestAppointemnt.Image = global::MyDVLD_PeresentationTier.Properties.Resources.AddAppointment_32;
            this.btnAddVisionTestAppointemnt.Location = new System.Drawing.Point(1314, 999);
            this.btnAddVisionTestAppointemnt.Name = "btnAddVisionTestAppointemnt";
            this.btnAddVisionTestAppointemnt.Size = new System.Drawing.Size(88, 67);
            this.btnAddVisionTestAppointemnt.TabIndex = 25;
            this.btnAddVisionTestAppointemnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddVisionTestAppointemnt.UseVisualStyleBackColor = false;
            this.btnAddVisionTestAppointemnt.Click += new System.EventHandler(this.btnAddTestAppointemnt_Click);
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
            this.btnCloseFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFRM.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Close_32;
            this.btnCloseFRM.Location = new System.Drawing.Point(1250, 1352);
            this.btnCloseFRM.Name = "btnCloseFRM";
            this.btnCloseFRM.Size = new System.Drawing.Size(152, 67);
            this.btnCloseFRM.TabIndex = 21;
            this.btnCloseFRM.Text = "Close";
            this.btnCloseFRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFRM.UseVisualStyleBackColor = false;
            this.btnCloseFRM.Click += new System.EventHandler(this.btnCloseFRM_Click);
            // 
            // pbTestPicture
            // 
            this.pbTestPicture.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Vision_512;
            this.pbTestPicture.Location = new System.Drawing.Point(566, 12);
            this.pbTestPicture.Name = "pbTestPicture";
            this.pbTestPicture.Size = new System.Drawing.Size(285, 182);
            this.pbTestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestPicture.TabIndex = 2;
            this.pbTestPicture.TabStop = false;
            // 
            // ctrlShowLocalApplicationDetails1
            // 
            this.ctrlShowLocalApplicationDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowLocalApplicationDetails1.Location = new System.Drawing.Point(-2, 297);
            this.ctrlShowLocalApplicationDetails1.Name = "ctrlShowLocalApplicationDetails1";
            this.ctrlShowLocalApplicationDetails1.Size = new System.Drawing.Size(1404, 696);
            this.ctrlShowLocalApplicationDetails1.TabIndex = 0;
            // 
            // TestApointmentSchedualFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1411, 1447);
            this.Controls.Add(this.btnAddVisionTestAppointemnt);
            this.Controls.Add(this.lblNumberOfVisionAppointments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseFRM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.pbTestPicture);
            this.Controls.Add(this.lblTestAppointmentName);
            this.Controls.Add(this.ctrlShowLocalApplicationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestApointmentSchedualFRM";
            this.Text = "Vision Test Appointment";
            this.Load += new System.EventHandler(this.TestApointmentSchedualFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Application_User_CTRL.ctrlShowLocalApplicationDetails ctrlShowLocalApplicationDetails1;
        private System.Windows.Forms.Label lblTestAppointmentName;
        private System.Windows.Forms.PictureBox pbTestPicture;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseFRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfVisionAppointments;
        private System.Windows.Forms.Button btnAddVisionTestAppointemnt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}