using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Applications.Application_User_CTRL;
using System;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Applications.Manage_Applications
{
    public partial class LocalDrivingLicenseApplicationInfoFRM : Form
    {
        private int _LocalAppID = -1;

        public LocalDrivingLicenseApplicationInfoFRM(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }

        private void LocalDrivingLicenseApplicationInfoFRM_Load(object sender, EventArgs e) => ctrlShowLocalApplicationDetails1.LoadLocalAppDetails(_LocalAppID);

        private void btnCloseFRM_Click(object sender, EventArgs e) => this.Close();
    }
}