using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Licenses.Licenses_CTRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application
{
    public partial class IssueInternationalLicenseFRM : Form
    {
        public IssueInternationalLicenseFRM() => InitializeComponent();

        private clsLicenseManagement _License = clsLicenseManagement.Find(-1);
        private clsInternationalLicenseManagement _InternationalLicense = clsInternationalLicenseManagement.Find(-1);

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// It Handles The Requirments To Issue International License...
        /// </summary>
        /// <returns>If Can Be Issued Or No!</returns>
        private bool _HandleIssueRequirments()
        {
            bool CanIssue = true;

            if (_License.LicenseClass.ClassID != 3)
            {
                MessageBox.Show("You Can Only Issue International License For  License Class Number 3!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CanIssue = false;
            }
            else if (clsInternationalLicenseManagement.IsInternationalLicenseExistsByDriverID(_License.Driver.DriverID ?? -1))
            {
                MessageBox.Show("This Driver Already Has An Active International License!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _InternationalLicense = clsInternationalLicenseManagement.FindByDriver(_License.Driver.DriverID ?? -1);

                _EnableProperties();
                ctrlInternationalLicenseApplicationInfo1.LoadInternationalLicenseApplicationInfo(_License.ApplicationID);

                CanIssue = false;
            }

            btnIssue.Enabled = CanIssue;

            return CanIssue;
        }

        /// <summary>
        /// Handels The Requirments To Enable/Disable The Issue International License Controls
        /// </summary>
        private void _HandelInternationalLicenseRequirments()
        {
            if (!_License.IsActive || _License.ExpirationDate < DateTime.Now)
            {
                btnIssue.Enabled = false;
                ctrlInternationalLicenseApplicationInfo1.EnableApp = false;

                MessageBox.Show("This License does not met the requirments , you can't issue international license.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnIssue.Enabled = true;
                ctrlInternationalLicenseApplicationInfo1.EnableApp = true;
            }
        }

        private void ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected_1(int obj)
        {
            if (obj == -1)
            {
                btnIssue.Enabled = false;

                lblShowInternationalLicense.Visible = false;
                lblLicenseHistory.Visible = false;

                ctrlInternationalLicenseApplicationInfo1.LoadInternationalLicenseApplicationInfo();

                return;
            }
            else
                _License = clsLicenseManagement.Find(obj);

            ctrlInternationalLicenseApplicationInfo1.LoadInternationalLicenseApplicationInfo(_License.ApplicationID);
            _HandelInternationalLicenseRequirments();

            lblLicenseHistory.Visible = true;
        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensesHistoryFRM showLicensesHistory = new ShowLicensesHistoryFRM(_License.Driver.Person.PersonID);
            showLicensesHistory.ShowDialog();
        }


        /// <summary>
        /// Enable The Properties After Issuing The International License
        /// </summary>
        private void _EnableProperties()
        {
            btnIssue.Enabled = false;

            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = false;

            ctrlInternationalLicenseApplicationInfo1.InternationalLicenseID = _InternationalLicense.InternationalLicenseID ?? -1;
            ctrlInternationalLicenseApplicationInfo1.InternationalLicenseApplicationID = _InternationalLicense.InternationalApplication.ApplicationID;

            lblShowInternationalLicense.Visible = true;
        }

        private void _ExchangeDataBetweenLicenses()
        {
            _InternationalLicense.DriverID = _License.Driver.DriverID ?? -1;
            _InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID ?? -1;
            _InternationalLicense.InternationalApplication.ApplicationDate = DateTime.Now;
            _InternationalLicense.InternationalApplication.ApplicationType = clsApplicationTypeManagement.Find((short)clsApplicationTypeManagement.enApplicationService.NewInternationalLicense);
            _InternationalLicense.InternationalApplication.ApplicantPerson = _License.Driver.Person;
            _InternationalLicense.InternationalApplication.PaidFees = clsApplicationTypeManagement.Find((short)clsApplicationTypeManagement.enApplicationService.NewInternationalLicense).ApplicationFees;
            _InternationalLicense.InternationalApplication.CreatedByUser = clsUtil.SignedInUser;
            _InternationalLicense.IsActive = true;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.InternationalApplication.ApplicationStatus = clsApplicationsManagement.enApplicationStatus.Completed;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            if (!_HandleIssueRequirments())
                return;

            _ExchangeDataBetweenLicenses();

            if (_InternationalLicense.Save())
            {
                _EnableProperties();

                MessageBox.Show("International License Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllInternationalLicensesesFRM.LoadDataGridViewDelegate?.Invoke(null, null);
            }
            else
                MessageBox.Show("Failed To Issue International License!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblShowInternationalLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInternationalLicenseInfoFRM showInternationalLicenseInfoFRM = new ShowInternationalLicenseInfoFRM(_InternationalLicense.InternationalLicenseID ?? -1);
            showInternationalLicenseInfoFRM.ShowDialog();
        }

        private void IssueInternationalLicenseFRM_Load(object sender, EventArgs e) => ctrlInternationalLicenseApplicationInfo1.LoadInternationalLicenseApplicationInfo();
    }
}
