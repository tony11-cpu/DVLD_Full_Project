using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Properties;
using MyDVLD_PeresentationTier.Test.Person_Test.Vision_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyDVLD_BusinessTier.clsTestTypesManagement;

namespace MyDVLD_PeresentationTier.Test.Person_Test
{
    public partial class TestApointmentSchedualFRM : Form
    {
        private int _LocalDrivingLicenseID = -1;
        private enTestMode _TestMode = enTestMode.VisionTest;

        public TestApointmentSchedualFRM(int LocalLicenseAppID , enTestMode TestMode)
        {
            InitializeComponent();

            _LocalDrivingLicenseID = LocalLicenseAppID;
            _TestMode = TestMode;
        }

        private void TestApointmentSchedualFRM_Load(object sender, EventArgs e)
        {
            _LoadTestTypeInfo();

            ctrlShowLocalApplicationDetails1.LoadLocalAppDetails(_LocalDrivingLicenseID);
            _LoadTestAppointments();
        }

        /// <summary>
        /// Make The Form Ready For Test...
        /// </summary>
        private void _LoadTestTypeInfo()
        {
            switch (_TestMode)
            {
                case enTestMode.VisionTest:
                    this.Text = "Vision Test Appointment.";
                    lblTestAppointmentName.Text = "Vision Test Appointment.";
                    pbTestPicture.Image = Resources.Vision_512;
                    break;
                case enTestMode.WrittenTest:
                    this.Text = "Written Test Appointment.";
                    lblTestAppointmentName.Text = "Written Test Appointment.";
                    pbTestPicture.Image = Resources.Written_Test_512;
                    break;
                case enTestMode.PracticalTest:
                    this.Text = "Practical Test Appointment.";
                    lblTestAppointmentName.Text = "Practical Test Appointment.";
                    pbTestPicture.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => this.Close();

        private void _LoadTestAppointments()
        {
            dgvTestAppointments.DataSource = clsTestAppointmentsManagement.GetAllTestAppointments(_LocalDrivingLicenseID , _TestMode);

            dgvTestAppointments.Columns[0].HeaderText = "Appointment ID";
            dgvTestAppointments.Columns[0].Width = 170;
            dgvTestAppointments.Columns[1].HeaderText = "Application Date";
            dgvTestAppointments.Columns[1].Width = 300;
            dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
            dgvTestAppointments.Columns[2].Width = 170;
            dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
            dgvTestAppointments.Columns[3].Width = 170;

            lblNumberOfVisionAppointments.Text = dgvTestAppointments.RowCount.ToString();
        }

        private bool _CheckForTestAvailablity()
        {
            if (clsTestAppointmentsManagement.IsActiveLocalAppAppointementExists(_LocalDrivingLicenseID, (int)_TestMode))
            {
                MessageBox.Show("Person Already Have An Active Appointment For This Test , You Can Not Add New One!", "Can't Add New Appointment!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clsTestManagement.IsTestPassed(_LocalDrivingLicenseID, _TestMode))
            {
                MessageBox.Show("Person Already Passed This Test Before , You Can Not Add New One!", "Can't Add New Appointment!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddTestAppointemnt_Click(object sender, EventArgs e)
        {
            bool IsRetakeTestAppointemnt = false;

            if (dgvTestAppointments.Rows.Count != 0)
            {
                if (!_CheckForTestAvailablity())
                    return;
                else
                    IsRetakeTestAppointemnt = true;
            }

            AddOrUpdateNewTestFRM TestAppointemnt = new AddOrUpdateNewTestFRM(_LocalDrivingLicenseID, _TestMode , IsRetakeTestAppointemnt);
            TestAppointemnt.ShowDialog();

            _LoadTestAppointments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointments.CurrentRow == null)
                return;

            AddOrUpdateNewTestFRM TestAppointemnt = new AddOrUpdateNewTestFRM(_LocalDrivingLicenseID, _TestMode , false , (int)dgvTestAppointments.CurrentRow.Cells[0].Value);
            TestAppointemnt.ShowDialog();

            _LoadTestAppointments();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointments.CurrentRow == null)
                return;

            if (!clsTestAppointmentsManagement.Find((int)dgvTestAppointments.CurrentRow.Cells[0].Value).IsAppointmentLocked)
            {
                TakeTestFRM Test = new TakeTestFRM(_LocalDrivingLicenseID, _TestMode, (int)dgvTestAppointments.CurrentRow.Cells[0].Value);
                Test.ShowDialog();

                ctrlShowLocalApplicationDetails1.LoadLocalAppDetails(_LocalDrivingLicenseID);
                _LoadTestAppointments();
            }
            else
                MessageBox.Show("Person already took this test and it is locked now. You can’t take it again!", "Appointment Is Locked!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
