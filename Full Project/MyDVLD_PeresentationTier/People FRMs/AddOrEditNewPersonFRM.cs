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

namespace MyDVLD_PeresentationTier
{
    public partial class AddOrUpdatePersonFRM : Form
    {
        private clsPeopleManagement _SelectedPerson = clsPeopleManagement.Find(-1);
        private int _UpdateID = -1;

        public AddOrUpdatePersonFRM(int PersonId = -1)
        {
            InitializeComponent();

            if (PersonId != -1 && clsPeopleManagement.IsPersonExsists(PersonId))
                _UpdateID = PersonId;
        }

        private void _LoadDefault()
        {
            rbMale.Checked = true;

            clsCountriesManagement.GetAllCountries().ForEach(country => cbCountry.Items.Add(country));

            cbCountry.SelectedItem = "United States";

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
        }

        private void AddOrUpdatePersonFRM_Load(object sender, EventArgs e)
        {
            _LoadDefault();

            if (_UpdateID != -1)
            {
                lblAddOrUpdateuserInpute.Text = "Update Person Info";

                _SelectedPerson = clsPeopleManagement.Find(_UpdateID);
                _FillDataToControls();
            }

            if (!string.IsNullOrWhiteSpace(_SelectedPerson.ImagePath))
                pbPersonImage.ImageLocation = _SelectedPerson.ImagePath;

            lblRemoveImage.Visible = (!string.IsNullOrEmpty(_SelectedPerson.ImagePath));
        }

        private bool _HandlePersonImage()
        {
            if (_SelectedPerson.ImagePath == pbPersonImage.ImageLocation)
                return true;

            if (File.Exists(_SelectedPerson.ImagePath))
            {
                pbPersonImage.Image?.Dispose();
                pbPersonImage.Image = rbMale.Checked ? Resources.Male_512 : Resources.Female_512;

                File.Delete(_SelectedPerson.ImagePath);
            }

            if (!string.IsNullOrWhiteSpace(pbPersonImage.ImageLocation))
            {
                string newPath = pbPersonImage.ImageLocation;

                if (!clsUtil.CopyImageToProjectImagesFolder(ref newPath))
                    throw new IOException("Error copying image file");

                pbPersonImage.ImageLocation = newPath;
                _SelectedPerson.ImagePath = newPath;
            }

            return true;
        }

        private void _GetUserInfoFromFRM()
        {
            _SelectedPerson.FirstName = txtFirstName.Text.Trim();
            _SelectedPerson.SecondName = txtSecondName.Text.Trim();
            _SelectedPerson.ThirdName = tbThirdName.Text.Trim();
            _SelectedPerson.LastName = txtFourthName.Text.Trim();
            _SelectedPerson.NationalNo = txtNationalNumber.Text.Trim();
            _SelectedPerson.DateOfBirth = dtpDateOfBirth.Value;
            _SelectedPerson.Gender = (rbMale.Checked) ? "Male" : "Female";
            _SelectedPerson.Address = txtAddress.Text.Trim();
            _SelectedPerson.Email = txtEmail.Text.Trim();
            _SelectedPerson.Phone = txtPhoneNumber.Text.Trim();
            _SelectedPerson.NationalityCountryID = clsCountriesManagement.GetCountryIDByName(cbCountry.Text.Trim());

            if (pbPersonImage.ImageLocation != null)
                _SelectedPerson.ImagePath = pbPersonImage.ImageLocation;
            else
                _SelectedPerson.ImagePath = string.Empty;
        }

        private bool _SavePersonInfoToDB()
        {
            if (!_HandlePersonImage())
                return false;

            _GetUserInfoFromFRM();

            if (_SelectedPerson.Save())
            {
                lblAddOrUpdateuserInpute.Text = "Update Person Info";
                lblUserId.Text = _SelectedPerson.PersonID.ToString();
                ctrlShowPersonDetails.ReFreshPersonDetails?.Invoke(_SelectedPerson.PersonID);

                return true;
            }

            return false;
        }

        private void btnSavePersonInfo_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            if (_SavePersonInfoToDB())
                MessageBox.Show("Person Info Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to Save Person Info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                GeneralErrorprov.SetError(((TextBox)sender), "Please Enter Valid Inpute");
            }
            else
                GeneralErrorprov.SetError(((TextBox)sender), "");
        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            string nationalNumber = txtNationalNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(nationalNumber) || !nationalNumber.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                GeneralErrorprov.SetError(txtNationalNumber, "Please enter a valid National Number!");
                return;
            }

            if (clsPeopleManagement.IsPersonExsists(nationalNumber) && nationalNumber != _SelectedPerson.NationalNo)
            {
                e.Cancel = true;
                GeneralErrorprov.SetError(txtNationalNumber, "This National Number is already in use!");
                return;
            }

            GeneralErrorprov.SetError(txtNationalNumber, null);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text) || !txtPhoneNumber.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                GeneralErrorprov.SetError(txtPhoneNumber, "Please Enter Valid Phone Number!");
            }
            else
                GeneralErrorprov.SetError(txtPhoneNumber, null);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                GeneralErrorprov.SetError(txtEmail, "Please Enter Valid Email!");
            }
            else
                GeneralErrorprov.SetError(txtEmail, "");
        }

        private void lblChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChooseImageFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ChooseImageFileDialog.FilterIndex = 1;
            ChooseImageFileDialog.RestoreDirectory = true;

            if (ChooseImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = ChooseImageFileDialog.FileName;
                lblRemoveImage.Visible = true;
            }
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblRemoveImage.Visible = false;
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                pbPersonImage.Image = rbMale.Checked ? Resources.Male_512 : Resources.Female_512;
        }

        private void _FillDataToControls()
        {
            txtFirstName.Text = _SelectedPerson.FirstName;
            txtSecondName.Text = _SelectedPerson.SecondName;
            tbThirdName.Text = _SelectedPerson.ThirdName;
            txtFourthName.Text = _SelectedPerson.LastName;
            txtNationalNumber.Text = _SelectedPerson.NationalNo;
            dtpDateOfBirth.Value = _SelectedPerson.DateOfBirth;
            lblUserId.Text = _SelectedPerson.PersonID.ToString();

            rbMale.Checked = (_SelectedPerson.Gender.ToLower().Trim() == "male");
            rbFemale.Checked = (_SelectedPerson.Gender.ToLower().Trim() == "female");

            txtAddress.Text = _SelectedPerson.Address;
            txtEmail.Text = _SelectedPerson.Email;
            txtPhoneNumber.Text = _SelectedPerson.Phone;

            cbCountry.Text = clsCountriesManagement.GetCountryNameByID(_SelectedPerson.NationalityCountryID).Trim();
        }

        private void btnCloseFRM_Click_1(object sender, EventArgs e) => Close();
    }
}

