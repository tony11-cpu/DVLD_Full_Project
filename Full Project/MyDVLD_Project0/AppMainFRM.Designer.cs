namespace MyDVLD_Project0
{
    partial class AppMainFRM
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
            this.msMainMenuView = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSytingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuView.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuView
            // 
            this.msMainMenuView.BackColor = System.Drawing.Color.White;
            this.msMainMenuView.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenuView.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMainMenuView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainMenuView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSytingsToolStripMenuItem});
            this.msMainMenuView.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuView.Name = "msMainMenuView";
            this.msMainMenuView.Size = new System.Drawing.Size(1904, 65);
            this.msMainMenuView.TabIndex = 0;
            this.msMainMenuView.Text = "Main Menu";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(385, 61);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(221, 61);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(250, 61);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(194, 61);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // accountSytingsToolStripMenuItem
            // 
            this.accountSytingsToolStripMenuItem.Name = "accountSytingsToolStripMenuItem";
            this.accountSytingsToolStripMenuItem.Size = new System.Drawing.Size(499, 61);
            this.accountSytingsToolStripMenuItem.Text = "Account Settings";
            // 
            // AppMainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1143);
            this.Controls.Add(this.msMainMenuView);
            this.Name = "AppMainFRM";
            this.Text = "AppMainFRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppMainFRM_Load);
            this.msMainMenuView.ResumeLayout(false);
            this.msMainMenuView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenuView;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSytingsToolStripMenuItem;
    }
}