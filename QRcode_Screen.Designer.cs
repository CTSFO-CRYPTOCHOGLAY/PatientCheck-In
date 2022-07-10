
namespace NHS_SelfCheckIn
{
    partial class QRcode_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRcode_Screen));
            this.QRTXT = new System.Windows.Forms.Label();
            this.VisualLink = new System.Windows.Forms.PictureBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.Prebtn = new System.Windows.Forms.Button();
            this.QRlogo = new System.Windows.Forms.PictureBox();
            this.WebcamDevice = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VisualLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // QRTXT
            // 
            this.QRTXT.AutoSize = true;
            this.QRTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QRTXT.Location = new System.Drawing.Point(400, 9);
            this.QRTXT.Name = "QRTXT";
            this.QRTXT.Size = new System.Drawing.Size(473, 73);
            this.QRTXT.TabIndex = 0;
            this.QRTXT.Text = "QR Code Scanner ";
            // 
            // VisualLink
            // 
            this.VisualLink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VisualLink.Location = new System.Drawing.Point(28, 220);
            this.VisualLink.Name = "VisualLink";
            this.VisualLink.Size = new System.Drawing.Size(1200, 600);
            this.VisualLink.TabIndex = 1;
            this.VisualLink.TabStop = false;
            this.VisualLink.Click += new System.EventHandler(this.Prebtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homebtn.Location = new System.Drawing.Point(10, 860);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(227, 101);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Return Home ";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // Prebtn
            // 
            this.Prebtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prebtn.Location = new System.Drawing.Point(240, 860);
            this.Prebtn.Name = "Prebtn";
            this.Prebtn.Size = new System.Drawing.Size(200, 100);
            this.Prebtn.TabIndex = 3;
            this.Prebtn.Text = "Previous Page ";
            this.Prebtn.UseVisualStyleBackColor = true;
            this.Prebtn.Click += new System.EventHandler(this.Prebtn_Click);
            // 
            // QRlogo
            // 
            this.QRlogo.Image = ((System.Drawing.Image)(resources.GetObject("QRlogo.Image")));
            this.QRlogo.Location = new System.Drawing.Point(550, 75);
            this.QRlogo.Name = "QRlogo";
            this.QRlogo.Size = new System.Drawing.Size(200, 140);
            this.QRlogo.TabIndex = 5;
            this.QRlogo.TabStop = false;
            // 
            // WebcamDevice
            // 
            this.WebcamDevice.FormattingEnabled = true;
            this.WebcamDevice.Location = new System.Drawing.Point(1, 1);
            this.WebcamDevice.Name = "WebcamDevice";
            this.WebcamDevice.Size = new System.Drawing.Size(151, 28);
            this.WebcamDevice.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QRcode_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.WebcamDevice);
            this.Controls.Add(this.QRlogo);
            this.Controls.Add(this.Prebtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.VisualLink);
            this.Controls.Add(this.QRTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRcode_Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRcode_Screen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QRcode_Screen_FormClosed);
            this.Load += new System.EventHandler(this.QRcode_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisualLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QRTXT;
        private System.Windows.Forms.PictureBox VisualLink;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button Prebtn;
        private System.Windows.Forms.PictureBox QRlogo;
        private System.Windows.Forms.ComboBox WebcamDevice;
        private System.Windows.Forms.Timer timer1;
    }
}