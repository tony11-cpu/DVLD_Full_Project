using MyDVLD_BusinessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application
{
    public partial class ShowAllInternationalLicensesesFRM : Form
    {
        public ShowAllInternationalLicensesesFRM() => InitializeComponent();

        private void btnCloseFRM_Click(object sender, EventArgs e) => this.Close();

        private DataTable _dtAllInternationalLicense = new DataTable();

        public static EventHandler LoadDataGridViewDelegate = null;

        private void ShowAllInternationalLicensesesFRM_Load(object sender, EventArgs e)
        {
            cbFillterOptions.SelectedIndex = 0;

            _dtAllInternationalLicense = clsInternationalLicenseManagement.GetAllInternationalLicenses();
            dgvInternationalLicensesManagment.DataSource = _dtAllInternationalLicense;

            dgvInternationalLicensesManagment.Columns[0].HeaderText = "Int. Licenses ID";
            dgvInternationalLicensesManagment.Columns[0].Width = 90;

            dgvInternationalLicensesManagment.Columns[1].HeaderText = "Application ID";
            dgvInternationalLicensesManagment.Columns[1].Width = 100;

            dgvInternationalLicensesManagment.Columns[2].HeaderText = "Driver ID";
            dgvInternationalLicensesManagment.Columns[2].Width = 120;

            dgvInternationalLicensesManagment.Columns[3].HeaderText = "L.License ID";
            dgvInternationalLicensesManagment.Columns[3].Width = 250;

            dgvInternationalLicensesManagment.Columns[4].HeaderText = "Issue Date";
            dgvInternationalLicensesManagment.Columns[4].Width = 150;

            dgvInternationalLicensesManagment.Columns[5].HeaderText = "Expiration Date";
            dgvInternationalLicensesManagment.Columns[5].Width = 120;

            dgvInternationalLicensesManagment.Columns[6].HeaderText = "Is Active";
            dgvInternationalLicensesManagment.Columns[6].Width = 100;

            dgvInternationalLicensesManagment.Columns[7].HeaderText = "Created By User ID";
            dgvInternationalLicensesManagment.Columns[7].Width = 120;

            lblNumberOfInternationalLicenses.Text = dgvInternationalLicensesManagment.RowCount.ToString();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPersonDetailsFRM ShowPersonDetails = new ShowPersonDetailsFRM(clsDriversManagement.Find((int)dgvInternationalLicensesManagment.CurrentRow.Cells[2].Value).Person.PersonID);
            ShowPersonDetails.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicensesHistoryFRM LicensesHistory = new ShowLicensesHistoryFRM(clsDriversManagement.Find((int)dgvInternationalLicensesManagment.CurrentRow.Cells[2].Value).Person.PersonID);
            LicensesHistory.ShowDialog();
        }

        private void showLicenseInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseInfoFRM InternationalLicenseInfo = new ShowInternationalLicenseInfoFRM((int)dgvInternationalLicensesManagment.CurrentRow.Cells[0].Value);
            InternationalLicenseInfo.ShowDialog();
        }

        private void btnAddNewInternationalApplication_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseFRM internationalLicenseFRM = new IssueInternationalLicenseFRM();
            LoadDataGridViewDelegate += ShowAllInternationalLicensesesFRM_Load;
            internationalLicenseFRM.Show();
        }

        private void tbFillterValue_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void cbLicenseActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbLicenseActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtAllInternationalLicense.DefaultView.RowFilter = "";
            else
                _dtAllInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblNumberOfInternationalLicenses.Text = dgvInternationalLicensesManagment.Rows.Count.ToString();
        }

        private void tbFillterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFillterOptions.Text)
            {
                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrEmpty(tbFillterValue.Text.Trim()) || FilterColumn == "None")
            {
                _dtAllInternationalLicense.DefaultView.RowFilter = "";
                lblNumberOfInternationalLicenses.Text = dgvInternationalLicensesManagment.Rows.Count.ToString();

                return;
            }

            _dtAllInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFillterValue.Text.Trim());
            lblNumberOfInternationalLicenses.Text = dgvInternationalLicensesManagment.Rows.Count.ToString();
        }

        private void cbFillterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFillterOptions.Text == "Is Active")
            {
                cbLicenseActive.SelectedIndex = 0;

                tbFillterValue.Visible = false;
                cbLicenseActive.Visible = true;
            }
            else
            {
                tbFillterValue.Visible = (cbFillterOptions.Text != "None");
                cbLicenseActive.Visible = false;

                tbFillterValue.Text = "";
                tbFillterValue.Focus();
            }
        }
    }
}
