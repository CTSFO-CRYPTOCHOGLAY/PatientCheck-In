using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3;

namespace WindowsFormsPopupKeyboard
{
    
    public partial class Keyboard : Form
    {
        TextBox tt;        

        
        public Keyboard()
        {
            InitializeComponent();
            this.TopMost = true;  // make the keyboard always in front of the other forms
        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;  // 
        }


        private void button_Click(object sender, EventArgs e)
        {
                
             tt.Text += ((Button)sender).Text;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void Bkspacebtn_Click(object sender, EventArgs e)
        {
            string ch = ((Button)sender).Text;
            String buttonName = ((Button)sender).Name;

            if (tt.Text.Length > 0)
            {
                int len = tt.Text.Length;
                tt.Text = tt.Text.Remove(len - 1);
            }
        }
        
        private void CapsONbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpperKey f1 = new UpperKey();
            f1.Show();
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
