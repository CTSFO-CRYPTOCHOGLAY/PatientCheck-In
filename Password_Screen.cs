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
    public partial class Password_Screen : Form
    {
        Clean_Screen f1 = new Clean_Screen();
        number number;

        public Password_Screen()
        {
            InitializeComponent();
        }

        private void Password_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (PasscodeBox.Text == "2001")
            {

                MessageBox.Show("Succesful");
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong PassCode");
            }
            }

        private void PasscodeBox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
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

        private void Password_Screen_LocationChanged(object sender, EventArgs e)
        {
            //
        }

        private void Password_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            number.Close();
        }
    }
    }

