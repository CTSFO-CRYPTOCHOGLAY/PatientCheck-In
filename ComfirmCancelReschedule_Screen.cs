using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NHS_SelfCheckIn
{
    public partial class ComfirmCancelReschedule_Screen : Form
    {
        cancel_rebook_Screen f1 = new cancel_rebook_Screen();
        BookingCom f2 = new BookingCom();
        public static string SetValueForText1 = "Name: ";
        public static string SetValueForText2 = "Last-Name: ";
        public static string SetValueForText3 = " ";
        public static string SetValueForTetx4 = "Appointment Time ";

        public ComfirmCancelReschedule_Screen()
        {
            InitializeComponent();
            
        }

        private void CancelRebookbtn_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        

        private void home5btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void ComfirmCancelReschedule_Screen_Load(object sender, EventArgs e)
        {
            FirstNameTXT.Text = SetValueForText1 + Name_Dob_Screen.SetValueForText1 + SetValueForText3 + Name_Dob_Screen.SetValueForText2;
            //FirstNameTXT.Text = Name_Dob_Screen.SetValueForText3 
            TimeTXT1.Text = DateTime.Now.ToString();
        }

        private void FirstNameTXT_Click(object sender, EventArgs e)
        {

        }

        private void TimeTXT1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
