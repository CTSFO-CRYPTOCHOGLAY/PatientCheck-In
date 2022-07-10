
using System;

namespace NHS_SelfCheckIn
{
    partial class Name_Dob_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Name_Dob_Screen));
            this.NameTXT = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.SurnmaeLastnametextBox1 = new System.Windows.Forms.TextBox();
            this.ORTXT = new System.Windows.Forms.Label();
            this.DateofBirthBox1 = new System.Windows.Forms.TextBox();
            this.home2btn = new System.Windows.Forms.Button();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.Prebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTXT
            // 
            this.NameTXT.AutoSize = true;
            this.NameTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTXT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.NameTXT.Location = new System.Drawing.Point(230, 9);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(833, 73);
            this.NameTXT.TabIndex = 0;
            this.NameTXT.Text = "Providing name or Date of birth ";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(400, 260);
            this.FirstNametextBox.MaxLength = 40;
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(500, 53);
            this.FirstNametextBox.TabIndex = 1;
            this.FirstNametextBox.Text = "Enter First Name ";
            this.FirstNametextBox.TextChanged += new System.EventHandler(this.FirstNametextBox_TextChanged);
            this.FirstNametextBox.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // SurnmaeLastnametextBox1
            // 
            this.SurnmaeLastnametextBox1.Location = new System.Drawing.Point(400, 320);
            this.SurnmaeLastnametextBox1.MaxLength = 80;
            this.SurnmaeLastnametextBox1.Name = "SurnmaeLastnametextBox1";
            this.SurnmaeLastnametextBox1.Size = new System.Drawing.Size(500, 53);
            this.SurnmaeLastnametextBox1.TabIndex = 2;
            this.SurnmaeLastnametextBox1.Text = "Enter Surename & Lastname";
            this.SurnmaeLastnametextBox1.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // ORTXT
            // 
            this.ORTXT.AutoSize = true;
            this.ORTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ORTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ORTXT.Location = new System.Drawing.Point(619, 386);
            this.ORTXT.Name = "ORTXT";
            this.ORTXT.Size = new System.Drawing.Size(121, 73);
            this.ORTXT.TabIndex = 3;
            this.ORTXT.Text = "OR ";
            // 
            // DateofBirthBox1
            // 
            this.DateofBirthBox1.Location = new System.Drawing.Point(400, 450);
            this.DateofBirthBox1.MaxLength = 8;
            this.DateofBirthBox1.Name = "DateofBirthBox1";
            this.DateofBirthBox1.ShortcutsEnabled = false;
            this.DateofBirthBox1.Size = new System.Drawing.Size(500, 53);
            this.DateofBirthBox1.TabIndex = 4;
            this.DateofBirthBox1.Text = "Enter Date of Birth ";
            this.DateofBirthBox1.TextChanged += new System.EventHandler(this.DateofBirthBox1_TextChanged);
            this.DateofBirthBox1.GotFocus += new System.EventHandler(this.textbox1_GotFocus);
            // 
            // home2btn
            // 
            this.home2btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home2btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.home2btn.Location = new System.Drawing.Point(10, 860);
            this.home2btn.Name = "home2btn";
            this.home2btn.Size = new System.Drawing.Size(200, 100);
            this.home2btn.TabIndex = 5;
            this.home2btn.Text = "Return Home ";
            this.home2btn.UseVisualStyleBackColor = true;
            this.home2btn.Click += new System.EventHandler(this.home2btn_Click);
            // 
            // Enterbtn
            // 
            this.Enterbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enterbtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Enterbtn.Location = new System.Drawing.Point(1050, 860);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(200, 100);
            this.Enterbtn.TabIndex = 6;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = true;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Prebtn
            // 
            this.Prebtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prebtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Prebtn.Location = new System.Drawing.Point(220, 860);
            this.Prebtn.Name = "Prebtn";
            this.Prebtn.Size = new System.Drawing.Size(200, 100);
            this.Prebtn.TabIndex = 7;
            this.Prebtn.Text = "Previous Page ";
            this.Prebtn.UseVisualStyleBackColor = true;
            this.Prebtn.Click += new System.EventHandler(this.Prebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 135);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Name_Dob_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Prebtn);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.home2btn);
            this.Controls.Add(this.DateofBirthBox1);
            this.Controls.Add(this.ORTXT);
            this.Controls.Add(this.SurnmaeLastnametextBox1);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.NameTXT);
            this.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Name_Dob_Screen";
            this.Text = "Name or DOB ";
            this.Load += new System.EventHandler(this.Name_Dob_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void numberbox_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label NameTXT;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox SurnmaeLastnametextBox1;
        private System.Windows.Forms.Label ORTXT;
        private System.Windows.Forms.TextBox DateofBirthBox1;
        private System.Windows.Forms.Button home2btn;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Button Prebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EventHandler textBox1_GotFocus;
    }
}