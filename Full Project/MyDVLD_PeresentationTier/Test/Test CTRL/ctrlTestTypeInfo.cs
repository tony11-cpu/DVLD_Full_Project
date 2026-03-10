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

namespace MyDVLD_PeresentationTier.Test.Test_CTRL
{
    public partial class ctrlTestTypeInfo : UserControl
    {
        public ctrlTestTypeInfo()
        {
            InitializeComponent();
        }

        public bool EnableReakeTestTitle { set { lblRetakeTestTitle.Visible = value; } }
        public float TestTypeFees { get { return Convert.ToSingle(lblTestFees.Text.Trim()); } }

        /// <summary>
        /// Make The Form Ready For The Test / You Can Define The Type Of Test In RunTime..!
        /// </summary>
        public enTestMode TestMode
        {
            get { return _CtrlMode; }

            set
            {
                _CtrlMode = value;

                switch (_CtrlMode)
                {
                    case enTestMode.VisionTest:
                        pbTestPicture.Image = Resources.Vision_512;
                        gbTestName.Text = "Vision Test";
                        break;
                    case enTestMode.WrittenTest:
                        pbTestPicture.Image = Resources.Written_Test_512;
                        gbTestName.Text = "Written Test";
                        break;
                    case enTestMode.PracticalTest:
                        pbTestPicture.Image = Resources.driving_test_512;
                        gbTestName.Text = "Practical Test";
                        break;
                }

                lblTestFees.Text = Find((int)_CtrlMode).TestTypeFees.ToString();
            }
        }

        private enTestMode _CtrlMode = enTestMode.VisionTest;

        public clsTestAppointmentsManagement NewTestAppointment = clsTestAppointmentsManagement.Find(-1);

        private clsLocalLicesnseApplicationManagement _LocalDrivingApp = clsLocalLicesnseApplicationManagement.Find(-1);

        private int LocalDrivingLicenseApplicationID = -1;


        public void LockedAppointment()
        {
            dtpAppDate.Enabled = false;
            lblAppointLockedText.Visible = true;

            if(NewTestAppointment.RetakeTestApplicationID != -1)
                lblTestFees.Text = (NewTestAppointment.PaidFees - Convert.ToSingle(clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.RetakeTest))).ToString();
            else
                lblTestFees.Text = NewTestAppointment.PaidFees.ToString();
        }

        public void SaveData()
        {
            NewTestAppointment.CreatedByUserID = _LocalDrivingApp.CreatedByUser.UserID;
            NewTestAppointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            NewTestAppointment.AppointmentDate = dtpAppDate.Value;
            NewTestAppointment.TestName.TestType = _CtrlMode;
        }

        public void LoadTakeTest()
        {
            lblDefTestID.Visible = true;
            pbTestID.Visible = true;
            lblTestID.Visible = true;
            lblTestID.Text = "Not Taken Yet..";
            lblTestTitle.Text = "Schedualed Test";
            dtpAppDate.Enabled = false;
        }

        private void _LoadCommonAppInfo()
        {
            _LocalDrivingApp = clsLocalLicesnseApplicationManagement.Find(LocalDrivingLicenseApplicationID);

            lblLocalDrivingAppID.Text = _LocalDrivingApp.LocalApplicationID.ToString();
            lblDrivingClassTitle.Text = _LocalDrivingApp.LicenseClass.ClassName;
            lblAppTrails.Text = clsTestManagement.NumberOfTrailsForApplication(_LocalDrivingApp.LocalApplicationID , _CtrlMode).ToString();

            lblPersonName.Text = _LocalDrivingApp.ApplicantPerson.FullName;

            dtpAppDate.MinDate =
                (DateTime.Compare(DateTime.Now, NewTestAppointment.AppointmentDate) < 0) ? NewTestAppointment.AppointmentDate : DateTime.Now;
        }

        private void _CheckForUpdateAppointment(int TestAppointmentID)
        {
            if (TestAppointmentID == -1)
                return;

            NewTestAppointment = clsTestAppointmentsManagement.Find(TestAppointmentID);

            dtpAppDate.Value = NewTestAppointment.AppointmentDate;
        }

        public void LoadApplicationTypeInfo(int LocalDrivingLicenseApplicationID, int TestAppointmentID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;

            _CheckForUpdateAppointment(TestAppointmentID);
            _LoadCommonAppInfo();
        }
    }
}
