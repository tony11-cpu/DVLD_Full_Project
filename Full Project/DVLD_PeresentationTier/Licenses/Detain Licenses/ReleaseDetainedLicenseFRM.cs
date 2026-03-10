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

namespace MyDVLD_PeresentationTier.Licenses.Detain_Licenses
{
    public partial class ReleaseDetainedLicenseFRM : Form
    {
        private int _DetainedLicenseID = -1;
        private clsLicenseManagement _License = clsLicenseManagement.Find(-1);
        private clsDetainedLicensesManagement _DetainedLicense = clsDetainedLicensesManagement.Find(-1);

        public ReleaseDetainedLicenseFRM(int DetainedLicenseID = -1)
        {
            InitializeComponent();

            if (DetainedLicenseID != -1)
                _DetainedLicenseID = DetainedLicenseID;
        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensesHistoryFRM showLicensesHistory = new ShowLicensesHistoryFRM(_License.Driver.Person.PersonID);
            showLicensesHistory.ShowDialog();
        }

        private void lblShowDetainedLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocalLicenseInfoFRM showLocalLicenseInfoFRM = new ShowLocalLicenseInfoFRM(_License.LicenseID);
            showLocalLicenseInfoFRM.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ReleaseDetainedLicenseFRM_Load(object sender, EventArgs e)
        {
            _DetainedLicense = clsDetainedLicensesManagement.Find(_DetainedLicenseID);
            _License = clsLicenseManagement.Find(_DetainedLicense.LicenseToDetaineID);

            if (_License.LicenseID == null || _DetainedLicense.DetainedLicenseID == null)
                return;

            ctrlShowLicenseWithDriverInfoWithFillter1.LoadLicenseInfoWithID(_License.LicenseID ?? -1);

            _LoadDetainedInfo();

            lblLicenseHistory.Visible = true;
            btnRelease.Enabled = true;
        }

        private void ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            _License = clsLicenseManagement.Find(obj);

            if(_License.LicenseID == null)
                return;

            lblLicenseHistory.Visible = true;

            if (_HandleReleaseDetainedLicense())
            {
                _DetainedLicense = clsDetainedLicensesManagement.FindByLicenseID(_License.LicenseID ?? -1);

                if (_DetainedLicense.DetainedLicenseID != null)
                    _LoadDetainedInfo();
            }
        }

        private void _LoadDetainedInfo()
        {
            lblApplicationFees.Text =
                         clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.ReleaseDetainedDrivingLicsense);
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToUInt32(lblApplicationFees.Text) + Convert.ToUInt32(lblFineFees.Text)).ToString();


            lblDetainLicenseID.Text = _DetainedLicense.DetainedLicenseID.ToString();
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblCreatedByUser.Text = _DetainedLicense.CreatedByUserID.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
        }

        private bool _HandleReleaseDetainedLicense()
        {
            bool CanDetain = true;

            if (!_License.IsActive)
            {
                CanDetain = false;
                MessageBox.Show("This License is not active , you can't Release it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_License.IsLicenseDetained)
            {
                CanDetain = false;
                MessageBox.Show("This License is already free!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnRelease.Enabled = CanDetain;

            return CanDetain;
        }

        private bool _ReleaseDetainedLicense()
        {
            _DetainedLicense = _DetainedLicense.ReleaseDetainedLicense();

            if (_DetainedLicense == null)
            {
                MessageBox.Show($"Error While Releasing License!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _AfterReleasingLicense()
        {
            lblApplicationID.Text = _DetainedLicense.ReleasedApplicationID.ToString();
            lblShowReleasedLicense.Visible = true;

            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = false;
            btnRelease.Enabled = false;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to release this license with id: {_License.LicenseID}?", "Confermation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (_ReleaseDetainedLicense())
            {
                _AfterReleasingLicense();
                MessageBox.Show($"License Has Released Successfully.", "License Released.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
    }
}
