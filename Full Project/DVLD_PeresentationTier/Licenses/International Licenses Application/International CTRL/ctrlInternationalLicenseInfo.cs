using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyDVLD_PeresentationTier.Licenses.Licenses_CTRL
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private clsInternationalLicenseManagement _Internationallicense = clsInternationalLicenseManagement.Find(-1);

        private void _DecleratePicture()
        {
            if (!string.IsNullOrEmpty(_Internationallicense.InternationalApplication.ApplicantPerson.ImagePath))
            {
                if (File.Exists(_Internationallicense.InternationalApplication.ApplicantPerson.ImagePath))
                {
                    pbPersonPhoto.ImageLocation = _Internationallicense.InternationalApplication.ApplicantPerson.ImagePath;
                    return;
                }
            }

            if (_Internationallicense.InternationalApplication.ApplicantPerson.Gender == "Male")
                pbPersonPhoto.Image = Resources.Male_512;
            else
                pbPersonPhoto.Image = Resources.Female_512;
        }

        private void _LoadLicenseInfo()
        {
            lblPersonName.Text = _Internationallicense.InternationalApplication.ApplicantPerson.FullName;
            lblNationalNo.Text = _Internationallicense.InternationalApplication.ApplicantPerson.NationalNo;
            lblLicenseID.Text = _Internationallicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = _Internationallicense.IssueDate.ToShortDateString();
            lblIsActive.Text = _Internationallicense.IsActive.ToString();
            lblInternationalLicenseID.Text = _Internationallicense.InternationalLicenseID.ToString() ?? "-1";
            lblGender.Text = _Internationallicense.InternationalApplication.ApplicantPerson.Gender;
            lblExpirationDate.Text = _Internationallicense.ExpirationDate.ToShortDateString();
            lblDriverID.Text = _Internationallicense.DriverID.ToString();
            lblDateOfBirth.Text = _Internationallicense.InternationalApplication.ApplicantPerson.DateOfBirth.ToShortDateString();
            lblAppID.Text = _Internationallicense.InternationalApplication.ApplicationID.ToString();

            _DecleratePicture();
        }

        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            _Internationallicense = clsInternationalLicenseManagement.Find(InternationalLicenseID);

            if(_Internationallicense.InternationalLicenseID == null)
            {
                MessageBox.Show("No License Found To Load." , "Error While Loading.!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }

            _LoadLicenseInfo();
        }
    }
}
