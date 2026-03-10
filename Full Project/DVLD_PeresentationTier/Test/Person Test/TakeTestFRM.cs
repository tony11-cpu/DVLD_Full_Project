using MyDVLD_BusinessTier;
using MyDVLD_PeresentationTier.Applications.Manage_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyDVLD_BusinessTier.clsTestTypesManagement;

namespace MyDVLD_PeresentationTier.Test.Person_Test.Vision_Test
{
    public partial class TakeTestFRM : Form
    {
        private clsTestManagement _NewTest = clsTestManagement.Find(-1);

        public TakeTestFRM(int LocalDrivingLicenseApplicationID, enTestMode TestMode , int TestAppointmentID)
        {
            InitializeComponent();

            ctrlTestType1.TestMode = TestMode;

            ctrlTestType1.LoadApplicationTypeInfo(LocalDrivingLicenseApplicationID , TestAppointmentID);
            ctrlTestType1.LoadTakeTest();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void _FillDataToSave()
        {
            _NewTest.TestAppointmentID = ctrlTestType1.NewTestAppointment.TestAppointmentID ?? -1;
            _NewTest.Notes = tbNotes.Text;
            _NewTest.TestResult = (rbPass.Checked)? true : false;
            _NewTest.CreatedByUserID = ctrlTestType1.NewTestAppointment.CreatedByUserID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Save? If You Save You Cant Change The Result In The Future!" , 
                "Saving." ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _FillDataToSave();

                if (_NewTest.Save())
                {
                    MessageBox.Show("Data Saved Successfully!", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failled To Save Data!", "Error While Saved.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
