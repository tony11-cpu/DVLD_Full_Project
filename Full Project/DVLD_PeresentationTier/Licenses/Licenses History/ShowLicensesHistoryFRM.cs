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

namespace MyDVLD_PeresentationTier.Licenses
{
    public partial class ShowLicensesHistoryFRM : Form
    {
        private clsDriversManagement _Driver = clsDriversManagement.Find(-1);

        public ShowLicensesHistoryFRM(int PersonID)
        {
            InitializeComponent();
            _Driver = clsDriversManagement.FindByPersonID(PersonID);
        }

        private void ShowLicensesHistoryFRM_Load(object sender, EventArgs e)
        {   
            if(_Driver.DriverID == null)
            {
                MessageBox.Show("Driver Do Not Exists!" , "Failed To Load Driver!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                this.Close();
            }

            ctrlShowPersonDetailsWithSearch1.LoadPersonInfo(_Driver.Person.PersonID);
            ctrlShowPersonDetailsWithSearch1.FilterEnabled = false;

            ctrlLicensesHistory1.LoadLicensesHistory(_Driver.DriverID ?? -1);
        }
    }
}
