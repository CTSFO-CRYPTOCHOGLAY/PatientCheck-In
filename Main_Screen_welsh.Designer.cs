
namespace NHS_SelfCheckIn
{
    partial class Main_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.WelcomeTitleTXT = new System.Windows.Forms.Label();
            this.Lanagugebtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.Startbtn = new System.Windows.Forms.Button();
            this.HelpMessageTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeTitleTXT
            // 
            this.WelcomeTitleTXT.AutoSize = true;
            this.WelcomeTitleTXT.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeTitleTXT.Location = new System.Drawing.Point(243, 9);
            this.WelcomeTitleTXT.Name = "WelcomeTitleTXT";
            this.WelcomeTitleTXT.Size = new System.Drawing.Size(735, 53);
            this.WelcomeTitleTXT.TabIndex = 0;
            this.WelcomeTitleTXT.Text = "CROESO I WIRIO GWIRIONEDD Y GIG YN";
            this.WelcomeTitleTXT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lanagugebtn
            // 
            this.Lanagugebtn.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lanagugebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lanagugebtn.Image = ((System.Drawing.Image)(resources.GetObject("Lanagugebtn.Image")));
            this.Lanagugebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lanagugebtn.Location = new System.Drawing.Point(400, 506);
            this.Lanagugebtn.Name = "Lanagugebtn";
            this.Lanagugebtn.Size = new System.Drawing.Size(500, 200);
            this.Lanagugebtn.TabIndex = 1;
            this.Lanagugebtn.Text = "     Dewis Iaith";
            this.Lanagugebtn.UseVisualStyleBackColor = true;
            this.Lanagugebtn.Click += new System.EventHandler(this.Lanagugebtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminbtn.Location = new System.Drawing.Point(13, 13);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(200, 100);
            this.adminbtn.TabIndex = 2;
            this.adminbtn.Text = "Modd Glân Gweinyddol";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Startbtn.Image = ((System.Drawing.Image)(resources.GetObject("Startbtn.Image")));
            this.Startbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Startbtn.Location = new System.Drawing.Point(400, 300);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(500, 200);
            this.Startbtn.TabIndex = 3;
            this.Startbtn.Text = "        pwyswch yma i ddechrau";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // HelpMessageTXT
            // 
            this.HelpMessageTXT.AutoSize = true;
            this.HelpMessageTXT.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelpMessageTXT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpMessageTXT.Location = new System.Drawing.Point(198, 135);
            this.HelpMessageTXT.Name = "HelpMessageTXT";
            this.HelpMessageTXT.Size = new System.Drawing.Size(984, 148);
            this.HelpMessageTXT.TabIndex = 4;
            this.HelpMessageTXT.Text = resources.GetString("HelpMessageTXT.Text");
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.HelpMessageTXT);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.Lanagugebtn);
            this.Controls.Add(this.WelcomeTitleTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Screen";
            this.Text = "GWIRIO HUNAN Y GIG MEWN SGRIN IAITH";
            this.Click += new System.EventHandler(this.Main_Screen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeTitleTXT;
        private System.Windows.Forms.Button Lanagugebtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label HelpMessageTXT;
    }
}

