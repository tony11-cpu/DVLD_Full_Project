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

namespace MyDVLD_PeresentationTier.Users_FRMs
{
    public partial class ShowChangePasswordFRM : Form
    {
        private clsUsersManagement _UserToUpdate = clsUsersManagement.Find(-1);

        public ShowChangePasswordFRM(int UserID)
        {
            InitializeComponent();

            _UserToUpdate = clsUsersManagement.Find(UserID);
            ctrlShowUserDetails1.LoadUserDetails(_UserToUpdate.UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePasword_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                return;

            _UserToUpdate.Password = tbConfirmPassword.Text;

            if(_UserToUpdate.Save())
                MessageBox.Show("Password Changed." , "New Password" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error While Saving new Password", "Fialed To Save New Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tbNewPassword.Text = "";
            tbCurrentPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbCurrentPassword.Focus();
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Please Make Sure Password Is Maching!");
            }
            else
                errorProvider1.SetError(tbConfirmPassword, null);
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text)
                || tbNewPassword.Text.Length < 8 
                || !tbNewPassword.Text.All(Char.IsLetterOrDigit) 
                || clsUtil.clsSecurity.CheckUserPasswordMatchHashed(_UserToUpdate.UserID, tbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Please Make Sure The Password Does Not Contain Special Chars , It Must Be 8 (Letters/Numbers) Or More And Make The Password Diffrent From The Old One!");
            }
            else
                errorProvider1.SetError(tbNewPassword, null);
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!clsUtil.clsSecurity.CheckUserPasswordMatchHashed(_UserToUpdate.UserID, tbCurrentPassword.Text))
            { 
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Please Make Sure Password Is Maching!");
            }
            else
                errorProvider1.SetError(tbCurrentPassword, null);
        }
    }
}
