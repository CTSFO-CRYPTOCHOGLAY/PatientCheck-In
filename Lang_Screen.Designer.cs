
namespace NHS_SelfCheckIn
{
    partial class Lang_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lang_Screen));
            this.LangTXT = new System.Windows.Forms.TextBox();
            this.Englishbtn = new System.Windows.Forms.Button();
            this.Welchbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LangTXT
            // 
            this.LangTXT.BackColor = System.Drawing.SystemColors.Highlight;
            this.LangTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LangTXT.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LangTXT.Location = new System.Drawing.Point(300, 9);
            this.LangTXT.Name = "LangTXT";
            this.LangTXT.Size = new System.Drawing.Size(699, 52);
            this.LangTXT.TabIndex = 0;
            this.LangTXT.Text = "SELECT THE LANGUAGE YOU REQUIRE  ";
            // 
            // Englishbtn
            // 
            this.Englishbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Englishbtn.Image = ((System.Drawing.Image)(resources.GetObject("Englishbtn.Image")));
            this.Englishbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Englishbtn.Location = new System.Drawing.Point(400, 300);
            this.Englishbtn.Name = "Englishbtn";
            this.Englishbtn.Size = new System.Drawing.Size(500, 200);
            this.Englishbtn.TabIndex = 1;
            this.Englishbtn.Text = "English ";
            this.Englishbtn.UseVisualStyleBackColor = true;
            // 
            // Welchbtn
            // 
            this.Welchbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welchbtn.Image = ((System.Drawing.Image)(resources.GetObject("Welchbtn.Image")));
            this.Welchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Welchbtn.Location = new System.Drawing.Point(400, 510);
            this.Welchbtn.Name = "Welchbtn";
            this.Welchbtn.Size = new System.Drawing.Size(500, 200);
            this.Welchbtn.TabIndex = 2;
            this.Welchbtn.Text = "Welsh   ";
            this.Welchbtn.UseVisualStyleBackColor = true;
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homebtn.Location = new System.Drawing.Point(10, 860);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(200, 100);
            this.homebtn.TabIndex = 4;
            this.homebtn.Text = "Return Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.ClientSizeChanged += new System.EventHandler(this.homebtn_ClientSizeChanged);
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // Lang_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.Welchbtn);
            this.Controls.Add(this.Englishbtn);
            this.Controls.Add(this.LangTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lang_Screen";
            this.Text = "NHS Language Selector ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LangTXT;
        private System.Windows.Forms.Button Englishbtn;
        private System.Windows.Forms.Button Welchbtn;
        private System.Windows.Forms.Button homebtn;
    }
}