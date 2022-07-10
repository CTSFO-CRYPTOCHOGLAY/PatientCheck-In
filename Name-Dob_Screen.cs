using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication3;
using WindowsFormsPopupKeyboard;

namespace NHS_SelfCheckIn
{
    public partial class Name_Dob_Screen : Form
     
    {
        Keyboard keyboard;
        number number;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static int SetValueForText3 = 0;

        ComfirmCancelReschedule_Screen f1 = new ComfirmCancelReschedule_Screen();

        
        public Name_Dob_Screen()
        {
            InitializeComponent();
            
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
           SetValueForText1 = FirstNametextBox.Text;
           SetValueForText2 = SurnmaeLastnametextBox1.Text;
           //SetValueForText3 = DateofBirthBox1.Text;
           f1.Show();
           this.Hide();
        }


        private void textBox_GotFocus(Object sender, EventArgs e)
        
        {
            TextBox tb = (TextBox)sender;

            //NameTXT.Text = "TextBox " + tb.Name + " GotFocus " + DateTime.Now.ToString();

            if (keyboard == null)
            {
                keyboard = new Keyboard();
                keyboard.FormClosed += delegate
                {
                    keyboard = null;
                    //this.ActiveControl = NameTXT;


                };
            }
            keyboard.setTextBoxForOutput(tb);
            keyboard.Show();

            keyboard.Left = this.Left + tb.Left + tb.Width + 30;
            keyboard.Top = this.Top + tb.Top + tb.Height + 11;


        }

        private void textbox1_GotFocus(Object sender, EventArgs e)
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

            number.Left = this.Left + tb.Left + tb.Width + 30;
            number.Top = this.Top + tb.Top + tb.Height + 11;
        }


        private void Name_Dob_Screen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = FirstNametextBox;
           SetValueForText3 = 28062001;

        }

        private void home2btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void Prebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppFinderForPatients f1 = new AppFinderForPatients();
            f1.Show();
        }

        private void FirstNametextBox_TextChanged(object sender, EventArgs e)
        {
            //comment 
        }

        private void DateofBirthBox1_TextChanged(object sender, EventArgs e)
        {
            //comment
        }
    }
}
