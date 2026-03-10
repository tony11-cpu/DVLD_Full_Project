namespace MyDVLD_PeresentationTier.People_FRMs.People_Controls
{
    partial class ctrlShowPersonDetailsWithSearch
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
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.btnAddNewpersonAndReturnAfterAdding = new System.Windows.Forms.Button();
            this.btnSearchForFillteredPerson = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFillterData = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlShowPersonDetails1 = new MyDVLD_PeresentationTier.ctrlShowPersonDetails();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.btnAddNewpersonAndReturnAfterAdding);
            this.gbFillter.Controls.Add(this.btnSearchForFillteredPerson);
            this.gbFillter.Controls.Add(this.tbFilterValue);
            this.gbFillter.Controls.Add(this.cbFillterData);
            this.gbFillter.Controls.Add(this.label1);
            this.gbFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFillter.ForeColor = System.Drawing.Color.White;
            this.gbFillter.Location = new System.Drawing.Point(3, 8);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(1330, 128);
            this.gbFillter.TabIndex = 1;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Filter";
            // 
            // btnAddNewpersonAndReturnAfterAdding
            // 
            this.btnAddNewpersonAndReturnAfterAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewpersonAndReturnAfterAdding.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewpersonAndReturnAfterAdding.FlatAppearance.BorderSize = 3;
            this.btnAddNewpersonAndReturnAfterAdding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAddNewpersonAndReturnAfterAdding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewpersonAndReturnAfterAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewpersonAndReturnAfterAdding.Image = global::MyDVLD_PeresentationTier.Properties.Resources.Add_Person_40;
            this.btnAddNewpersonAndReturnAfterAdding.Location = new System.Drawing.Point(1131, 38);
            this.btnAddNewpersonAndReturnAfterAdding.Name = "btnAddNewpersonAndReturnAfterAdding";
            this.btnAddNewpersonAndReturnAfterAdding.Size = new System.Drawing.Size(87, 73);
            this.btnAddNewpersonAndReturnAfterAdding.TabIndex = 4;
            this.btnAddNewpersonAndReturnAfterAdding.UseVisualStyleBackColor = false;
            this.btnAddNewpersonAndReturnAfterAdding.Click += new System.EventHandler(this.btnAddNewpersonAndReturnAfterAdding_Click);
            // 
            // btnSearchForFillteredPerson
            // 
            this.btnSearchForFillteredPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchForFillteredPerson.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchForFillteredPerson.FlatAppearance.BorderSize = 3;
            this.btnSearchForFillteredPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSearchForFillteredPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchForFillteredPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForFillteredPerson.Image = global::MyDVLD_PeresentationTier.Properties.Resources.SearchPerson;
            this.btnSearchForFillteredPerson.Location = new System.Drawing.Point(1038, 38);
            this.btnSearchForFillteredPerson.Name = "btnSearchForFillteredPerson";
            this.btnSearchForFillteredPerson.Size = new System.Drawing.Size(87, 73);
            this.btnSearchForFillteredPerson.TabIndex = 3;
            this.btnSearchForFillteredPerson.UseVisualStyleBackColor = false;
            this.btnSearchForFillteredPerson.Click += new System.EventHandler(this.btnSearchForFillteredPerson_Click);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.BackColor = System.Drawing.Color.Silver;
            this.tbFilterValue.Location = new System.Drawing.Point(571, 60);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(386, 39);
            this.tbFilterValue.TabIndex = 2;
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cbFillterData
            // 
            this.cbFillterData.BackColor = System.Drawing.Color.Silver;
            this.cbFillterData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillterData.FormattingEnabled = true;
            this.cbFillterData.Items.AddRange(new object[] {
            "Person Id",
            "National Number"});
            this.cbFillterData.Location = new System.Drawing.Point(199, 58);
            this.cbFillterData.Name = "cbFillterData";
            this.cbFillterData.Size = new System.Drawing.Size(359, 40);
            this.cbFillterData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(3, 152);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(1330, 715);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlShowPersonDetailsWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.gbFillter);
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Name = "ctrlShowPersonDetailsWithSearch";
            this.Size = new System.Drawing.Size(1334, 871);
            this.Load += new System.EventHandler(this.ctrlShowPersonDetailsWithSearch_Load);
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.GroupBox gbFillter;
        private System.Windows.Forms.Button btnAddNewpersonAndReturnAfterAdding;
        private System.Windows.Forms.Button btnSearchForFillteredPerson;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cbFillterData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
