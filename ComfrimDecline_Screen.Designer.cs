
namespace NHS_SelfCheckIn
{
    partial class ComfrimDecline_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComfrimDecline_Screen));
            this.Comfirmbtn = new System.Windows.Forms.Button();
            this.Declinebtn = new System.Windows.Forms.Button();
            this.home7btn = new System.Windows.Forms.Button();
            this.Pre4btn = new System.Windows.Forms.Button();
            this.CDTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comfirmbtn
            // 
            this.Comfirmbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Comfirmbtn.Image = ((System.Drawing.Image)(resources.GetObject("Comfirmbtn.Image")));
            this.Comfirmbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Comfirmbtn.Location = new System.Drawing.Point(395, 240);
            this.Comfirmbtn.Name = "Comfirmbtn";
            this.Comfirmbtn.Size = new System.Drawing.Size(500, 200);
            this.Comfirmbtn.TabIndex = 1;
            this.Comfirmbtn.Text = "Confirm ";
            this.Comfirmbtn.UseVisualStyleBackColor = true;
            this.Comfirmbtn.Click += new System.EventHandler(this.Comfirmbtn_Click);
            // 
            // Declinebtn
            // 
            this.Declinebtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Declinebtn.Image = ((System.Drawing.Image)(resources.GetObject("Declinebtn.Image")));
            this.Declinebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Declinebtn.Location = new System.Drawing.Point(395, 445);
            this.Declinebtn.Name = "Declinebtn";
            this.Declinebtn.Size = new System.Drawing.Size(500, 200);
            this.Declinebtn.TabIndex = 2;
            this.Declinebtn.Text = "Decline ";
            this.Declinebtn.UseVisualStyleBackColor = true;
            // 
            // home7btn
            // 
            this.home7btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home7btn.Location = new System.Drawing.Point(10, 860);
            this.home7btn.Name = "home7btn";
            this.home7btn.Size = new System.Drawing.Size(200, 100);
            this.home7btn.TabIndex = 3;
            this.home7btn.Text = "Return Home";
            this.home7btn.UseVisualStyleBackColor = true;
            this.home7btn.Click += new System.EventHandler(this.home7btn_Click);
            // 
            // Pre4btn
            // 
            this.Pre4btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pre4btn.Location = new System.Drawing.Point(220, 860);
            this.Pre4btn.Name = "Pre4btn";
            this.Pre4btn.Size = new System.Drawing.Size(200, 100);
            this.Pre4btn.TabIndex = 4;
            this.Pre4btn.Text = "Previous Page ";
            this.Pre4btn.UseVisualStyleBackColor = true;
            // 
            // CDTXT
            // 
            this.CDTXT.AutoSize = true;
            this.CDTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CDTXT.Location = new System.Drawing.Point(230, 9);
            this.CDTXT.Name = "CDTXT";
            this.CDTXT.Size = new System.Drawing.Size(862, 73);
            this.CDTXT.TabIndex = 5;
            this.CDTXT.Text = "Confirm or decline the following  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your new date is booked for 12/04/2021";
            // 
            // ComfrimDecline_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CDTXT);
            this.Controls.Add(this.Pre4btn);
            this.Controls.Add(this.home7btn);
            this.Controls.Add(this.Declinebtn);
            this.Controls.Add(this.Comfirmbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComfrimDecline_Screen";
            this.Text = "Comfirm or Decline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Comfirmbtn;
        private System.Windows.Forms.Button Declinebtn;
        private System.Windows.Forms.Button home7btn;
        private System.Windows.Forms.Button Pre4btn;
        private System.Windows.Forms.Label CDTXT;
        private System.Windows.Forms.Label label1;
    }
}