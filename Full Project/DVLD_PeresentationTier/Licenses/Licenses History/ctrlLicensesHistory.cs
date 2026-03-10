using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses.Licenses_CTRL
{
    public partial class ctrlLicensesHistory : UserControl
    {
        public ctrlLicensesHistory()
        {
            InitializeComponent();
        }

        private clsDriversManagement _DriverInfo = clsDriversManagement.Find(-1);

        public void LoadLicensesHistory(int DriverID)
        {
            tbcLicenses.SelectedIndex = 0;
            _DriverInfo = clsDriversManagement.Find(DriverID); 

            if(_DriverInfo.DriverID == null)
            {
                MessageBox.Show("Driver Information Not Found.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicenseDGV();
            _LoadInternationalLicenseDGV();
        }

        private void _LoadLocalLicenseDGV()
        {
            dgvLocalLicensesHistory.DataSource = clsDriversManagement.GetAllLocalLicensesInfoByDriverID(_DriverInfo.DriverID ?? -1);
            lblNumberOfLocalLicenses.Text = dgvLocalLicensesHistory.RowCount.ToString();

            dgvLocalLicensesHistory.Columns[0].HeaderText = "Licnese ID";
            dgvLocalLicensesHistory.Columns[0].Width = 90;

            dgvLocalLicensesHistory.Columns[1].HeaderText = "App ID";
            dgvLocalLicensesHistory.Columns[1].Width = 90;

            dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
            dgvLocalLicensesHistory.Columns[2].Width = 260;

            dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
            dgvLocalLicensesHistory.Columns[3].Width = 180;

            dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
            dgvLocalLicensesHistory.Columns[4].Width = 180;

            dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
            dgvLocalLicensesHistory.Columns[5].Width = 60;
        }

        private void _LoadInternationalLicenseDGV()
        {
            dgvInternationalLicenses.DataSource = clsDriversManagement.GetAllInternationalLicensesInfoByDriverID(_DriverInfo.DriverID ?? -1);
            lblNumberOfInternationalLicenses.Text = dgvInternationalLicenses.RowCount.ToString();

            dgvInternationalLicenses.Columns[0].HeaderText = "Licnese ID";
            dgvInternationalLicenses.Columns[0].Width = 90;

            dgvInternationalLicenses.Columns[1].HeaderText = "App ID";
            dgvInternationalLicenses.Columns[1].Width = 90;

            dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
            dgvInternationalLicenses.Columns[2].Width = 90;

            dgvInternationalLicenses.Columns[3].HeaderText = "LDL.ID";
            dgvInternationalLicenses.Columns[3].Width = 90;

            dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
            dgvInternationalLicenses.Columns[4].Width = 140;

            dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
            dgvInternationalLicenses.Columns[5].Width = 140;

            dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
            dgvInternationalLicenses.Columns[6].Width = 60;

            dgvInternationalLicenses.Columns[7].HeaderText = "Created By User ID";
            dgvInternationalLicenses.Columns[7].Width = 150;
        }

        private void OnContextMenuLocalLicenses_Opening(object sender, EventArgs e)
        { 
            if (dgvLocalLicensesHistory.RowCount <= 0 || dgvLocalLicensesHistory == null)
                cmsLocalLicenseInfo.Enabled = false;

            if (dgvInternationalLicenses.RowCount <= 0 || dgvInternationalLicenses == null)
                cmsInternationalLicenseInfo.Enabled = false;
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLocalLicenseInfoFRM LocalLicenseInfo = new ShowLocalLicenseInfoFRM((int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value);
            LocalLicenseInfo.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseInfoFRM showInternational = new ShowInternationalLicenseInfoFRM((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            showInternational.ShowDialog();
        }
    }
}
