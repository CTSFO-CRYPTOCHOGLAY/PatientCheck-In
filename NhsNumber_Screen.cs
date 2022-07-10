using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication3;

namespace NHS_SelfCheckIn
{
    public partial class NhsNumber_Screen : Form
    {
        ComfirmCancelReschedule_Screen f1 = new ComfirmCancelReschedule_Screen();
        number number; 

        public NhsNumber_Screen()
        {
            InitializeComponent();
        }

        private void NhsNumber_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void Enter1btn_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void home3btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void Pre1btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppFinderForPatients f1 = new AppFinderForPatients();
            f1.Show();
        }
        private void textbox_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            //NameTXT.Text = "TextBox " + tb.Name + " GotFocus " + DateTime.Now.ToString();

            if (number == null)
            {
                number = new number();
                number.FormClosed += delegate
                {
                    number = null;
                    //this.ActiveControl = NameTXT;


                };
            }
            number.setTextBoxForOutput(tb);
            number.Show();

            number.Left = this.Left + tb.Left +
                tb.Width + 30;
            number.Top = this.Top + tb.Top + tb.Height + 11;
        }

        private void NHSNOBox_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
