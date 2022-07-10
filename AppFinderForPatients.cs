using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class AppFinderForPatients : Form
    {
        Name_Dob_Screen f2 = new Name_Dob_Screen();
        NhsNumber_Screen f3 = new NhsNumber_Screen();
        QRcode_Screen f4 = new QRcode_Screen();
        
        


        public AppFinderForPatients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }

        private void Namebtn_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void NhsNobtn_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void home1btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void AppFinderForPatients_Load(object sender, EventArgs e)
        {
            // not need at this point
        }
    }
}
