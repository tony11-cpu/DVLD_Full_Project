using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Application_Types;
using MyDVLD_PeresentationTier.Applications;
using MyDVLD_PeresentationTier.Applications.Manage_Applications;
using MyDVLD_PeresentationTier.Drivers;
using MyDVLD_PeresentationTier.Licenses.Detain_Licenses;
using MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application;
using MyDVLD_PeresentationTier.Licenses.Renew_License;
using MyDVLD_PeresentationTier.Licenses.Replace_Licenses;
using MyDVLD_PeresentationTier.Test_Types;
using MyDVLD_PeresentationTier.Users_FRMs;
using MyDVLD_PeresentationTier.Users_FRMs.Users_Control;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier
{
    public partial class MainAppFRM : Form
    {
        public MainAppFRM() => InitializeComponent();

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void MainAppFRM_Load(object sender, EventArgs e)
        {
            this.Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage =
                Image.FromFile(@"C:\Users\Tonyg\OneDrive\Desktop\Desktop Projects_LocalRebo\DVLD Project\Project Icons\App Icons\Icons\Icons\WinForms MDI Background Teal Details.png");

            this.Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void _OpenChildForm(Form frm)
        {
            foreach (Form childForm in MdiChildren)
                if(!childForm.IsDisposed || childForm.GetType() == frm.GetType())
                    return;

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleShowMainFRM frm = new PeopleShowMainFRM();
            _OpenChildForm(frm);
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsersShowMainFRM frm = new UsersShowMainFRM();
            _OpenChildForm(frm);
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesFRM frm = new ManageApplicationTypesFRM();
            _OpenChildForm(frm);
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesFRM frm = new ManageTestTypesFRM();
            _OpenChildForm(frm);
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetailsFRM frm = new ShowUserDetailsFRM(clsUtil.SignedInUser.UserID);
            _OpenChildForm(frm);
        }

        private void changePasowrdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChangePasswordFRM frm = new ShowChangePasswordFRM(clsUtil.SignedInUser.UserID);
            _OpenChildForm(frm);
        }

        private void localDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdateLocalDrivingLicensesApplication frm = new AddOrUpdateLocalDrivingLicensesApplication();
            _OpenChildForm(frm);
        }

        private void localDrivingLicensesApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplications frm = new ManageLocalDrivingLicenseApplications();
            _OpenChildForm(frm);
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDriversFRM frm = new ShowDriversFRM();
            _OpenChildForm(frm);
        }

        private void internationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseFRM frm = new IssueInternationalLicenseFRM();
            _OpenChildForm(frm);
        }

        private void internationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllInternationalLicensesesFRM frm = new ShowAllInternationalLicensesesFRM();
            _OpenChildForm(frm);
        }

        private void renewDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseFRM frm = new RenewLicenseFRM();
            _OpenChildForm(frm);
        }

        private void rewplacmentForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceLicenseForLostOrDamagedFRM frm = new ReplaceLicenseForLostOrDamagedFRM();
            _OpenChildForm(frm);
        }

        private void detainLicensesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetainLicensesFRM frm = new DetainLicensesFRM();
            _OpenChildForm(frm);
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFRM frm = new ReleaseDetainedLicenseFRM();
            _OpenChildForm(frm);
        }

        private void manageDetainedLicneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetainedLicensesListFRM frm = new ShowDetainedLicensesListFRM();
            _OpenChildForm(frm);
        }
    }
}


