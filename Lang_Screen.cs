using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class Lang_Screen : Form
    
    {
        
        public Lang_Screen()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
          
        }

        private void homebtn_ClientSizeChanged(object sender, EventArgs e)
        {
            //Accident
        }
    }
}
