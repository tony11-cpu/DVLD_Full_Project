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

namespace MyDVLD_PeresentationTier.Licenses.Licenses_CTRL
{
    public partial class ctrlShowLicenseWithDriverInfoWithFillter : UserControl
    {
        public ctrlShowLicenseWithDriverInfoWithFillter()
        {
            InitializeComponent();
        }

        public event Action<int> OnLicenseSelected;

        public bool ClearFillter 
        {
            get => string.IsNullOrEmpty(tbLicenseID.Text.Trim());
            set => tbLicenseID.Text = string.Empty;
        }

        public bool EnableFillter { set { gbSearchForLicense.Enabled = value; } }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLicenseID.Focus();
                return;
            }

            int LicenseID = (!string.IsNullOrEmpty(tbLicenseID.Text)) ? Convert.ToInt32(tbLicenseID.Text.Trim()) : -1;

            if (!clsLicenseManagement.IsLicenseExists(LicenseID))
            {
                MessageBox.Show("License not found , please try diffrent id number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnLicenseSelected?.Invoke(-1);
                return;
            }

            ctrlLocalShowLicenseInfo1.LoadLicenseInfoUsingLicenseID(LicenseID);

            OnLicenseSelected?.Invoke(LicenseID);
        }

        private void ctrlShowLicenseWithDriverInfo_Load(object sender, EventArgs e)
        {
            tbLicenseID.Focus();
            tbLicenseID.Text = string.Empty;
        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void tbLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbLicenseID.Text))
                errorProvider1.SetError(tbLicenseID, "Make Sure To Put Valid ID!");
            else
                errorProvider1.SetError(tbLicenseID, string.Empty);
        }

        public void LoadLicenseInfoWithID(int LicenseID)
        {
            if (clsLicenseManagement.IsLicenseExists(LicenseID))
            {
                EnableFillter = false;
                tbLicenseID.Text = LicenseID.ToString();
                ctrlLocalShowLicenseInfo1.LoadLicenseInfoUsingLicenseID(LicenseID);
            }
            else
            {
                MessageBox.Show($"License with id: {LicenseID} not found , please try diffrent id number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                ctrlShowLicenseWithDriverInfo_Load(null, null);
                EnableFillter = true;               
            }
        }
    }
}
