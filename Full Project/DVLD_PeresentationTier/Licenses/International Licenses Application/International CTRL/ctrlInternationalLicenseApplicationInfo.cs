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
    public partial class ctrlInternationalLicenseApplicationInfo : UserControl
    {
        public ctrlInternationalLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public bool EnableApp
        {
            set =>  pInternationLicenseInfo.Enabled = value; 
        }

        public int InternationalLicenseApplicationID
        {
            set { lblInternationalApplicationID.Text = value.ToString(); }
            get { return Convert.ToInt32(lblInternationalApplicationID.Text.Trim()); }
        }

        public int InternationalLicenseID
        {
            set { lblInternationalLicenseID.Text = value.ToString(); }
            get { return Convert.ToInt32(lblInternationalLicenseID.Text.Trim()); }
        }


        public void LoadInternationalLicenseApplicationInfo(int? LocalLicenseAppID = null)
        {
            if (LocalLicenseAppID != null)
                lblLocalLicenseID.Text = LocalLicenseAppID.ToString();

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsUtil.SignedInUser.Username;
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationTypeManagement.ApplicationFeesString(clsApplicationTypeManagement.enApplicationService.NewInternationalLicense);
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
