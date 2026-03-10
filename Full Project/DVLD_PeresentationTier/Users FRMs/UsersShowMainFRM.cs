using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Users_FRMs;
using MyDVLD_PeresentationTier.Users_FRMs.Users_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyDVLD_PeresentationTier
{
    public partial class UsersShowMainFRM : Form
    {
        public UsersShowMainFRM()
        {
            InitializeComponent();
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => this.Close();

        private void _RefreshUsersFRM()
        {
            dgvUsersData.DataSource = clsUsersManagement.GetSystemUsers();
            lblNumberOfUsers.Text = dgvUsersData.Rows.Count.ToString();

            dgvUsersData.Columns[0].HeaderText = "User ID";
            dgvUsersData.Columns[0].Width = 130;
            
            dgvUsersData.Columns[1].HeaderText = "Person ID";
            dgvUsersData.Columns[1].Width = 130;

            dgvUsersData.Columns[2].HeaderText = "Full Name";
            dgvUsersData.Columns[2].Width = 270;

            dgvUsersData.Columns[3].HeaderText = "User Name";
            dgvUsersData.Columns[3].Width = 130;

            dgvUsersData.Columns[4].HeaderText = "Is Active";
            dgvUsersData.Columns[4].Width = 130;
        }

        private void UsersShowMainFRM_Load(object sender, EventArgs e)
        {
            cbFillterOptions.SelectedIndex = 0;
            _RefreshUsersFRM();
        }

        private void cbFillterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFillterValue.Text = string.Empty;

            tbFillterValue.Visible = cbFillterOptions.SelectedIndex != 0 && cbFillterOptions.SelectedIndex != 5;
            cbUserActive.Visible = cbFillterOptions.SelectedIndex == 5;
        }

        private void tbFillterValue_TextChanged(object sender, EventArgs e)
        {
            string FillterValue = tbFillterValue.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(FillterValue))
            {
                _RefreshUsersFRM();
                return;
            }

            string FillterColumn = string.Empty;

            switch (cbFillterOptions.Text.Trim())
            {
                case "User ID":
                    FillterColumn = "UserID"; break;
                case "Person ID":
                    FillterColumn = "PersonID"; break;
                case "User Name":
                    FillterColumn = "UserName"; break;
                case "Full Name":
                    FillterColumn = "FullName"; break;
            }

            dgvUsersData.DataSource = clsUsersManagement.GetSystemUsersFilltered(FillterColumn , FillterValue);
            lblNumberOfUsers.Text = dgvUsersData.Rows.Count.ToString();
        }

        private void cbUserActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IsUserActive = cbUserActive.Text.ToLower().Trim();

            if (IsUserActive == "all")
            {
                _RefreshUsersFRM();
                return;
            }

            dgvUsersData.DataSource = clsUsersManagement.GetSystemUsersFilltered("IsActive", IsUserActive);
            lblNumberOfUsers.Text = dgvUsersData.Rows.Count.ToString();
        }

        private void tbFillterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFillterOptions.SelectedIndex == 1 || cbFillterOptions.SelectedIndex == 3)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUserFRM addNew = new AddNewUserFRM((int)dgvUsersData.CurrentRow.Cells[0].Value);
            addNew.ShowDialog();
            _RefreshUsersFRM();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetailsFRM showUser = new ShowUserDetailsFRM((int)dgvUsersData.CurrentRow.Cells[0].Value);
            showUser.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChangePasswordFRM passwordFRM = new ShowChangePasswordFRM((int)dgvUsersData.CurrentRow.Cells[0].Value);
            passwordFRM.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            int UserToDeleteID = (int)dgvUsersData.CurrentRow.Cells[0].Value;

            if (UserToDeleteID != clsUtil.SignedInUser.UserID)
            {
                if (clsUsersManagement.DeleteUser(UserToDeleteID))
                {
                    _RefreshUsersFRM();
                    MessageBox.Show("User Deleted Successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("User Can Not Be Deleted As There Is Data Connected To It!.", "Error While Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("User Can't Be Deleted As He Is In Use!.", "Error While Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _NotImplementedFeatur() => MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Implemented!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) => _NotImplementedFeatur();

        private void sendPasswordToolStripMenuItem_Click(object sender, EventArgs e) => _NotImplementedFeatur();

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddNewUserFRM addNew = new AddNewUserFRM();
            addNew.ShowDialog();

            _RefreshUsersFRM();
        }
    }
}
