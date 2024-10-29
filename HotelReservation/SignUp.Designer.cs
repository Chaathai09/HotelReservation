namespace HotelReservation
{
    partial class SignUp
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label identification_noLabel;
            System.Windows.Forms.Label addressLabel;
            this.hotelDBDataSet = new HotelReservation.HotelDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new HotelReservation.HotelDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new HotelReservation.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_surname = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.txtbox_idno = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            identification_noLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(238, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(57, 16);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "ชื่อผู้ใช้งาน";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(238, 114);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(47, 16);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "รหัสผ่าน";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(238, 201);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(20, 16);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "ชื่อ";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(238, 227);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(45, 16);
            surnameLabel.TabIndex = 11;
            surnameLabel.Text = "นามสกุล";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(238, 253);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(29, 16);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "อีเมล";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(238, 279);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(91, 16);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "หมายเลขโทรศัพท์";
            // 
            // identification_noLabel
            // 
            identification_noLabel.AutoSize = true;
            identification_noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identification_noLabel.Location = new System.Drawing.Point(238, 305);
            identification_noLabel.Name = "identification_noLabel";
            identification_noLabel.Size = new System.Drawing.Size(114, 16);
            identification_noLabel.TabIndex = 17;
            identification_noLabel.Text = "หมายเลขบัตรประชาชน";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(238, 331);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(27, 16);
            addressLabel.TabIndex = 19;
            addressLabel.Text = "ที่อยู่";
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelReservation.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // txtbox_username
            // 
            this.txtbox_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.txtbox_username.Location = new System.Drawing.Point(357, 86);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(165, 20);
            this.txtbox_username.TabIndex = 4;
            this.txtbox_username.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // txtbox_password
            // 
            this.txtbox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.txtbox_password.Location = new System.Drawing.Point(357, 112);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(165, 20);
            this.txtbox_password.TabIndex = 6;
            // 
            // txtbox_name
            // 
            this.txtbox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.txtbox_name.Location = new System.Drawing.Point(357, 199);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(165, 20);
            this.txtbox_name.TabIndex = 10;
            // 
            // txtbox_surname
            // 
            this.txtbox_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "surname", true));
            this.txtbox_surname.Location = new System.Drawing.Point(357, 225);
            this.txtbox_surname.Name = "txtbox_surname";
            this.txtbox_surname.Size = new System.Drawing.Size(165, 20);
            this.txtbox_surname.TabIndex = 12;
            // 
            // txtbox_email
            // 
            this.txtbox_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.txtbox_email.Location = new System.Drawing.Point(357, 251);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(165, 20);
            this.txtbox_email.TabIndex = 14;
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "phone", true));
            this.txtbox_phone.Location = new System.Drawing.Point(357, 277);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(165, 20);
            this.txtbox_phone.TabIndex = 16;
            // 
            // txtbox_idno
            // 
            this.txtbox_idno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "identification_no", true));
            this.txtbox_idno.Location = new System.Drawing.Point(357, 303);
            this.txtbox_idno.Name = "txtbox_idno";
            this.txtbox_idno.Size = new System.Drawing.Size(165, 20);
            this.txtbox_idno.TabIndex = 18;
            // 
            // txtbox_address
            // 
            this.txtbox_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "address", true));
            this.txtbox_address.Location = new System.Drawing.Point(357, 329);
            this.txtbox_address.Multiline = true;
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(165, 61);
            this.txtbox_address.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(238, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ยืนยันรหัสผ่าน";
            // 
            // txtbox_confirm_password
            // 
            this.txtbox_confirm_password.Location = new System.Drawing.Point(357, 138);
            this.txtbox_confirm_password.Name = "txtbox_confirm_password";
            this.txtbox_confirm_password.PasswordChar = '*';
            this.txtbox_confirm_password.Size = new System.Drawing.Size(165, 20);
            this.txtbox_confirm_password.TabIndex = 8;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_login.Location = new System.Drawing.Point(319, 21);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(163, 33);
            this.lbl_login.TabIndex = 24;
            this.lbl_login.Text = "สมัครสมาชิก";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_admin.Location = new System.Drawing.Point(211, 171);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(84, 20);
            this.lbl_admin.TabIndex = 23;
            this.lbl_admin.Text = "ข้อมูลส่วนตัว";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(211, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ข้อมูลบัญชี";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(485, 399);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 25);
            this.btn_home.TabIndex = 27;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(357, 399);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(122, 25);
            this.btn_signup.TabIndex = 26;
            this.btn_signup.Text = "สมัครสมาชิก";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_confirm_password);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.txtbox_surname);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtbox_phone);
            this.Controls.Add(identification_noLabel);
            this.Controls.Add(this.txtbox_idno);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtbox_address);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HotelDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_surname;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_phone;
        private System.Windows.Forms.TextBox txtbox_idno;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_confirm_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_signup;
    }
}