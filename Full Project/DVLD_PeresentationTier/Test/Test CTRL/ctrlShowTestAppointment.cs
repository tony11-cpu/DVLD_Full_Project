using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Test.Test_CTRL;
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

namespace MyDVLD_PeresentationTier.Test
{
    public partial class ctrlShowTestAppointment : UserControl
    {
        public ctrlShowTestAppointment()
        {
            InitializeComponent();
        }

        private bool _IsAppointmentExsists = false;

        private void _CheckForPresentTestAppointment(int TestAppointmentID)
        {
            if (TestAppointmentID != -1)
            {
                _IsAppointmentExsists = true;

                if (ctrlTestType1.NewTestAppointment.IsAppointmentLocked)
                {
                    ctrlTestType1.LockedAppointment();
                    btnSave.Enabled = false;
                }
            }
        }

        private int _CreateRetakeApplicationTest()
        {
            clsApplicationsManagement NewRetakeApplication = new clsApplicationsManagement();

            NewRetakeApplication.CreatedByUser = clsUtil.SignedInUser;
            NewRetakeApplication.ApplicationType = clsApplicationTypeManagement.Find((short)clsApplicationTypeManagement.enApplicationService.RetakeTest);
            NewRetakeApplication.ApplicationStatus = clsApplicationsManagement.enApplicationStatus.New;
            NewRetakeApplication.ApplicationDate = DateTime.Now;
            NewRetakeApplication.ApplicantPerson = clsLocalLicesnseApplicationManagement.Find(_LocalDrivingLicenseID).ApplicantPerson;
            NewRetakeApplication.PaidFees = Convert.ToSingle(clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.RetakeTest));

            if (NewRetakeApplication.Save())
                return NewRetakeApplication.ApplicationID;
            else
                return -1;
        }

        public void LoadTestAppointemnt(int LocalDrivingLicenseApplicationID, enTestMode TestMode , bool IsRetakeTest, int TestAppointmentID)
        {
            _IsRetakeTest = IsRetakeTest;
            _LocalDrivingLicenseID = LocalDrivingLicenseApplicationID;

            ctrlTestType1.TestMode = TestMode;
            ctrlTestType1.LoadApplicationTypeInfo(LocalDrivingLicenseApplicationID, TestAppointmentID);

            _CheckForPresentTestAppointment(TestAppointmentID);

            _LoadRetakeTestInfo();
        }

        private void _LoadRetakeTestInfo()
        {
            int RetakeTestID = ctrlTestType1.NewTestAppointment.RetakeTestApplicationID;

            if (RetakeTestID != -1 && RetakeTestID != 0)
            {
                _IsRetakeTest = true;
                lblRetakeTestAppID.Text = RetakeTestID.ToString();
            }

            if (_IsRetakeTest)
            {
                ctrlTestType1.EnableReakeTestTitle = true;

                gbRetakeTestInfo.Enabled = true;
                lblRetakeAppFees.Text = clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.RetakeTest);
                lblTotalFees.Text = (ctrlTestType1.TestTypeFees + Convert.ToInt32(lblRetakeAppFees.Text.Trim())).ToString();

                return;
            }

            lblRetakeAppFees.Text = 0.ToString();
            lblTotalFees.Text = ctrlTestType1.TestTypeFees.ToString();
        }

        private bool _IsRetakeTest = false;
        private int _LocalDrivingLicenseID = -1;

        private void _SaveDataBeforeSavingToDataBase()
        {
            if (_IsRetakeTest)
            {
                if (!_IsAppointmentExsists)
                {
                    if (!clsApplicationsManagement.IsApplicationExists(ctrlTestType1.NewTestAppointment.RetakeTestApplicationID))
                        ctrlTestType1.NewTestAppointment.RetakeTestApplicationID = _CreateRetakeApplicationTest();
                }

                ctrlTestType1.NewTestAppointment.PaidFees = Convert.ToInt32(lblTotalFees.Text);
            }
            else
                ctrlTestType1.NewTestAppointment.PaidFees = ctrlTestType1.TestTypeFees;
 
            ctrlTestType1.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveDataBeforeSavingToDataBase();

            if (ctrlTestType1.NewTestAppointment.Save())
                MessageBox.Show($"Appointment Data Saved Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Appointment Can't Be Saved", "Fialed To Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
