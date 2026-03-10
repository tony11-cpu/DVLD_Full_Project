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
    public partial class DetainLicensesFRM : Form
    {
        private clsLicenseManagement _License = clsLicenseManagement.Find(-1);

        public DetainLicensesFRM()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlShowLicenseWithDriverInfoWithFillter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            _License = clsLicenseManagement.Find(obj);

            if(_License.LicenseID == null)
                return;

            lblLicenseID.Text = _License.LicenseID.ToString();
            lblLicenseHistory.Visible = true;

            if (!_HandelDetainLicenseRequirments())
                return;
        }

        private bool _HandelDetainLicenseRequirments()
        {
            bool CanDetain = true;

            if (_License.IsLicenseDetained)
            {
                CanDetain = false;
                MessageBox.Show("This License is already detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_License.IsActive)
            {
                CanDetain = false;
                MessageBox.Show("This License is not active , you can't detain it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnDetain.Enabled = CanDetain;
            tbFineFees.Enabled = CanDetain;

            return CanDetain;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(!tbFineFees_Validating())
            {
                MessageBox.Show("Some fileds are not valide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFineFees.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            clsDetainedLicensesManagement DetainedLicense = _License.DetainLicense(Convert.ToSingle(tbFineFees.Text.Trim()), clsUtil.SignedInUser.UserID);

            if(DetainedLicense == null)
            {
                MessageBox.Show("Error Happended While Detaining Licenses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainLicenseID.Text = DetainedLicense.DetainedLicenseID.ToString();

            btnDetain.Enabled = false;
            tbFineFees.Enabled = false;

            ctrlShowLicenseWithDriverInfoWithFillter1.EnableFillter = false;

            lblShowRenewedLicense.Visible = true;

            MessageBox.Show("The license has been detained.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DetainLicenseFRM_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsUtil.SignedInUser.Username;
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

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(tbFineFees, "Entered Value Is Not Valid!!");
            }
            else
                errorProvider1.SetError(tbFineFees, null);
        }

        private bool tbFineFees_Validating()
        {
            if (string.IsNullOrEmpty(tbFineFees.Text))
            {
                errorProvider1.SetError(tbFineFees, "The fine fees can't be empty.");
                return false;
            }
            else if (Convert.ToInt32(tbFineFees.Text.Trim()) < 0)
            {
                errorProvider1.SetError(tbFineFees, "The fine fees must be greater than or equal to zero.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbFineFees, string.Empty);
                return true;
            }
        }
    }   
}
