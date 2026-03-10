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

namespace MyDVLD_PeresentationTier.Test_Types
{
    public partial class EditTestTypeFRM : Form
    {
        private clsTestTypesManagement _TestType = clsTestTypesManagement.Find(-1);

        private void _FillUpdateInfo()
        {
            lblAppID.Text = Convert.ToInt32(_TestType.TestType).ToString();
            tbTestDescriptiopn.Text = _TestType.TestDescription;
            tbTestTitle.Text = _TestType.TestTitle;
            tbTestFees.Text = _TestType.TestTypeFees.ToString();

            tbTestTitle.Focus();
        }

        public EditTestTypeFRM(int TestID)
        {
            InitializeComponent();
            
            _TestType = clsTestTypesManagement.Find(TestID);
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => Close();

        private void tbTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbTestTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestTitle, "Please Make Sure The Title Is Not Empty!");
            }
            else
                errorProvider1.SetError(tbTestTitle, null);
        }

        private void tbTestFees_Validating(object sender, CancelEventArgs e)
        {
            if (!float.TryParse(tbTestFees.Text, out float TestfeesTT) 
                || TestfeesTT == 0 
                || string.IsNullOrEmpty(tbTestFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestFees, "Please Make Sure The Fees Is Not 0 , Empty ,And Its A Number!");
            }
            else
                errorProvider1.SetError(tbTestFees, null);
        }

        private void btnSavePersonInfo_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            _TestType.TestTitle = tbTestTitle.Text.Trim();
            _TestType.TestDescription = tbTestDescriptiopn.Text.Trim();
            _TestType.TestTypeFees = Convert.ToSingle(tbTestFees.Text.Trim());

            if (_TestType.Save())
            {
                MessageBox.Show($"Test With ID: {lblAppID.Text} Has Been Updated Successfully.", "Updated Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"Error While Updating The Test.", "Error Updating The Test.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditTestTypeFRM_Load(object sender, EventArgs e)
        {
            if(_TestType == null)
                return;

            _FillUpdateInfo();
        }
    }
}
