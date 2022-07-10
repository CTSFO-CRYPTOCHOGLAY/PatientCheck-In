using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class NewDate_Screen : Form
    {
        ComfrimDecline_Screen f2 = new ComfrimDecline_Screen();
        public static DateTime DatePicked1;

        public NewDate_Screen()
        {
            InitializeComponent();
        }

        private void Next1btn_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void home8btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void NewDate_Screen_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void NewDate_Screen_Enter(object sender, EventArgs e)
        {

        }
    }
}
