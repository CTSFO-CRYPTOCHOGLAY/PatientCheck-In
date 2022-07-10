using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    
    public partial class ComfrimDecline_Screen : Form
    {
        BookingCom f2 = new BookingCom();
        public ComfrimDecline_Screen()
        {
            InitializeComponent();
        }

        private void home7btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void Comfirmbtn_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }
    }
}
