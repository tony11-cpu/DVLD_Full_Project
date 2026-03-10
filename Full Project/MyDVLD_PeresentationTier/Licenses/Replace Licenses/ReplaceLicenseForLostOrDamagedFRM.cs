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

namespace MyDVLD_PeresentationTier.Licenses.Replace_Licenses
{
    public partial class ReplaceLicenseForLostOrDamagedFRM : Form
    {
        public ReplaceLicenseForLostOrDamagedFRM() => InitializeComponent();

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private clsLicenseManagement _License = clsLicenseManagement.Find(-1);

        private bool _HandelInternationalLicenseRequirments()
        {
            bool CanRenew = true;

            if (_License.IsLicenseExpired)
            {
                CanRenew = false;
                MessageBox.Show($"This License does not met the requirments , " +
                    $"Your License is already expired!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_License.IsActive)
            {
                CanRenew = false;
                MessageBox.Show("This License is not active , you can't replace it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnIssue.Enabled = CanRenew;
            rbLostLicense.Enabled = CanRenew;
            rbDamagedLicense.Enabled = CanRenew;

            return CanRenew;
        }

        private void ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            _License = clsLicenseManagement.Find(obj);

            if (_License.LicenseID == null)
                return;

            lblOldLicenseID.Text = _License.LicenseID.ToString();
            lblLicenseHistory.Visible = true;

            if (!_HandelInternationalLicenseRequirments())
                return;
        }

        private clsApplicationTypeManagement.enApplicationService _ReplaceReason
        {
            get =>
                rbLostLicense.Checked ?
                clsApplicationTypeManagement.enApplicationService.ReplacementForLostDrivingLicense 
                : clsApplicationTypeManagement.enApplicationService.ReplacementForDamagedDrivingLicense;
            set
            {
                switch(value)
                {
                    case clsApplicationTypeManagement.enApplicationService.ReplacementForLostDrivingLicense:
                        rbLostLicense.Checked = true;
                        lblAppTitle.Text = "Replacement for Lost Driving License";
                        this.Text = "Replacement for Lost License";
                        break;
                    case clsApplicationTypeManagement.enApplicationService.ReplacementForDamagedDrivingLicense:
                        rbDamagedLicense.Checked = true;
                        lblAppTitle.Text = "Replacement for Damaged Driving License";
                        this.Text = "Replacement for Damaged License";
                        break;
                }

                lblAppFees.Text = clsApplicationTypeManagement.ApplicationFeesString(value);
            }
        }

        private void rbLicenseReplaceFor_CheckedChanged(object sender, EventArgs e) => _ReplaceReason = (rbLostLicense.Checked) ?
                clsApplicationTypeManagement.enApplicationService.ReplacementForLostDrivingLicense:
                clsApplicationTypeManagement.enApplicationService.ReplacementForDamagedDrivingLicense;

        private void ReplacmentForLostOrDamaged_Load(object sender, EventArgs e)
        {
            _ReplaceReason = clsApplicationTypeManagement.enApplicationService.ReplacementForLostDrivingLicense;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsUtil.SignedInUser.Username;
        }

        private bool _ReplaceLicense()
        {
            _License = _License.ReplaceLicense(_ReplaceReason, clsUtil.SignedInUser.UserID);

            if (_License == null)
            {
                MessageBox.Show("An error occured while replacing the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _RefreshAfterReplace()
        {
            lblReplacedLocalDrivingApplicationID.Text = _License.ApplicationID.ToString();
            lblReplacedLocalDrivingLicenseID.Text = _License.LicenseID.ToString();

            btnIssue.Enabled = false;
            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = false;
            rbLostLicense.Enabled = false;
            rbDamagedLicense.Enabled = false;
            lblShowRenewedLicense.Visible = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            if(!_ReplaceLicense())
                return;

            _RefreshAfterReplace();

            MessageBox.Show($"The license has been replaced successfully with new id: {_License.LicenseID}."
                , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblShowRenewedLicense_LinkClicked(object sender, EventArgs e)
        {
            ShowLocalLicenseInfoFRM showLocalLicenseInfoFRM = new ShowLocalLicenseInfoFRM(_License.LicenseID);
            showLocalLicenseInfoFRM.ShowDialog();
        }

        private void lblLicenseHistory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensesHistoryFRM showLicensesHistory = new ShowLicensesHistoryFRM(_License.Driver.Person.PersonID);
            showLicensesHistory.ShowDialog();
        }
    }
}
