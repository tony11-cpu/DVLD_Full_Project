using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyDVLD_BusinessTier.clsTestTypesManagement;

namespace MyDVLD_PeresentationTier.Test.Person_Test
{
    public partial class AddOrUpdateNewTestFRM : Form
    {
        private enTestMode _TestMode = enTestMode.VisionTest;
        private int? _LocalDrivingLicenseApplicationID = null;
        private bool _IsRetakeTestAppointemnt = false;
        private int? _ExistingTestAppointmentID = null;

        public AddOrUpdateNewTestFRM(int LocalDrivingLicenseApplicationID , enTestMode TestMode, 
                                    bool IsRetakeTestAppointemnt , int? ExistingTestAppointmentID = null)
        {
            InitializeComponent();

            _TestMode = TestMode;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _IsRetakeTestAppointemnt = IsRetakeTestAppointemnt;
            _ExistingTestAppointmentID = ExistingTestAppointmentID;
        }

        private void btnSave_Click(object sender, EventArgs e) => this.Close();

        private void AddOrUpdateNewTestFRM_Load(object sender, EventArgs e)
        {
            switch (_TestMode)
            {
                case enTestMode.VisionTest:
                    this.Text = "Vision Test Appointment";
                    break;
                case enTestMode.WrittenTest:
                    this.Text = "Written Test Appointment";
                    break;
                case enTestMode.PracticalTest:
                    this.Text = "Practical Test Appointment";
                    break;
            }

            ctrlShowTestAppointment1.LoadTestAppointemnt(_LocalDrivingLicenseApplicationID ?? -1, _TestMode, _IsRetakeTestAppointemnt, _ExistingTestAppointmentID ?? -1);
        }
    }
}
