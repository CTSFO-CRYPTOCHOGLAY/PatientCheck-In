
namespace NHS_SelfCheckIn
{
    partial class ComfirmCancelReschedule_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComfirmCancelReschedule_Screen));
            this.CCRTXT = new System.Windows.Forms.Label();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.CancelRebookbtn = new System.Windows.Forms.Button();
            this.home5btn = new System.Windows.Forms.Button();
            this.FirstNameTXT = new System.Windows.Forms.Label();
            this.TimeTXT1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CCRTXT
            // 
            this.CCRTXT.AutoSize = true;
            this.CCRTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CCRTXT.Location = new System.Drawing.Point(25, 9);
            this.CCRTXT.Name = "CCRTXT";
            this.CCRTXT.Size = new System.Drawing.Size(1236, 73);
            this.CCRTXT.TabIndex = 0;
            this.CCRTXT.Text = "Confirm, Cancel and Rebook your appointments ";
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirmbtn.Image = ((System.Drawing.Image)(resources.GetObject("Confirmbtn.Image")));
            this.Confirmbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmbtn.Location = new System.Drawing.Point(395, 390);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(500, 200);
            this.Confirmbtn.TabIndex = 2;
            this.Confirmbtn.Text = "Confirm Attendance ";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // CancelRebookbtn
            // 
            this.CancelRebookbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelRebookbtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelRebookbtn.Image")));
            this.CancelRebookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelRebookbtn.Location = new System.Drawing.Point(395, 600);
            this.CancelRebookbtn.Name = "CancelRebookbtn";
            this.CancelRebookbtn.Size = new System.Drawing.Size(500, 200);
            this.CancelRebookbtn.TabIndex = 3;
            this.CancelRebookbtn.Text = "Cancel and Rebook";
            this.CancelRebookbtn.UseVisualStyleBackColor = true;
            this.CancelRebookbtn.Click += new System.EventHandler(this.CancelRebookbtn_Click);
            // 
            // home5btn
            // 
            this.home5btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home5btn.Location = new System.Drawing.Point(10, 860);
            this.home5btn.Name = "home5btn";
            this.home5btn.Size = new System.Drawing.Size(200, 100);
            this.home5btn.TabIndex = 4;
            this.home5btn.Text = "Return Home";
            this.home5btn.UseVisualStyleBackColor = true;
            this.home5btn.Click += new System.EventHandler(this.home5btn_Click);
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.AutoSize = true;
            this.FirstNameTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameTXT.Location = new System.Drawing.Point(340, 113);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(591, 146);
            this.FirstNameTXT.TabIndex = 5;
            this.FirstNameTXT.Text = "Name Will Show Here \r\nAppointment Time ";
            this.FirstNameTXT.Click += new System.EventHandler(this.FirstNameTXT_Click);
            // 
            // TimeTXT1
            // 
            this.TimeTXT1.AutoSize = true;
            this.TimeTXT1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeTXT1.Location = new System.Drawing.Point(419, 290);
            this.TimeTXT1.Name = "TimeTXT1";
            this.TimeTXT1.Size = new System.Drawing.Size(658, 53);
            this.TimeTXT1.TabIndex = 6;
            this.TimeTXT1.Text = "Appointment Time to be Displayed ";
            this.TimeTXT1.Click += new System.EventHandler(this.TimeTXT1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Appointment Time:";
            // 
            // ComfirmCancelReschedule_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTXT1);
            this.Controls.Add(this.FirstNameTXT);
            this.Controls.Add(this.home5btn);
            this.Controls.Add(this.CancelRebookbtn);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.CCRTXT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComfirmCancelReschedule_Screen";
            this.Text = "Comfirm, Cancel & Reschedule";
            this.Load += new System.EventHandler(this.ComfirmCancelReschedule_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CCRTXT;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Button CancelRebookbtn;
        private System.Windows.Forms.Button home5btn;
        private System.Windows.Forms.Label FirstNameTXT;
        private System.Windows.Forms.Label TimeTXT1;
        private System.Windows.Forms.Label label1;
    }
}