namespace HotelReservation
{
    partial class AdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manage = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_reserve_management = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(238, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "ระบบการจองห้องพักโรงแรม";
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(316, 212);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(168, 33);
            this.btn_manage.TabIndex = 7;
            this.btn_manage.Text = "ระบบจัดการผู้ใช้";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_welcome.Location = new System.Drawing.Point(336, 142);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(135, 20);
            this.lbl_welcome.TabIndex = 6;
            this.lbl_welcome.Text = "สำหรับแอดมินเท่านั้น";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(316, 290);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(168, 33);
            this.btn_home.TabIndex = 8;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.Location = new System.Drawing.Point(316, 251);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(168, 33);
            this.btn_manual.TabIndex = 10;
            this.btn_manual.Text = "คู่มือการใช้งาน";
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_reserve_management
            // 
            this.btn_reserve_management.Location = new System.Drawing.Point(316, 173);
            this.btn_reserve_management.Name = "btn_reserve_management";
            this.btn_reserve_management.Size = new System.Drawing.Size(168, 33);
            this.btn_reserve_management.TabIndex = 11;
            this.btn_reserve_management.Text = "ระบบจัดการรายการจองห้อง";
            this.btn_reserve_management.UseVisualStyleBackColor = true;
            this.btn_reserve_management.Click += new System.EventHandler(this.btn_reserve_management_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reserve_management);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Button btn_reserve_management;
    }
}