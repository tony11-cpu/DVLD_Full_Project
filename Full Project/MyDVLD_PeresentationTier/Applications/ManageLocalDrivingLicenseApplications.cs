using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Licenses;
using MyDVLD_PeresentationTier.Test.Person_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static MyDVLD_BusinessTier.clsTestTypesManagement;

namespace MyDVLD_PeresentationTier.Applications.Manage_Applications
{
    public partial class ManageLocalDrivingLicenseApplications : Form
    {
        public ManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _CustomizeDataGrid()
        {
            dgvLocalApplicationsManagment.Columns[0].HeaderText = "L.D.L.AppID";
            dgvLocalApplicationsManagment.Columns[0].Width = 90;
            
            dgvLocalApplicationsManagment.Columns[1].HeaderText = "Driving Class";
            dgvLocalApplicationsManagment.Columns[1].Width = 250;
            
            dgvLocalApplicationsManagment.Columns[2].HeaderText = "National No.";
            dgvLocalApplicationsManagment.Columns[2].Width = 100;
            
            dgvLocalApplicationsManagment.Columns[3].HeaderText = "Full Name";
            dgvLocalApplicationsManagment.Columns[3].Width = 300;
            
            dgvLocalApplicationsManagment.Columns[4].HeaderText = "Application Date";
            dgvLocalApplicationsManagment.Columns[4].Width = 130;
            
            dgvLocalApplicationsManagment.Columns[5].HeaderText = "Passed Tests";
            dgvLocalApplicationsManagment.Columns[5].Width = 100;

            lblNumberOfApps.Text = dgvLocalApplicationsManagment.RowCount.ToString();
        }

        private void _ReloadDataGridView()
        {
            dgvLocalApplicationsManagment.DataSource = clsLocalLicesnseApplicationManagement.LocalApplications();
            _CustomizeDataGrid();
        }

        private void ManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFillterBy.SelectedIndex = 0;
            _ReloadDataGridView();
        }

        private void btnCloseFRM_Click_1(object sender, EventArgs e) => this.Close();

