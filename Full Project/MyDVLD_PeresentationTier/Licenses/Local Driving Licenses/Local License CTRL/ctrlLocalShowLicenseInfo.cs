using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses
{
    public partial class ctrlLocalShowLicenseInfo : UserControl
    {
        public ctrlLocalShowLicenseInfo()
        {
            InitializeComponent();
        }

        private clsLicenseManagement _LicenseInfo = clsLicenseManagement.Find(-1);

        private void _DecleratePicture()
        {
            string ImagePath = _LicenseInfo.Driver.Person.ImagePath;

            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.ImageLocation = ImagePath;
                    return;
                }
            }

            if (_LicenseInfo.Driver.Person.Gender == "Male")
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }

        private void _DeclerateLicenseInfo()
        {
            lblIsDetained.Text = (_LicenseInfo.IsLicenseDetained)? "Yes" : "No";
            lblIsActive.Text = (_LicenseInfo.IsActive)? "Yes" : "No"; 

            lblClass.Text = _LicenseInfo.LicenseClass.ClassName;
            lblNotes.Text = _LicenseInfo.Notes;
            lblDateOfBirth.Text = _LicenseInfo.Driver.Person.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _LicenseInfo.Driver.DriverID.ToString();
            lblExpirationDate.Text = _LicenseInfo.ExpirationDate.ToShortDateString();
            lblFullName.Text = _LicenseInfo.Driver.Person.FullName;
            lblGender.Text = _LicenseInfo.Driver.Person.Gender;
            lblIssueDate.Text = _LicenseInfo.IssueDate.ToShortDateString();
            lblLicenseID.Text = _LicenseInfo.LicenseID.ToString();
            lblNationalNo.Text = _LicenseInfo.Driver.Person.NationalNo;
            lblIssueReason.Text = _LicenseInfo.LicenseIssueReasonText;

            _DecleratePicture();
        }

        public void LoadLicenseInfoUsingLocalAppID(int LocalAppID)
        {
            clsLocalLicesnseApplicationManagement _LocalApp = clsLocalLicesnseApplicationManagement.Find(LocalAppID);

            int DriverID = clsDriversManagement.FindByPersonID(_LocalApp.ApplicantPerson.PersonID).DriverID ?? -1;
            _LicenseInfo = clsLicenseManagement.Find(DriverID, _LocalApp.LicenseClass.ClassID);

            _DeclerateLicenseInfo();
        }

        public void LoadLicenseInfoUsingLicenseID(int LicenseID)
        {
            _LicenseInfo = clsLicenseManagement.Find(LicenseID);
            _DeclerateLicenseInfo();
        }
    }
}
