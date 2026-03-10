using MyDVLD_BusinessTier;
//using MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application.International_CTRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses.Renew_License
{
    public partial class RenewLicenseFRM : Form
    {
        public RenewLicenseFRM() => InitializeComponent();

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private clsLicenseManagement _License = clsLicenseManagement.Find(-1);

        private bool _HandelInternationalLicenseRequirments()
        {
            bool CanRenew = true;

            if (!_License.IsLicenseExpired)
            {
                CanRenew = false;
                MessageBox.Show($"This License does not met the requirments , " +
                    $"you can't renew your licenses cause its expiration date did not come yet , " +
                    $"it finishes by: {_License.ExpirationDate}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!_License.IsActive)
            {
                CanRenew = false;
                MessageBox.Show("This License is not active , you can't renew it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            btnIssue.Enabled = CanRenew;

            return CanRenew;
        }

        private void _ReloadAfterFound()
        {
            lblOldLicenseID.Text = _License.LicenseID.ToString();
            lblLicenseFees.Text = _License.LicenseClass.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text.Trim()) + Convert.ToSingle(lblLicenseFees.Text.Trim())).ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(_License.LicenseClass.DefaultValidityLength).ToShortDateString();
            tbNotes.Text = (_License.Notes.Trim() == "No Notes") ? string.Empty : _License.Notes;
            lblLicenseHistory.Visible = true;
        }

        private void ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected(int obj)
        {
            if(obj == -1)
                return;

            _License = clsLicenseManagement.Find(obj);

            if (_License.LicenseID == null)
                return;

            _ReloadAfterFound();

            if (!_HandelInternationalLicenseRequirments())
                return;
        }

        private void RenewLicenseFRM_Load(object sender, EventArgs e)
        {
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();

            lblCreatedByUser.Text = clsUtil.SignedInUser.Username;
            lblAppFees.Text = clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.RenewDrivingLicense);
        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensesHistoryFRM showLicensesHistory = new ShowLicensesHistoryFRM(_License.Driver.Person.PersonID);
            showLicensesHistory.ShowDialog();
        }


        /// <summary>
        /// Reset the form to its default state
        /// </summary>
        private void _ResetToDefault()
        {
            _License = clsLicenseManagement.Find(-1);
            lblOldLicenseID.Text = "[???]";
            lblLicenseFees.Text = "[???]";
            lblTotalFees.Text = "[???]";
            lblExpirationDate.Text = "[???]";
            tbNotes.Text = string.Empty;
            lblLicenseHistory.Visible = false;
            lblShowRenewedLicense.Visible = false;
            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = true;
            ctrlShowLicenseWithDriverInfoWithFillter1.ClearFillter = true;
            btnIssue.Enabled = false;
        }

        /// <summary>
        /// Renew the license...
        /// </summary>
        /// <returns>New Renewed License And Deactive Old One...</returns>
        private bool _RenewLicense()
        {
            _License = _License.RenewLicense(tbNotes.Text.Trim(), clsUtil.SignedInUser.UserID);

            if (_License == null)
            {
                MessageBox.Show("An error occured while renewing the license , please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLicenseHistory.Visible = false;
                return false;
            }

            return true;
        }

        private void _ReloadAfterRenew()
        {
            btnIssue.Enabled = false;
            lblRenewLocalDrivingApplicationID.Text = _License.ApplicationID.ToString();
            lblRenewLocalDrivingLicenseID.Text = _License.LicenseID.ToString();
            lblShowRenewedLicense.Visible = true;
            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = false;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to renew this license?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if(!_RenewLicense())
                return;

            _ReloadAfterRenew();

            MessageBox.Show("The license has been renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Do You Want To Renew Another License?", "Reset Form.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                _ResetToDefault();
        }

        private void lblShowRenewedLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocalLicenseInfoFRM showLocalLicenseInfoFRM = new ShowLocalLicenseInfoFRM(_License.LicenseID);
            showLocalLicenseInfoFRM.ShowDialog();
        }
    }
}
