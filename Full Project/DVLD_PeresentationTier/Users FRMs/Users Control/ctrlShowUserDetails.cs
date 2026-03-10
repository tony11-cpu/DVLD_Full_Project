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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyDVLD_PeresentationTier.Users_FRMs.Users_Control
{
    public partial class ctrlShowUserDetails : UserControl
    {
        public ctrlShowUserDetails()
        {
            InitializeComponent();
        }

        public void LoadUserDetails(int UserID)
        {
            clsUsersManagement ShowUser = clsUsersManagement.Find(UserID);

            lblUserID.Text = UserID.ToString();
            lblUsername.Text = ShowUser.Username;

            if (ShowUser.IsActive)
                lblIsActive.Text = "Active";
            else
                lblIsActive.Text = "Not Active";

            ctrlShowPersonDetails1.LoadPersonDetails(ShowUser.PerosnInfo.PersonID);
        }
    }
}
