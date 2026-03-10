using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.Licenses.International_LIcenses_Application
{
    public partial class ShowInternationalLicenseInfoFRM : Form
    {
        private int _InternationalLicenseID = -1;

        public ShowInternationalLicenseInfoFRM(int InternationalLicenseID)
        {
            InitializeComponent();

            _InternationalLicenseID = InternationalLicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
             ctrlInternationalLicenseInfo1.LoadInternationalLicenseInfo(_InternationalLicenseID);
        }
    }
}
