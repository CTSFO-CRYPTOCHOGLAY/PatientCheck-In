using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class BookingCom : Form
    {
        public BookingCom()
        {
            InitializeComponent();
        }

        private void Home10btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }
    }
}
