using MyDVLD_BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Application_Types
{
    public partial class ManageApplicationTypesFRM : Form
    {
        public ManageApplicationTypesFRM()
        {
            InitializeComponent();
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => this.Close();

        private void ManageApplicationTypesFRM_Load(object sender, EventArgs e)
        {
            dgvManageAppTypes.DataSource = clsApplicationTypeManagement.GetAllAppTypesData();
            lblNumberOfApplications.Text = dgvManageAppTypes.Rows.Count.ToString();

            dgvManageAppTypes.Columns[0].HeaderText = "ID";
            dgvManageAppTypes.Columns[0].Width = 130;

            dgvManageAppTypes.Columns[1].HeaderText = "Title";
            dgvManageAppTypes.Columns[1].Width = 270;

            dgvManageAppTypes.Columns[2].HeaderText = "Fees";
            dgvManageAppTypes.Columns[2].Width = 150;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationFRM editApplication = new EditApplicationFRM((int)dgvManageAppTypes.CurrentRow.Cells[0].Value);
            editApplication.ShowDialog();

            ManageApplicationTypesFRM_Load(null,null);
        }
    }
}
