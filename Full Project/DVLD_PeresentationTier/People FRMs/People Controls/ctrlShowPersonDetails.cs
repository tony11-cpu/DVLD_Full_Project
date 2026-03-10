using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyDVLD_PeresentationTier
{
    public partial class ctrlShowPersonDetails : UserControl
    {
        public ctrlShowPersonDetails() => InitializeComponent();

        public static Action<int> ReFreshPersonDetails = null;

        private Image GetImageFromPath(string imagePath, string gender)
        {
            if (string.IsNullOrEmpty(imagePath) && gender == "male")
                return Resources.Male_512;
            else if (string.IsNullOrEmpty(imagePath) && gender == "female")
                return Resources.Female_512;

            return LoadImage(imagePath);
        }

        private Image LoadImage(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
                return null;

            using (var temp = new Bitmap(path))
                return new Bitmap(temp); 
        }

        private void _ShowPersonDetails()
        {
            lblAddress.Text = PersonDetails.Address;
            lblDateOfBirth.Text = PersonDetails.DateOfBirth.ToShortDateString();
            lblEmail.Text = string.IsNullOrEmpty(PersonDetails.Email)? "No Email": PersonDetails.Email;
            lblGender.Text = PersonDetails.Gender;
            lblNationalNo.Text = PersonDetails.NationalNo;
            lblPersonId.Text = PersonDetails.PersonID.ToString();
            lblPhoneNumber.Text = PersonDetails.Phone;
            lblCountry.Text = clsCountriesManagement.GetCountryNameByID(PersonDetails.NationalityCountryID);
            lbPersonName.Text = PersonDetails.FullName;
            pbPeronPicture.Image = GetImageFromPath(PersonDetails.ImagePath, PersonDetails.Gender.ToLower());
        }

        public clsPeopleManagement PersonDetails = clsPeopleManagement.Find(-1);

        public void ResetPersonInfo()
        {
            lblPersonId.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lbPersonName.Text = "[????]";
            pbPeronPicture.Image = Resources.Male_512;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhoneNumber.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
        }

        public void LoadPersonDetails(int PersonID)
        {
            PersonDetails = clsPeopleManagement.Find(PersonID);
            _ShowPersonDetails();
        }

        public void LoadPersonDetails(string PersonNationalNumber)
        {
            PersonDetails = clsPeopleManagement.Find(PersonNationalNumber);
            _ShowPersonDetails();
        }

        private void lblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrUpdatePersonFRM editPersonFRM = new AddOrUpdatePersonFRM(PersonDetails.PersonID);
            editPersonFRM.ShowDialog();

            PeopleShowMainFRM.RefreshPeople?.Invoke();
            this.LoadPersonDetails(PersonDetails.PersonID);
        }
    }
}
