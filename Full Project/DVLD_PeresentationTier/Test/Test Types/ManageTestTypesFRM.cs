using MyDVLD_BusinessTier;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Test_Types
{
    public partial class ManageTestTypesFRM : Form
    {
        public ManageTestTypesFRM()
        {
            InitializeComponent();
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => Close();

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            dgvManageTestTypes.DataSource = clsTestTypesManagement.GetAllTestTypes();
            lblNumberOfTests.Text = dgvManageTestTypes.Rows.Count.ToString();

            dgvManageTestTypes.Columns[0].HeaderText = "ID";
            dgvManageTestTypes.Columns[0].Width = 130;

            dgvManageTestTypes.Columns[1].HeaderText = "Title";
            dgvManageTestTypes.Columns[1].Width = 140;

            dgvManageTestTypes.Columns[2].HeaderText = "Description";
            dgvManageTestTypes.Columns[2].Width = 350;

            dgvManageTestTypes.Columns[3].HeaderText = "Fees";
            dgvManageTestTypes.Columns[3].Width = 130;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypeFRM editTest = new EditTestTypeFRM((int)dgvManageTestTypes.CurrentRow.Cells[0].Value);
            editTest.ShowDialog();

            ManageTestTypes_Load(null , null);
        }
    }
}