        private void btnAddApplicaiton_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicensesApplication addNewLocalDL = new AddOrUpdateLocalDrivingLicensesApplication();
            addNewLocalDL.ShowDialog();
            _ReloadDataGridView();
        }

        private void editApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicensesApplication UpdateNewLocalDL = new AddOrUpdateLocalDrivingLicensesApplication((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value);
            UpdateNewLocalDL.ShowDialog();
            _ReloadDataGridView();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationInfoFRM localDrivingLicenseApplicationInfo = new LocalDrivingLicenseApplicationInfoFRM((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value);
            localDrivingLicenseApplicationInfo.ShowDialog();
            _ReloadDataGridView();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppToCancelledID = (int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are You Sure You Want To Cancelle Applicaiton With ID: {AppToCancelledID} ??", "Cancelling Applicaitons", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsLocalLicesnseApplicationManagement.CancelApplicationsStates(AppToCancelledID))
                {
                    MessageBox.Show($"Applicaiton Cancelling Done Successfully", "Applicaiton Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadDataGridView();
                }
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppToDeleteID = (int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are You Sure You Want To Delete Applicaiton With ID: {AppToDeleteID} ??", "Delete Applicaitons", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsLocalLicesnseApplicationManagement.DeleteLocalApplication(AppToDeleteID))
                {
                    MessageBox.Show($"Applicaiton Deleting Done Successfully", "Applicaiton Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadDataGridView();
                }
                else
                    MessageBox.Show($"Failed To Delete Application!", "Can't Delete The Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadDataGridView();

            if (cbFillterBy.SelectedIndex == 0)
            {
                txtFilterBy.Visible = false;
                btnfillter.Visible = false;
            }
            else
            {
                txtFilterBy.Visible = true;
                btnfillter.Visible = true;
            }

            if(txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFillterBy.SelectedIndex == 2)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true; 
        }

        private void btnfillter_Click(object sender, EventArgs e)
        {
            string FillterColomn = string.Empty;

            switch (cbFillterBy.Text)
            {
                case "National No.":
                    FillterColomn = "NationalNo";
                    break;
                case "L.D.L AppID":
                    FillterColomn = "LocalDrivingLicenseApplicationID";
                    break;
                case "Full Name":
                    FillterColomn = "FullName";
                    break;
                case "Status":
                    FillterColomn = "Status";
                    break;
            }

            dgvLocalApplicationsManagment.DataSource = clsLocalLicesnseApplicationManagement.LocalApplicationsFillter(FillterColomn , txtFilterBy.Text.Trim());
            _CustomizeDataGrid();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            clsLocalLicesnseApplicationManagement LocalApp = clsLocalLicesnseApplicationManagement.Find((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value);

            switch (LocalApp.ApplicationStatus)
            {
                case clsApplicationsManagement.enApplicationStatus.Canceled:
                    _ContentAvailability();
                    return;
                case clsApplicationsManagement.enApplicationStatus.New:
                    _ContentAvailability(true);
                    break;
                case clsApplicationsManagement.enApplicationStatus.Completed:
                    _ContentAvailability(false, true);
                    return;
                default:
                    _ContentAvailability();
                    return;
            }

            _DisableFinishedTests(clsTestManagement.NumberOfTestsTaken(LocalApp.LocalApplicationID));
        }

        private void _ContentAvailability(bool Enable = false, bool Completed = false)
        {
            editApplicationsToolStripMenuItem.Enabled = Enable;
            deleteApplicationToolStripMenuItem.Enabled = Enable;
            cancelApplicationToolStripMenuItem.Enabled = Enable;
            sechduleTestToolStripMenuItem.Enabled = Enable;

            showToolStripMenuItem.Enabled = Completed;

            issueDriverLicenseFirstTimeToolStripMenuItem.Enabled = false;
        }

        private void _DisableFinishedTests(int NumberOfTestsPassedByLocalApp)
        {
            switch(NumberOfTestsPassedByLocalApp)
            {
                case 1:
                    _DisableFinishedTests(enTestMode.VisionTest);
                    break;
                case 2:
                    _DisableFinishedTests(enTestMode.WrittenTest);
                    break;
                case 3:
                    _DisableFinishedTests(enTestMode.PracticalTest);
                    break;
                default:
                    schdualVisionTestToolStripMenuItem.Enabled = true;
                    schedualWrittenTestToolStripMenuItem.Enabled = false;
                    schedualStreetTestToolStripMenuItem.Enabled = false;
                    issueDriverLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void _DisableFinishedTests(enTestMode TestTypeMode)
        {
            switch (TestTypeMode)
            {
                case enTestMode.VisionTest:
                     schdualVisionTestToolStripMenuItem.Enabled = false;
                     schedualWrittenTestToolStripMenuItem.Enabled = true;
                     schedualStreetTestToolStripMenuItem.Enabled = false;
                     break;
                case enTestMode.WrittenTest:
                     schdualVisionTestToolStripMenuItem.Enabled = false;
                     schedualWrittenTestToolStripMenuItem.Enabled = false;
                     schedualStreetTestToolStripMenuItem.Enabled = true;
                     break;
                case enTestMode.PracticalTest:
                     sechduleTestToolStripMenuItem.Enabled = false;
                     issueDriverLicenseFirstTimeToolStripMenuItem.Enabled = true;
                     break;                  
            }
        }

        private void schdualTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enTestMode TestType = enTestMode.VisionTest;

            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "VisionTest":
                    TestType = enTestMode.VisionTest;
                    break;
                case "WrittenTest":
                    TestType = enTestMode.WrittenTest;
                    break;
                case "StreetTest":
                    TestType = enTestMode.PracticalTest;
                    break;
            }

            TestApointmentSchedualFRM Test = new TestApointmentSchedualFRM((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value, TestType);
            Test.ShowDialog();

            _ReloadDataGridView();
        }

        private void issueDriverLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueLocalDrivingLicenseFirstTimeFRM IssueLicense = new IssueLocalDrivingLicenseFirstTimeFRM((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value);
            IssueLicense.ShowDialog();
            _ReloadDataGridView();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLocalLicenseInfoFRM showLicenseInfo = new ShowLocalLicenseInfoFRM((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value);
            showLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLocalLicesnseApplicationManagement.Find((int)dgvLocalApplicationsManagment.CurrentRow.Cells[0].Value).ApplicantPerson.PersonID;

            if (!clsDriversManagement.IsDriverExists(PersonID))
            {
                MessageBox.Show($"Person Has No License Yet..", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowLicensesHistoryFRM LicensesHistory = new ShowLicensesHistoryFRM(PersonID);
            LicensesHistory.ShowDialog();
        }
    }
}
