using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Project0
{
    public partial class AppMainFRM : Form
    {
        public AppMainFRM()
        {
            InitializeComponent();
        }

        private void AppMainFRM_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Tonyg\OneDrive\Desktop\Desktop Projects\Course 19 (DVLD) Project\Project Icons\Prof Refrence Icons\Icons\Icons\DVLD Logo.png");
            this.BackgroundImageLayout = ImageLayout.Center;
        }
    }
}
