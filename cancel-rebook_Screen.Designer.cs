
namespace NHS_SelfCheckIn
{
    partial class cancel_rebook_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cancel_rebook_Screen));
            this.SelectTXT = new System.Windows.Forms.Label();
            this.Canrbtn = new System.Windows.Forms.Button();
            this.carebookbtn = new System.Windows.Forms.Button();
            this.home6btn = new System.Windows.Forms.Button();
            this.pre3btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTXT
            // 
            this.SelectTXT.AutoSize = true;
            this.SelectTXT.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectTXT.Location = new System.Drawing.Point(25, 9);
            this.SelectTXT.Name = "SelectTXT";
            this.SelectTXT.Size = new System.Drawing.Size(1188, 58);
            this.SelectTXT.TabIndex = 0;
            this.SelectTXT.Text = "Select between cancel and no rebook or cancel and rebook ";
            // 
            // Canrbtn
            // 
            this.Canrbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Canrbtn.Location = new System.Drawing.Point(400, 300);
            this.Canrbtn.Name = "Canrbtn";
            this.Canrbtn.Size = new System.Drawing.Size(500, 200);
            this.Canrbtn.TabIndex = 1;
            this.Canrbtn.Text = "Cancel And No Rebook";
            this.Canrbtn.UseVisualStyleBackColor = true;
            this.Canrbtn.Click += new System.EventHandler(this.Canrbtn_Click);
            // 
            // carebookbtn
            // 
            this.carebookbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carebookbtn.Location = new System.Drawing.Point(400, 510);
            this.carebookbtn.Name = "carebookbtn";
            this.carebookbtn.Size = new System.Drawing.Size(500, 200);
            this.carebookbtn.TabIndex = 2;
            this.carebookbtn.Text = " cancel and rebook ";
            this.carebookbtn.UseVisualStyleBackColor = true;
            this.carebookbtn.Click += new System.EventHandler(this.carebookbtn_Click);
            // 
            // home6btn
            // 
            this.home6btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home6btn.Location = new System.Drawing.Point(10, 860);
            this.home6btn.Name = "home6btn";
            this.home6btn.Size = new System.Drawing.Size(200, 100);
            this.home6btn.TabIndex = 3;
            this.home6btn.Text = "Return Home ";
            this.home6btn.UseVisualStyleBackColor = true;
            this.home6btn.Click += new System.EventHandler(this.home6btn_Click);
            // 
            // pre3btn
            // 
            this.pre3btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pre3btn.Location = new System.Drawing.Point(220, 860);
            this.pre3btn.Name = "pre3btn";
            this.pre3btn.Size = new System.Drawing.Size(200, 100);
            this.pre3btn.TabIndex = 4;
            this.pre3btn.Text = "Previous Page ";
            this.pre3btn.UseVisualStyleBackColor = true;
            this.pre3btn.Click += new System.EventHandler(this.pre3btn_Click);
            // 
            // cancel_rebook_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.pre3btn);
            this.Controls.Add(this.home6btn);
            this.Controls.Add(this.carebookbtn);
            this.Controls.Add(this.Canrbtn);
            this.Controls.Add(this.SelectTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cancel_rebook_Screen";
            this.Text = "Cancel Options ";
            this.Load += new System.EventHandler(this.cancel_rebook_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectTXT;
        private System.Windows.Forms.Button Canrbtn;
        private System.Windows.Forms.Button carebookbtn;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button home6btn;
        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button pre3btn;
    }
}