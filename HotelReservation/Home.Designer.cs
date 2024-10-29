namespace HotelReservation
{
    partial class Home
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
            this.btn_reserve = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendar_checkout = new System.Windows.Forms.MonthCalendar();
            this.calendar_checkin = new System.Windows.Forms.MonthCalendar();
            this.btn_check = new System.Windows.Forms.Button();
            this.listView_available = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(123, 204);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(168, 33);
            this.btn_reserve.TabIndex = 0;
            this.btn_reserve.Text = "ต้องการเข้าพักอาศัย";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_welcome.Location = new System.Drawing.Point(134, 174);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(147, 20);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome ยินดีต้อนรับ";
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(123, 243);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(168, 33);
            this.btn_manage.TabIndex = 2;
            this.btn_manage.Text = "ระบบจัดการ (สำหรับแอดมิน)";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.Location = new System.Drawing.Point(123, 282);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(168, 33);
            this.btn_manual.TabIndex = 3;
            this.btn_manual.Text = "คู่มือการใช้งาน";
            this.btn_manual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ระบบการจองห้องพักโรงแรม";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(414, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "วันที่ออก";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(414, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "วันที่เข้าพัก";
            // 
            // calendar_checkout
            // 
            this.calendar_checkout.Location = new System.Drawing.Point(417, 247);
            this.calendar_checkout.MaxSelectionCount = 1;
            this.calendar_checkout.Name = "calendar_checkout";
            this.calendar_checkout.TabIndex = 46;
            this.calendar_checkout.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_checkout_DateChanged);
            // 
            // calendar_checkin
            // 
            this.calendar_checkin.Location = new System.Drawing.Point(415, 65);
            this.calendar_checkin.MaxSelectionCount = 1;
            this.calendar_checkin.Name = "calendar_checkin";
            this.calendar_checkin.TabIndex = 45;
            this.calendar_checkin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_checkin_DateChanged);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(654, 65);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(112, 25);
            this.btn_check.TabIndex = 44;
            this.btn_check.Text = "ตรวจสอบ";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // listView_available
            // 
            this.listView_available.HideSelection = false;
            this.listView_available.Location = new System.Drawing.Point(654, 96);
            this.listView_available.Name = "listView_available";
            this.listView_available.Size = new System.Drawing.Size(112, 313);
            this.listView_available.TabIndex = 49;
            this.listView_available.UseCompatibleStateImageBehavior = false;
            this.listView_available.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(413, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "ตรวจสอบห้องว่าง";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_available);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calendar_checkout);
            this.Controls.Add(this.calendar_checkin);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_reserve);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendar_checkout;
        private System.Windows.Forms.MonthCalendar calendar_checkin;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ListView listView_available;
        private System.Windows.Forms.Label label2;
    }
}

