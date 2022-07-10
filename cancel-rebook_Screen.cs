using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class cancel_rebook_Screen : Form
    {
        NewDate_Screen f1 = new NewDate_Screen();
        CancelledWNR_Screen f2 = new CancelledWNR_Screen();
       

        public cancel_rebook_Screen()
        {
            InitializeComponent();
        }

        private void Canrbtn_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void carebookbtn_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void home6btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void pre3btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComfirmCancelReschedule_Screen f1 = new ComfirmCancelReschedule_Screen();
            f1.Show();
        }

        private void cancel_rebook_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
