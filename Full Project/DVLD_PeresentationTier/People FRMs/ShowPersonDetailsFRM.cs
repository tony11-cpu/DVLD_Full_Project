using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier
{
    public partial class ShowPersonDetailsFRM : Form
    {
        private int? _PersonId = null;
        private string _NationalNumber = null;

        public ShowPersonDetailsFRM(int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;
        }

        public ShowPersonDetailsFRM(string NationalNo)
        {
            InitializeComponent();
            _NationalNumber = NationalNo;
        }

        private void btnCloseFRM_Click(object sender, EventArgs e) => Close();

        private void ShowPersonDetailsFRM_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(_NationalNumber))
                ctrlShowPersonDetails1.LoadPersonDetails(_NationalNumber);
            else
                ctrlShowPersonDetails1.LoadPersonDetails(_PersonId ?? -1);
        }
    }
}
