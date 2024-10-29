namespace HotelReservation
{
    partial class SignInUser
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
            this.btn_signup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(343, 272);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(122, 25);
            this.btn_signup.TabIndex = 22;
            this.btn_signup.Text = "สมัครสมาชิก";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(280, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "รหัสผ่าน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(280, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "ชื่อผู้ใช้งาน";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(343, 205);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(165, 20);
            this.txtbox_password.TabIndex = 19;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(343, 179);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(165, 20);
            this.txtbox_user.TabIndex = 18;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_login.Location = new System.Drawing.Point(327, 102);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(135, 33);
            this.lbl_login.TabIndex = 17;
            this.lbl_login.Text = "เข้าสู่ระบบ";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(342, 241);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 25);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "เข้าสู่ระบบ";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_admin.Location = new System.Drawing.Point(329, 145);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(123, 20);
            this.lbl_admin.TabIndex = 15;
            this.lbl_admin.Text = "สำหรับลูกค้าเท่านั้น";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(343, 303);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 25);
            this.btn_home.TabIndex = 23;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // SignInUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_admin);
            this.Name = "SignInUser";
            this.Text = "SignInUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Button btn_home;
    }
}