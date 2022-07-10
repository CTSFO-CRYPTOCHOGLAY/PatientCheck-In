using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class number : Form
    {
        TextBox tt;
        

        public number()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;  // 
        }


        private void button6_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        private void number_Load(object sender, EventArgs e)
        {

        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            string ch = ((Button)sender).Text;
            String buttonName = ((Button)sender).Name;

            if (tt.Text.Length > 0)
            {
                int len = tt.Text.Length;
                tt.Text = tt.Text.Remove(len - 1);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
