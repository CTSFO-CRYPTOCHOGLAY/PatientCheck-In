
namespace NHS_SelfCheckIn
{
    partial class Clean_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clean_Screen));
            this.CsTXT = new System.Windows.Forms.Label();
            this.Cleanbtn = new System.Windows.Forms.Button();
            this.Home9btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressIntTXT = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CsTXT
            // 
            this.CsTXT.AutoSize = true;
            this.CsTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CsTXT.Location = new System.Drawing.Point(271, 9);
            this.CsTXT.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CsTXT.Name = "CsTXT";
            this.CsTXT.Size = new System.Drawing.Size(727, 73);
            this.CsTXT.TabIndex = 0;
            this.CsTXT.Text = "System Clean Configuration ";
            // 
            // Cleanbtn
            // 
            this.Cleanbtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cleanbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cleanbtn.Location = new System.Drawing.Point(419, 412);
            this.Cleanbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Cleanbtn.Name = "Cleanbtn";
            this.Cleanbtn.Size = new System.Drawing.Size(500, 200);
            this.Cleanbtn.TabIndex = 1;
            this.Cleanbtn.Text = "System Clean Initiation   ";
            this.Cleanbtn.UseVisualStyleBackColor = true;
            this.Cleanbtn.Click += new System.EventHandler(this.Cleanbtn_Click);
            // 
            // Home9btn
            // 
            this.Home9btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home9btn.Location = new System.Drawing.Point(22, 1763);
            this.Home9btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Home9btn.Name = "Home9btn";
            this.Home9btn.Size = new System.Drawing.Size(450, 205);
            this.Home9btn.TabIndex = 2;
            this.Home9btn.Text = "Retun Home";
            this.Home9btn.UseVisualStyleBackColor = true;
            this.Home9btn.Click += new System.EventHandler(this.Home9btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 289);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1051, 97);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressIntTXT
            // 
            this.ProgressIntTXT.AutoSize = true;
            this.ProgressIntTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressIntTXT.Location = new System.Drawing.Point(364, 181);
            this.ProgressIntTXT.Name = "ProgressIntTXT";
            this.ProgressIntTXT.Size = new System.Drawing.Size(555, 73);
            this.ProgressIntTXT.TabIndex = 4;
            this.ProgressIntTXT.Text = "System Clean Up  .....";
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homebtn.Location = new System.Drawing.Point(419, 642);
            this.homebtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(500, 200);
            this.homebtn.TabIndex = 5;
            this.homebtn.Text = "Return Home ";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // Clean_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.ProgressIntTXT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Home9btn);
            this.Controls.Add(this.Cleanbtn);
            this.Controls.Add(this.CsTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clean_Screen";
            this.Text = "Clean Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CsTXT;
        private System.Windows.Forms.Button Cleanbtn;
        private System.Windows.Forms.Button Home9btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ProgressIntTXT;
        private System.Windows.Forms.Button homebtn;
    }
}