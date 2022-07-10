
using System;

namespace NHS_SelfCheckIn
{
    partial class NhsNumber_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhsNumber_Screen));
            this.NhsNoTXT = new System.Windows.Forms.Label();
            this.NHSNOBox = new System.Windows.Forms.TextBox();
            this.NHSpictureBox = new System.Windows.Forms.PictureBox();
            this.home3btn = new System.Windows.Forms.Button();
            this.Pre1btn = new System.Windows.Forms.Button();
            this.Enter1btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NHSpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NhsNoTXT
            // 
            this.NhsNoTXT.AutoSize = true;
            this.NhsNoTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NhsNoTXT.Location = new System.Drawing.Point(304, 9);
            this.NhsNoTXT.Name = "NhsNoTXT";
            this.NhsNoTXT.Size = new System.Drawing.Size(691, 73);
            this.NhsNoTXT.TabIndex = 0;
            this.NhsNoTXT.Text = "Provide your  NHS number";
            // 
            // NHSNOBox
            // 
            this.NHSNOBox.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NHSNOBox.Location = new System.Drawing.Point(304, 251);
            this.NHSNOBox.MaxLength = 10;
            this.NHSNOBox.Name = "NHSNOBox";
            this.NHSNOBox.Size = new System.Drawing.Size(650, 81);
            this.NHSNOBox.TabIndex = 1;
            this.NHSNOBox.Text = "Enter your NHS Number";
            this.NHSNOBox.TextChanged += new System.EventHandler(this.NHSNOBox_TextChanged);
            this.NHSNOBox.GotFocus += new System.EventHandler(this.textbox_GotFocus);
            // 
            // NHSpictureBox
            // 
            this.NHSpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NHSpictureBox.Image")));
            this.NHSpictureBox.Location = new System.Drawing.Point(574, 120);
            this.NHSpictureBox.Name = "NHSpictureBox";
            this.NHSpictureBox.Size = new System.Drawing.Size(125, 120);
            this.NHSpictureBox.TabIndex = 2;
            this.NHSpictureBox.TabStop = false;
            // 
            // home3btn
            // 
            this.home3btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home3btn.Location = new System.Drawing.Point(10, 860);
            this.home3btn.Name = "home3btn";
            this.home3btn.Size = new System.Drawing.Size(200, 100);
            this.home3btn.TabIndex = 3;
            this.home3btn.Text = "Return Home";
            this.home3btn.UseVisualStyleBackColor = true;
            this.home3btn.Click += new System.EventHandler(this.home3btn_Click);
            // 
            // Pre1btn
            // 
            this.Pre1btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pre1btn.Location = new System.Drawing.Point(220, 860);
            this.Pre1btn.Name = "Pre1btn";
            this.Pre1btn.Size = new System.Drawing.Size(200, 100);
            this.Pre1btn.TabIndex = 4;
            this.Pre1btn.Text = "Previous Page ";
            this.Pre1btn.UseVisualStyleBackColor = true;
            this.Pre1btn.Click += new System.EventHandler(this.Pre1btn_Click);
            // 
            // Enter1btn
            // 
            this.Enter1btn.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter1btn.Location = new System.Drawing.Point(1050, 860);
            this.Enter1btn.Name = "Enter1btn";
            this.Enter1btn.Size = new System.Drawing.Size(200, 100);
            this.Enter1btn.TabIndex = 5;
            this.Enter1btn.Text = "Enter";
            this.Enter1btn.UseVisualStyleBackColor = true;
            this.Enter1btn.Click += new System.EventHandler(this.Enter1btn_Click);
            // 
            // NhsNumber_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.Enter1btn);
            this.Controls.Add(this.Pre1btn);
            this.Controls.Add(this.home3btn);
            this.Controls.Add(this.NHSpictureBox);
            this.Controls.Add(this.NHSNOBox);
            this.Controls.Add(this.NhsNoTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhsNumber_Screen";
            this.Text = "Enter NHS Number";
            this.Load += new System.EventHandler(this.NhsNumber_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHSpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label NhsNoTXT;
        private System.Windows.Forms.TextBox NHSNOBox;
        private System.Windows.Forms.PictureBox NHSpictureBox;
        private System.Windows.Forms.Button home3btn;
        private System.Windows.Forms.Button Pre1btn;
        private System.Windows.Forms.Button Enter1btn;
    }
}