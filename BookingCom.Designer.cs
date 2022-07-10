
namespace NHS_SelfCheckIn
{
    partial class BookingCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingCom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ThankyouTXT = new System.Windows.Forms.Label();
            this.Home10btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ThankyouTXT
            // 
            this.ThankyouTXT.AutoSize = true;
            this.ThankyouTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThankyouTXT.Location = new System.Drawing.Point(214, 259);
            this.ThankyouTXT.Name = "ThankyouTXT";
            this.ThankyouTXT.Size = new System.Drawing.Size(795, 73);
            this.ThankyouTXT.TabIndex = 1;
            this.ThankyouTXT.Text = "Thank you Booking Confirmed ";
            // 
            // Home10btn
            // 
            this.Home10btn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home10btn.Location = new System.Drawing.Point(400, 350);
            this.Home10btn.Name = "Home10btn";
            this.Home10btn.Size = new System.Drawing.Size(500, 200);
            this.Home10btn.TabIndex = 2;
            this.Home10btn.Text = "Return Home";
            this.Home10btn.UseVisualStyleBackColor = true;
            this.Home10btn.Click += new System.EventHandler(this.Home10btn_Click);
            // 
            // BookingCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.Home10btn);
            this.Controls.Add(this.ThankyouTXT);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingCom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ThankyouTXT;
        private System.Windows.Forms.Button Home10btn;
    }
}