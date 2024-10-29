namespace HotelReservation
{
    partial class Reservation_Room
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
            this.lbl_reserve_title = new System.Windows.Forms.Label();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.lbl_roomdetail = new System.Windows.Forms.Label();
            this.listbox_reserved = new System.Windows.Forms.ListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_room1 = new System.Windows.Forms.Button();
            this.calendar_checkin = new System.Windows.Forms.MonthCalendar();
            this.calendar_checkout = new System.Windows.Forms.MonthCalendar();
            this.comboBox_floor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_room2 = new System.Windows.Forms.Button();
            this.btn_room3 = new System.Windows.Forms.Button();
            this.btn_room4 = new System.Windows.Forms.Button();
            this.btn_room5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_reserve_title
            // 
            this.lbl_reserve_title.AutoSize = true;
            this.lbl_reserve_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reserve_title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_reserve_title.Location = new System.Drawing.Point(329, 68);
            this.lbl_reserve_title.Name = "lbl_reserve_title";
            this.lbl_reserve_title.Size = new System.Drawing.Size(140, 20);
            this.lbl_reserve_title.TabIndex = 17;
            this.lbl_reserve_title.Text = "เพิ่มข้อมูลการจองห้อง";
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topic.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_topic.Location = new System.Drawing.Point(110, 102);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(112, 18);
            this.lbl_topic.TabIndex = 19;
            this.lbl_topic.Text = "รายละเอียดห้องพัก";
            // 
            // lbl_roomdetail
            // 
            this.lbl_roomdetail.AutoSize = true;
            this.lbl_roomdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomdetail.ForeColor = System.Drawing.Color.Black;
            this.lbl_roomdetail.Location = new System.Drawing.Point(115, 124);
            this.lbl_roomdetail.Name = "lbl_roomdetail";
            this.lbl_roomdetail.Size = new System.Drawing.Size(179, 30);
            this.lbl_roomdetail.TabIndex = 20;
            this.lbl_roomdetail.Text = "ห้องปกติ ราคา 2,500 บาท | ชั้น 1 - 3\r\nห้อง VIP ราคา 3,000 บาท | ชั้น 4\r\n";
            // 
            // listbox_reserved
            // 
            this.listbox_reserved.FormattingEnabled = true;
            this.listbox_reserved.Location = new System.Drawing.Point(333, 102);
            this.listbox_reserved.Name = "listbox_reserved";
            this.listbox_reserved.Size = new System.Drawing.Size(386, 56);
            this.listbox_reserved.TabIndex = 21;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(415, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 25);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "ล้างข้อมูล";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_room1
            // 
            this.btn_room1.Location = new System.Drawing.Point(151, 205);
            this.btn_room1.Name = "btn_room1";
            this.btn_room1.Size = new System.Drawing.Size(75, 23);
            this.btn_room1.TabIndex = 32;
            this.btn_room1.Text = "button1";
            this.btn_room1.UseVisualStyleBackColor = true;
            this.btn_room1.Click += new System.EventHandler(this.btn_room1_Click);
            // 
            // calendar_checkin
            // 
            this.calendar_checkin.Location = new System.Drawing.Point(113, 258);
            this.calendar_checkin.MaxSelectionCount = 1;
            this.calendar_checkin.Name = "calendar_checkin";
            this.calendar_checkin.TabIndex = 33;
            this.calendar_checkin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_checkin_DateChanged);
            // 
            // calendar_checkout
            // 
            this.calendar_checkout.Location = new System.Drawing.Point(358, 258);
            this.calendar_checkout.MaxSelectionCount = 1;
            this.calendar_checkout.Name = "calendar_checkout";
            this.calendar_checkout.TabIndex = 34;
            this.calendar_checkout.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_checkout_DateChanged);
            // 
            // comboBox_floor
            // 
            this.comboBox_floor.FormattingEnabled = true;
            this.comboBox_floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_floor.Location = new System.Drawing.Point(151, 178);
            this.comboBox_floor.Name = "comboBox_floor";
            this.comboBox_floor.Size = new System.Drawing.Size(75, 21);
            this.comboBox_floor.TabIndex = 35;
            this.comboBox_floor.SelectedIndexChanged += new System.EventHandler(this.comboBox_floor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(112, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "ชั้นที่";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(112, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "ห้องที่";
            // 
            // btn_room2
            // 
            this.btn_room2.Location = new System.Drawing.Point(232, 205);
            this.btn_room2.Name = "btn_room2";
            this.btn_room2.Size = new System.Drawing.Size(75, 23);
            this.btn_room2.TabIndex = 38;
            this.btn_room2.Text = "button2";
            this.btn_room2.UseVisualStyleBackColor = true;
            this.btn_room2.Click += new System.EventHandler(this.btn_room2_Click);
            // 
            // btn_room3
            // 
            this.btn_room3.Location = new System.Drawing.Point(313, 205);
            this.btn_room3.Name = "btn_room3";
            this.btn_room3.Size = new System.Drawing.Size(75, 23);
            this.btn_room3.TabIndex = 39;
            this.btn_room3.Text = "button3";
            this.btn_room3.UseVisualStyleBackColor = true;
            this.btn_room3.Click += new System.EventHandler(this.btn_room3_Click);
            // 
            // btn_room4
            // 
            this.btn_room4.Location = new System.Drawing.Point(394, 205);
            this.btn_room4.Name = "btn_room4";
            this.btn_room4.Size = new System.Drawing.Size(75, 23);
            this.btn_room4.TabIndex = 40;
            this.btn_room4.Text = "button4";
            this.btn_room4.UseVisualStyleBackColor = true;
            this.btn_room4.Click += new System.EventHandler(this.btn_room4_Click);
            // 
            // btn_room5
            // 
            this.btn_room5.Location = new System.Drawing.Point(475, 205);
            this.btn_room5.Name = "btn_room5";
            this.btn_room5.Size = new System.Drawing.Size(75, 23);
            this.btn_room5.TabIndex = 41;
            this.btn_room5.Text = "button5";
            this.btn_room5.UseVisualStyleBackColor = true;
            this.btn_room5.Click += new System.EventHandler(this.btn_room5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(112, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "วันที่เข้าพัก";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(355, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "วันที่ออก";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(597, 355);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 25);
            this.btn_home.TabIndex = 45;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(597, 324);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 25);
            this.btn_clear.TabIndex = 46;
            this.btn_clear.Text = "ล้างข้อมูล";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(237, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "ระบบการจองห้องพักโรงแรม";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(597, 293);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(122, 25);
            this.btn_submit.TabIndex = 48;
            this.btn_submit.Text = "ยืนยันการจองพัก";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total.Location = new System.Drawing.Point(330, 161);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(121, 15);
            this.lbl_total.TabIndex = 49;
            this.lbl_total.Text = "ยอดชำระทั้งหมด : 0 บาท";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_user.Location = new System.Drawing.Point(12, 9);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(74, 13);
            this.lbl_user.TabIndex = 50;
            this.lbl_user.Text = "บัญชีผู้ใช้งาน :";
            // 
            // Reservation_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_room5);
            this.Controls.Add(this.btn_room4);
            this.Controls.Add(this.btn_room3);
            this.Controls.Add(this.btn_room2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_floor);
            this.Controls.Add(this.calendar_checkout);
            this.Controls.Add(this.calendar_checkin);
            this.Controls.Add(this.btn_room1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.listbox_reserved);
            this.Controls.Add(this.lbl_roomdetail);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.lbl_reserve_title);
            this.Name = "Reservation_Room";
            this.Text = "Reservation_Room";
            this.Load += new System.EventHandler(this.Reservation_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_reserve_title;
        private System.Windows.Forms.Label lbl_topic;
        private System.Windows.Forms.Label lbl_roomdetail;
        private System.Windows.Forms.ListBox listbox_reserved;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_room1;
        private System.Windows.Forms.MonthCalendar calendar_checkin;
        private System.Windows.Forms.MonthCalendar calendar_checkout;
        private System.Windows.Forms.ComboBox comboBox_floor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_room2;
        private System.Windows.Forms.Button btn_room3;
        private System.Windows.Forms.Button btn_room4;
        private System.Windows.Forms.Button btn_room5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_user;
    }
}