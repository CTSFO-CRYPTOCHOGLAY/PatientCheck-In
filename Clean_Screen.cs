using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace NHS_SelfCheckIn
{
    public partial class Clean_Screen : Form
    {
        public Clean_Screen()
        {
            InitializeComponent();
        }
       


        private void Home9btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var before = this.progressBar1.Value;
            this.progressBar1.Increment(1);
            var after = this.progressBar1.Value;
            if (after > before && after == this.progressBar1.Maximum)
            {
                MessageBox.Show("System Fully Cleaned ");
            }
        }

        private  void Cleanbtn_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }
    }
}

