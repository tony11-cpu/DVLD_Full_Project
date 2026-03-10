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
    public partial class ShowLocalLicenseInfoFRM : Form
    {
        public ShowLocalLicenseInfoFRM(int? ID)
        {
            InitializeComponent();
            
            if(clsLicenseManagement.IsLicenseExists(ID ?? -1))
                 ctrlShowLicenseInfo1.LoadLicenseInfoUsingLicenseID(ID ?? -1);
            else
                 ctrlShowLicenseInfo1.LoadLicenseInfoUsingLocalAppID(ID ?? -1);
        }
    }
}
