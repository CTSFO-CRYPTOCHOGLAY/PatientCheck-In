
namespace NHS_SelfCheckIn
{
    partial class NewDate_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDate_Screen));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.newTXT = new System.Windows.Forms.Label();
            this.home8btn = new System.Windows.Forms.Button();
            this.pre5btn = new System.Windows.Forms.Button();
            this.Next1btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.monthCalendar.Location = new System.Drawing.Point(390, 185);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // newTXT
            // 
            this.newTXT.AutoSize = true;
            this.newTXT.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newTXT.Location = new System.Drawing.Point(208, 9);
            this.newTXT.Name = "newTXT";
            this.newTXT.Size = new System.Drawing.Size(864, 73);
            this.newTXT.TabIndex = 1;
            this.newTXT.Text = "Select date for new appointment ";
            // 
            // home8btn
            // 
            this.home8btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home8btn.Location = new System.Drawing.Point(10, 860);
            this.home8btn.Name = "home8btn";
            this.home8btn.Size = new System.Drawing.Size(200, 100);
            this.home8btn.TabIndex = 2;
            this.home8btn.Text = "Return Home";
            this.home8btn.UseVisualStyleBackColor = true;
            this.home8btn.Click += new System.EventHandler(this.home8btn_Click);
            // 
            // pre5btn
            // 
            this.pre5btn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pre5btn.Location = new System.Drawing.Point(220, 860);
            this.pre5btn.Name = "pre5btn";
            this.pre5btn.Size = new System.Drawing.Size(200, 100);
            this.pre5btn.TabIndex = 3;
            this.pre5btn.Text = "Previous Page ";
            this.pre5btn.UseVisualStyleBackColor = true;
            // 
            // Next1btn
            // 
            this.Next1btn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Next1btn.Location = new System.Drawing.Point(1050, 860);
            this.Next1btn.Name = "Next1btn";
            this.Next1btn.Size = new System.Drawing.Size(200, 100);
            this.Next1btn.TabIndex = 4;
            this.Next1btn.Text = "Next/Select ";
            this.Next1btn.UseVisualStyleBackColor = true;
            this.Next1btn.Click += new System.EventHandler(this.Next1btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(352, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(600, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // NewDate_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Next1btn);
            this.Controls.Add(this.pre5btn);
            this.Controls.Add(this.home8btn);
            this.Controls.Add(this.newTXT);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewDate_Screen";
            this.Text = "New Date";
            this.Load += new System.EventHandler(this.NewDate_Screen_Load);
            this.Enter += new System.EventHandler(this.NewDate_Screen_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label newTXT;
        private System.Windows.Forms.Button home8btn;
        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button pre5btn;
        private System.Windows.Forms.Button Next1btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}