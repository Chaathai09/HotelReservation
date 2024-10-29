namespace HotelReservation
{
    partial class UserManagement
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label identification_noLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            this.btn_update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.hotelDBDataSet = new HotelReservation.HotelDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new HotelReservation.HotelDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new HotelReservation.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_surname = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.txtbox_idno = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.comboBox_update_user = new System.Windows.Forms.ComboBox();
            this.txtbox_update_password = new System.Windows.Forms.TextBox();
            this.txtbox_update_name = new System.Windows.Forms.TextBox();
            this.txtbox_update_surname = new System.Windows.Forms.TextBox();
            this.txtbox_update_email = new System.Windows.Forms.TextBox();
            this.txtbox_update_phone = new System.Windows.Forms.TextBox();
            this.txtbox_update_idno = new System.Windows.Forms.TextBox();
            this.txtbox_update_address = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.checkBox_update_admin = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            identification_noLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(28, 435);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 15);
            label6.TabIndex = 58;
            label6.Text = "ชื่อผู้ใช้งาน";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(471, 371);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 25);
            this.btn_update.TabIndex = 69;
            this.btn_update.Text = "เปลี่ยนข้อมูล";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label10.Location = new System.Drawing.Point(338, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "ค้นหา/เปลี่ยนแปลงข้อมูลบัญชีผู้ใช้";
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(147, 434);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(165, 21);
            this.comboBox_user.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(14, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "ลบข้อมูลบัญชีผู้ใช้";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "เพิ่มข้อมูลบัญชีผู้ใข้";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_admin.Location = new System.Drawing.Point(17, 43);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(103, 16);
            this.lbl_admin.TabIndex = 45;
            this.lbl_admin.Text = "สำหรับแอดมินเท่านั้น";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_login.Location = new System.Drawing.Point(12, 15);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(194, 25);
            this.lbl_login.TabIndex = 44;
            this.lbl_login.Text = "ระบบจัดการบัญชีผู้ใช้";
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
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(661, 80);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(575, 369);
            this.usersDataGridView.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userID";
            this.dataGridViewTextBoxColumn1.HeaderText = "userID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isAdmin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn5.HeaderText = "surname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "identification_no";
            this.dataGridViewTextBoxColumn8.HeaderText = "identification_no";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn9.HeaderText = "address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(28, 102);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(58, 13);
            label14.TabIndex = 73;
            label14.Text = "ชื่อผู้ใช้งาน";
            // 
            // txtbox_username
            // 
            this.txtbox_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.txtbox_username.Location = new System.Drawing.Point(147, 100);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(165, 20);
            this.txtbox_username.TabIndex = 74;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(28, 128);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(46, 13);
            passwordLabel.TabIndex = 75;
            passwordLabel.Text = "รหัสผ่าน";
            // 
            // txtbox_password
            // 
            this.txtbox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.txtbox_password.Location = new System.Drawing.Point(147, 126);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(165, 20);
            this.txtbox_password.TabIndex = 76;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(28, 154);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(20, 13);
            nameLabel.TabIndex = 78;
            nameLabel.Text = "ชื่อ";
            // 
            // txtbox_name
            // 
            this.txtbox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.txtbox_name.Location = new System.Drawing.Point(147, 152);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(165, 20);
            this.txtbox_name.TabIndex = 79;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(28, 180);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(46, 13);
            surnameLabel.TabIndex = 80;
            surnameLabel.Text = "นามสกุล";
            // 
            // txtbox_surname
            // 
            this.txtbox_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "surname", true));
            this.txtbox_surname.Location = new System.Drawing.Point(147, 178);
            this.txtbox_surname.Name = "txtbox_surname";
            this.txtbox_surname.Size = new System.Drawing.Size(165, 20);
            this.txtbox_surname.TabIndex = 81;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(28, 206);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(31, 13);
            emailLabel.TabIndex = 82;
            emailLabel.Text = "อีเมล";
            // 
            // txtbox_email
            // 
            this.txtbox_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.txtbox_email.Location = new System.Drawing.Point(147, 204);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(165, 20);
            this.txtbox_email.TabIndex = 83;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(28, 232);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(91, 13);
            phoneLabel.TabIndex = 84;
            phoneLabel.Text = "หมายเลขโทรศัพท์";
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "phone", true));
            this.txtbox_phone.Location = new System.Drawing.Point(147, 230);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(165, 20);
            this.txtbox_phone.TabIndex = 85;
            // 
            // identification_noLabel
            // 
            identification_noLabel.AutoSize = true;
            identification_noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identification_noLabel.Location = new System.Drawing.Point(28, 258);
            identification_noLabel.Name = "identification_noLabel";
            identification_noLabel.Size = new System.Drawing.Size(115, 13);
            identification_noLabel.TabIndex = 86;
            identification_noLabel.Text = "หมายเลขบัตรประชาชน";
            // 
            // txtbox_idno
            // 
            this.txtbox_idno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "identification_no", true));
            this.txtbox_idno.Location = new System.Drawing.Point(147, 256);
            this.txtbox_idno.Name = "txtbox_idno";
            this.txtbox_idno.Size = new System.Drawing.Size(165, 20);
            this.txtbox_idno.TabIndex = 87;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(28, 284);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(27, 13);
            addressLabel.TabIndex = 88;
            addressLabel.Text = "ที่อยู่";
            // 
            // txtbox_address
            // 
            this.txtbox_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "address", true));
            this.txtbox_address.Location = new System.Drawing.Point(147, 282);
            this.txtbox_address.Multiline = true;
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(165, 61);
            this.txtbox_address.TabIndex = 89;
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Location = new System.Drawing.Point(147, 349);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(116, 17);
            this.checkBox_admin.TabIndex = 91;
            this.checkBox_admin.Text = "อนุญาตสิทธิแอดมิน";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(147, 372);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(122, 25);
            this.btn_insert.TabIndex = 92;
            this.btn_insert.Text = "เพิ่มข้อมูล";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // comboBox_update_user
            // 
            this.comboBox_update_user.FormattingEnabled = true;
            this.comboBox_update_user.Location = new System.Drawing.Point(471, 96);
            this.comboBox_update_user.Name = "comboBox_update_user";
            this.comboBox_update_user.Size = new System.Drawing.Size(165, 21);
            this.comboBox_update_user.TabIndex = 93;
            this.comboBox_update_user.SelectedIndexChanged += new System.EventHandler(this.comboBox_update_user_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(352, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 94;
            label2.Text = "ชื่อผู้ใช้งาน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(352, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 96;
            label3.Text = "รหัสผ่าน";
            // 
            // txtbox_update_password
            // 
            this.txtbox_update_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.txtbox_update_password.Location = new System.Drawing.Point(471, 125);
            this.txtbox_update_password.Name = "txtbox_update_password";
            this.txtbox_update_password.PasswordChar = '*';
            this.txtbox_update_password.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_password.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(352, 154);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 13);
            label4.TabIndex = 98;
            label4.Text = "ชื่อ";
            // 
            // txtbox_update_name
            // 
            this.txtbox_update_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.txtbox_update_name.Location = new System.Drawing.Point(471, 151);
            this.txtbox_update_name.Name = "txtbox_update_name";
            this.txtbox_update_name.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_name.TabIndex = 99;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(352, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 13);
            label7.TabIndex = 100;
            label7.Text = "นามสกุล";
            // 
            // txtbox_update_surname
            // 
            this.txtbox_update_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "surname", true));
            this.txtbox_update_surname.Location = new System.Drawing.Point(471, 177);
            this.txtbox_update_surname.Name = "txtbox_update_surname";
            this.txtbox_update_surname.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_surname.TabIndex = 101;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(352, 205);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(31, 13);
            label8.TabIndex = 102;
            label8.Text = "อีเมล";
            // 
            // txtbox_update_email
            // 
            this.txtbox_update_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.txtbox_update_email.Location = new System.Drawing.Point(471, 203);
            this.txtbox_update_email.Name = "txtbox_update_email";
            this.txtbox_update_email.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_email.TabIndex = 103;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(352, 231);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(91, 13);
            label11.TabIndex = 104;
            label11.Text = "หมายเลขโทรศัพท์";
            // 
            // txtbox_update_phone
            // 
            this.txtbox_update_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "phone", true));
            this.txtbox_update_phone.Location = new System.Drawing.Point(471, 229);
            this.txtbox_update_phone.Name = "txtbox_update_phone";
            this.txtbox_update_phone.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_phone.TabIndex = 105;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(352, 257);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(115, 13);
            label12.TabIndex = 106;
            label12.Text = "หมายเลขบัตรประชาชน";
            // 
            // txtbox_update_idno
            // 
            this.txtbox_update_idno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "identification_no", true));
            this.txtbox_update_idno.Location = new System.Drawing.Point(471, 255);
            this.txtbox_update_idno.Name = "txtbox_update_idno";
            this.txtbox_update_idno.Size = new System.Drawing.Size(165, 20);
            this.txtbox_update_idno.TabIndex = 107;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(352, 283);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(27, 13);
            label13.TabIndex = 108;
            label13.Text = "ที่อยู่";
            // 
            // txtbox_update_address
            // 
            this.txtbox_update_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "address", true));
            this.txtbox_update_address.Location = new System.Drawing.Point(471, 281);
            this.txtbox_update_address.Multiline = true;
            this.txtbox_update_address.Name = "txtbox_update_address";
            this.txtbox_update_address.Size = new System.Drawing.Size(165, 61);
            this.txtbox_update_address.TabIndex = 109;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(146, 461);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 25);
            this.btn_delete.TabIndex = 110;
            this.btn_delete.Text = "ลบข้อมูล";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // checkBox_update_admin
            // 
            this.checkBox_update_admin.AutoSize = true;
            this.checkBox_update_admin.Location = new System.Drawing.Point(471, 348);
            this.checkBox_update_admin.Name = "checkBox_update_admin";
            this.checkBox_update_admin.Size = new System.Drawing.Size(116, 17);
            this.checkBox_update_admin.TabIndex = 111;
            this.checkBox_update_admin.Text = "อนุญาตสิทธิแอดมิน";
            this.checkBox_update_admin.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(986, 461);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 113;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(1114, 461);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 25);
            this.btn_home.TabIndex = 112;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 506);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.checkBox_update_admin);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtbox_update_password);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtbox_update_name);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtbox_update_surname);
            this.Controls.Add(label8);
            this.Controls.Add(this.txtbox_update_email);
            this.Controls.Add(label11);
            this.Controls.Add(this.txtbox_update_phone);
            this.Controls.Add(label12);
            this.Controls.Add(this.txtbox_update_idno);
            this.Controls.Add(label13);
            this.Controls.Add(this.txtbox_update_address);
            this.Controls.Add(this.comboBox_update_user);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(label14);
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
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label10);
            this.Controls.Add(label6);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_login;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HotelDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_surname;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_phone;
        private System.Windows.Forms.TextBox txtbox_idno;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.CheckBox checkBox_admin;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox comboBox_update_user;
        private System.Windows.Forms.TextBox txtbox_update_password;
        private System.Windows.Forms.TextBox txtbox_update_name;
        private System.Windows.Forms.TextBox txtbox_update_surname;
        private System.Windows.Forms.TextBox txtbox_update_email;
        private System.Windows.Forms.TextBox txtbox_update_phone;
        private System.Windows.Forms.TextBox txtbox_update_idno;
        private System.Windows.Forms.TextBox txtbox_update_address;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox checkBox_update_admin;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox txtbox_username;
    }
}