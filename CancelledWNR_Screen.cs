using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class CancelledWNR_Screen : Form
    {
        public CancelledWNR_Screen()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }
    }
}
