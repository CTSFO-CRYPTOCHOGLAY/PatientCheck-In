
using System;

namespace NHS_SelfCheckIn
{
    partial class Password_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Screen));
            this.PasscodeTXT = new System.Windows.Forms.Label();
            this.PasscodeBox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.AdminTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasscodeTXT
            // 
            this.PasscodeTXT.AutoSize = true;
            this.PasscodeTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasscodeTXT.Location = new System.Drawing.Point(200, 200);
            this.PasscodeTXT.Name = "PasscodeTXT";
            this.PasscodeTXT.Size = new System.Drawing.Size(260, 73);
            this.PasscodeTXT.TabIndex = 0;
            this.PasscodeTXT.Text = "Passcode";
            // 
            // PasscodeBox
            // 
            this.PasscodeBox.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasscodeBox.Location = new System.Drawing.Point(450, 195);
            this.PasscodeBox.Name = "PasscodeBox";
            this.PasscodeBox.PasswordChar = '*';
            this.PasscodeBox.Size = new System.Drawing.Size(500, 81);
            this.PasscodeBox.TabIndex = 1;
            this.PasscodeBox.TextChanged += new System.EventHandler(this.PasscodeBox_TextChanged);
            this.PasscodeBox.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Loginbtn.Location = new System.Drawing.Point(360, 310);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(500, 200);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // AdminTXT
            // 
            this.AdminTXT.AutoSize = true;
            this.AdminTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminTXT.Location = new System.Drawing.Point(430, 9);
            this.AdminTXT.Name = "AdminTXT";
            this.AdminTXT.Size = new System.Drawing.Size(342, 73);
            this.AdminTXT.TabIndex = 3;
            this.AdminTXT.Text = "Admin Login";
            // 
            // Password_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.AdminTXT);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasscodeBox);
            this.Controls.Add(this.PasscodeTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password_Screen";
            this.Text = "Password Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Password_Screen_FormClosing);
            this.Load += new System.EventHandler(this.Password_Screen_Load);
            this.LocationChanged += new System.EventHandler(this.Password_Screen_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label PasscodeTXT;
        private System.Windows.Forms.TextBox PasscodeBox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label AdminTXT;
    }
}