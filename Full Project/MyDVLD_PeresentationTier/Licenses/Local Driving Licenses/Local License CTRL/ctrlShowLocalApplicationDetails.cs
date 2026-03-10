using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyDVLD_PeresentationTier.Applications.Application_User_CTRL
{
    public partial class ctrlShowLocalApplicationDetails : UserControl
    {
        public clsLocalLicesnseApplicationManagement LocalInfoCard = clsLocalLicesnseApplicationManagement.Find(-1);

        public ctrlShowLocalApplicationDetails()
        {
            InitializeComponent();
        }

        private void _ShowLocalAppdetails()
        {
            lblAppliedForLiense.Text = LocalInfoCard.LicenseClass.ClassName;
            lblLocalDrivingLicenseApplicationID.Text = LocalInfoCard.LocalApplicationID.ToString();
            lblPassedTests.Text = $"{clsTestManagement.NumberOfTestsTaken(LocalInfoCard.LocalApplicationID)}/3";
            lblShowLicenceInfo.Enabled = (LocalInfoCard.ApplicationStatus == clsApplicationsManagement.enApplicationStatus.Completed) ? true : false;
        }

        public void LoadLocalAppDetails(int LADid)
        {
            LocalInfoCard = clsLocalLicesnseApplicationManagement.Find(LADid);

            _ShowLocalAppdetails();
            ctrlShowApplicationInforamtion1.LoadApplicationInfo(LocalInfoCard.ApplicationID);
        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLocalLicenseInfoFRM licenseInfo = new ShowLocalLicenseInfoFRM(LocalInfoCard.LocalApplicationID);
            licenseInfo.ShowDialog();
        }
    }
}
