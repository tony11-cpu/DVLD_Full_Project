using MyDVLD_BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_PeresentationTier.People_FRMs.People_Controls
{
    public partial class ctrlShowPersonDetailsWithSearch : UserControl
    {
        public event EventHandler<int> OnPersonSelected = null;
        
        public bool FilterEnabled
        {
            get { return gbFillter.Enabled; }
            set { gbFillter.Enabled = value; }
        }

        public int PersonId
        {
            get
            {
                return ctrlShowPersonDetails1.PersonDetails.PersonID;
            }
            set
            {
                ctrlShowPersonDetails1.PersonDetails.PersonID = value;
            }
        }

        public void FillterFocus()
        {
            tbFilterValue.Focus();
        }

        public void ResetFRM()
        {
            PersonId = -1;

            tbFilterValue.Text = string.Empty;
            ctrlShowPersonDetails1.ResetPersonInfo();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFillterData.SelectedIndex = 0;
            tbFilterValue.Text = PersonID.ToString();

            ctrlShowPersonDetails1.LoadPersonDetails(PersonID);
        }

        public void LoadPersonInfo(string PersonNationalNumnber)
        {
            cbFillterData.SelectedIndex = 1;
            tbFilterValue.Text = PersonNationalNumnber.ToString();

            ctrlShowPersonDetails1.LoadPersonDetails(PersonNationalNumnber);
        }

        public ctrlShowPersonDetailsWithSearch() => InitializeComponent();

        private void ctrlShowPersonDetailsWithSearch_Load(object sender, EventArgs e) => cbFillterData.SelectedIndex = 0;

        private void _FindPerson()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text.Trim()) || !tbFilterValue.Text.All(Char.IsLetterOrDigit))
            {
                MessageBox.Show("Make Sure To Valid Inpute Without Spaces Or Special Chars!", "Error Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int PersonID = default;
            bool IsPersonExsistsById = int.TryParse(tbFilterValue.Text.Trim(), out PersonID);

            switch (cbFillterData.SelectedIndex)
            {
                case 0:
                    if (IsPersonExsistsById && clsPeopleManagement.IsPersonExsists(PersonID))
                        LoadPersonInfo(PersonID);
                    else
                        MessageBox.Show("No Person Exists With This Id!", "Person Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    string NationalNumber = tbFilterValue.Text.Trim();

                    if (!clsPeopleManagement.IsPersonExsists(NationalNumber))
                    {
                        MessageBox.Show("No Person Exists With This National Number!", "Person Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LoadPersonInfo(NationalNumber);

                    PersonID = ctrlShowPersonDetails1.PersonDetails.PersonID;

                    break;
            }

            OnPersonSelected?.Invoke(null , PersonID);
        }

        private void btnSearchForFillteredPerson_Click(object sender, EventArgs e) => _FindPerson();

        private void btnAddNewpersonAndReturnAfterAdding_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonFRM frm = new AddOrUpdatePersonFRM();
            ctrlShowPersonDetails.ReFreshPersonDetails += ctrlShowPersonDetails1.LoadPersonDetails;
            frm.ShowDialog();

            if (PersonId != -1)
            {
                cbFillterData.SelectedIndex = 0;
                tbFilterValue.Text = PersonId.ToString();

                OnPersonSelected?.Invoke(null, PersonId);
            }
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchForFillteredPerson.PerformClick();
        }
    }
}
