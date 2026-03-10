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

namespace MyDVLD_PeresentationTier.Applications.Application_CTRL
{
    public partial class ctrlShowApplicationInforamtion : UserControl
    {
        public ctrlShowApplicationInforamtion()
        {
            InitializeComponent();
        }

        private clsLocalLicesnseApplicationManagement _LocalInfoCard = clsLocalLicesnseApplicationManagement.Find(-1);

        public void LoadApplicationInfo(int AppID)
        {
            _LocalInfoCard = clsLocalLicesnseApplicationManagement.FindByApplicationID(AppID);

            if (_LocalInfoCard == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FindForm()?.Close();
            }

            _LoadInfo();
        }

        private void _LoadInfo()
        {
            lblApplicant.Text = _LocalInfoCard.ApplicantPerson.FullName ?? "N/A";
            lblApplicationID.Text = _LocalInfoCard.ApplicationID.ToString();
            lblDate.Text = _LocalInfoCard.ApplicationDate.ToShortDateString();

            lblFees.Text = _LocalInfoCard.ApplicationType?.ApplicationService != null ?
                clsApplicationTypeManagement.ApplicationFeesString(_LocalInfoCard.ApplicationType.ApplicationService) : "N/A";

            lblCreatedByUser.Text = _LocalInfoCard.CreatedByUser?.Username ?? "N/A";
            lblStatusDate.Text = _LocalInfoCard.LastStatusDate.ToShortDateString();
            lblStatus.Text = _LocalInfoCard.ApplicationStatus.ToString();
            lblType.Text = _LocalInfoCard.ApplicationType?.ApplicationTitle ?? "N/A";
        }

        private void llViewPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetailsFRM showPersonDetails = new ShowPersonDetailsFRM(_LocalInfoCard.ApplicantPerson.PersonID);
            showPersonDetails.ShowDialog();

            _LoadInfo();
        }
    }
}
