using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class Main_Screen : Form
    {
        AppFinderForPatients f2 = new AppFinderForPatients();
        Lang_Screen f3 = new Lang_Screen();
        Password_Screen f4 = new Password_Screen();
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
           
           f2.Show();
           this.Hide();
        }

        private void Lanagugebtn_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void Main_Screen_Click(object sender, EventArgs e)
        {
            // Not need atb this point
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }
    }
}
