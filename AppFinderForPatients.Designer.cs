
namespace NHS_SelfCheckIn
{
    partial class AppFinderForPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppFinderForPatients));
            this.AppFinderTXT = new System.Windows.Forms.TextBox();
            this.Namebtn = new System.Windows.Forms.Button();
            this.NhsNobtn = new System.Windows.Forms.Button();
            this.QRbtn = new System.Windows.Forms.Button();
            this.home1btn = new System.Windows.Forms.Button();
            this.HelpTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppFinderTXT
            // 
            this.AppFinderTXT.BackColor = System.Drawing.SystemColors.Highlight;
            this.AppFinderTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppFinderTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppFinderTXT.Location = new System.Drawing.Point(100, 9);
            this.AppFinderTXT.Name = "AppFinderTXT";
            this.AppFinderTXT.Size = new System.Drawing.Size(1100, 74);
            this.AppFinderTXT.TabIndex = 0;
            this.AppFinderTXT.Text = "FIND YOUR APPOINTMENT INFORMATION  ";
            // 
            // Namebtn
            // 
            this.Namebtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namebtn.Image = ((System.Drawing.Image)(resources.GetObject("Namebtn.Image")));
            this.Namebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Namebtn.Location = new System.Drawing.Point(400, 300);
            this.Namebtn.Name = "Namebtn";
            this.Namebtn.Size = new System.Drawing.Size(500, 200);
            this.Namebtn.TabIndex = 1;
            this.Namebtn.Text = "     Name or DOB ";
            this.Namebtn.UseVisualStyleBackColor = true;
            this.Namebtn.Click += new System.EventHandler(this.Namebtn_Click);
            // 
            // NhsNobtn
            // 
            this.NhsNobtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NhsNobtn.Image = ((System.Drawing.Image)(resources.GetObject("NhsNobtn.Image")));
            this.NhsNobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NhsNobtn.Location = new System.Drawing.Point(400, 510);
            this.NhsNobtn.Name = "NhsNobtn";
            this.NhsNobtn.Size = new System.Drawing.Size(500, 200);
            this.NhsNobtn.TabIndex = 2;
            this.NhsNobtn.Text = "         NHS Number ";
            this.NhsNobtn.UseVisualStyleBackColor = true;
            this.NhsNobtn.Click += new System.EventHandler(this.NhsNobtn_Click);
            // 
            // QRbtn
            // 
            this.QRbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QRbtn.Image = ((System.Drawing.Image)(resources.GetObject("QRbtn.Image")));
            this.QRbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QRbtn.Location = new System.Drawing.Point(400, 720);
            this.QRbtn.Name = "QRbtn";
            this.QRbtn.Size = new System.Drawing.Size(500, 200);
            this.QRbtn.TabIndex = 3;
            this.QRbtn.Text = "QR code ";
            this.QRbtn.UseVisualStyleBackColor = true;
            this.QRbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // home1btn
            // 
            this.home1btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home1btn.Location = new System.Drawing.Point(10, 860);
            this.home1btn.Name = "home1btn";
            this.home1btn.Size = new System.Drawing.Size(200, 100);
            this.home1btn.TabIndex = 4;
            this.home1btn.Text = "Return Home";
            this.home1btn.UseVisualStyleBackColor = true;
            this.home1btn.Click += new System.EventHandler(this.home1btn_Click);
            // 
            // HelpTXT
            // 
            this.HelpTXT.AutoSize = true;
            this.HelpTXT.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelpTXT.Location = new System.Drawing.Point(385, 261);
            this.HelpTXT.Name = "HelpTXT";
            this.HelpTXT.Size = new System.Drawing.Size(530, 37);
            this.HelpTXT.TabIndex = 5;
            this.HelpTXT.Text = "Select one of the following to get started ";
            // 
            // AppFinderForPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.HelpTXT);
            this.Controls.Add(this.home1btn);
            this.Controls.Add(this.QRbtn);
            this.Controls.Add(this.NhsNobtn);
            this.Controls.Add(this.Namebtn);
            this.Controls.Add(this.AppFinderTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppFinderForPatients";
            this.Text = "AppFinderForPatients";
            this.Load += new System.EventHandler(this.AppFinderForPatients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AppFinderTXT;
        private System.Windows.Forms.Button Namebtn;
        private System.Windows.Forms.Button NhsNobtn;
        private System.Windows.Forms.Button QRbtn;
        private System.Windows.Forms.Button home1btn;
        private System.Windows.Forms.Label HelpTXT;
    }
}