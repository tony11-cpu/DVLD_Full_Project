using MyDVLD_BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Application_Types
{
    public partial class EditApplicationFRM : Form
    {

        private clsApplicationTypeManagement _AppType = null;
        
        public EditApplicationFRM(int AppID)
        {
            InitializeComponent();

            _AppType = clsApplicationTypeManagement.Find(AppID);
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => Close();

        private void btnSavePersonInfo_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            _AppType.ApplicationTitle = tbApplicationTitle.Text.Trim();
            _AppType.ApplicationFees = Convert.ToSingle(tbApplicationFees.Text.Trim());

            if (_AppType.Save())
            {
                MessageBox.Show($"Application With ID: {lblAppID.Text} Has Been Updated Successfully.", "Updated Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"Error While Updating The Application.", "Error Updating The App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _FillUpdateInfo()
        { 
            lblAppID.Text = ((short)_AppType.ApplicationService).ToString();
            tbApplicationFees.Text = _AppType.ApplicationFees.ToString();
            tbApplicationTitle.Text = _AppType.ApplicationTitle.Trim();

            tbApplicationTitle.Focus();
        }

        private void EditApplicationFRM_Load(object sender, EventArgs e)
        {
            if (_AppType == null)
                return;

            _FillUpdateInfo();
        }

        private void tbApplicationTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbApplicationTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTitle, "Please Make Sure The Title Is Not Empty!");
            }
            else
                errorProvider1.SetError(tbApplicationTitle, null);
        }

        private void tbApplicationFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationFees.Text) 
                || !float.TryParse(tbApplicationFees.Text.Trim(), out float AppFees) 
                || AppFees == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationFees, "Please Make Sure The Application Fees Is Filled And Not 0!");
            }
            else
                errorProvider1.SetError(tbApplicationFees, null);
        }
    }
}
