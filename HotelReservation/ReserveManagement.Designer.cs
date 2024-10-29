namespace HotelReservation
{
    partial class AdminPanel
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.hotelDBDataSet = new HotelReservation.HotelDBDataSet();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsTableAdapter = new HotelReservation.HotelDBDataSetTableAdapters.ReservationsTableAdapter();
            this.tableAdapterManager = new HotelReservation.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.reservationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.datePicker_checkin = new System.Windows.Forms.DateTimePicker();
            this.datePicker_checkout = new System.Windows.Forms.DateTimePicker();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_reserveID = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.datePicker_update_checkout = new System.Windows.Forms.DateTimePicker();
            this.datePicker_update_checkin = new System.Windows.Forms.DateTimePicker();
            this.comboBox_update_room = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_update_user = new System.Windows.Forms.ComboBox();
            this.comboBox_update_reserveID = new System.Windows.Forms.ComboBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(39, 102);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(63, 15);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(39, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 15);
            label2.TabIndex = 15;
            label2.Text = "ห้อง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(39, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 18;
            label3.Text = "วันที่เข้าพัก";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(39, 182);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 15);
            label4.TabIndex = 20;
            label4.Text = "วันที่ออก";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(39, 271);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 15);
            label6.TabIndex = 30;
            label6.Text = "รหัสการจอง";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(40, 480);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 15);
            label7.TabIndex = 40;
            label7.Text = "วันที่ออก";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(40, 454);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 15);
            label8.TabIndex = 38;
            label8.Text = "วันที่เข้าพัก";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(40, 427);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(25, 15);
            label9.TabIndex = 35;
            label9.Text = "ห้อง";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(40, 400);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(63, 15);
            label11.TabIndex = 32;
            label11.Text = "ชื่อ-นามสกุล";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(40, 373);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(61, 15);
            label12.TabIndex = 43;
            label12.Text = "รหัสการจอง";
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReservationsTableAdapter = this.reservationsTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelReservation.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // reservationsDataGridView
            // 
            this.reservationsDataGridView.AutoGenerateColumns = false;
            this.reservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.reservationsDataGridView.DataSource = this.reservationsBindingSource;
            this.reservationsDataGridView.Location = new System.Drawing.Point(243, 73);
            this.reservationsDataGridView.Name = "reservationsDataGridView";
            this.reservationsDataGridView.Size = new System.Drawing.Size(545, 457);
            this.reservationsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "reserveID";
            this.dataGridViewTextBoxColumn1.HeaderText = "reserveID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "reserveUserID";
            this.dataGridViewTextBoxColumn2.HeaderText = "reserveUserID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "reserveRoomID";
            this.dataGridViewTextBoxColumn3.HeaderText = "reserveRoomID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "startDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "startDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "endDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "endDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_login.Location = new System.Drawing.Point(13, 19);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(278, 25);
            this.lbl_login.TabIndex = 10;
            this.lbl_login.Text = "ระบบจัดการรายการจองห้องพัก";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_admin.Location = new System.Drawing.Point(18, 47);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(103, 16);
            this.lbl_admin.TabIndex = 11;
            this.lbl_admin.Text = "สำหรับแอดมินเท่านั้น";
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(103, 101);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(121, 21);
            this.comboBox_user.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "เพิ่มข้อมูลการจองพัก";
            // 
            // comboBox_room
            // 
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(103, 128);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(121, 21);
            this.comboBox_room.TabIndex = 16;
            // 
            // datePicker_checkin
            // 
            this.datePicker_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_checkin.Location = new System.Drawing.Point(103, 155);
            this.datePicker_checkin.Name = "datePicker_checkin";
            this.datePicker_checkin.Size = new System.Drawing.Size(121, 20);
            this.datePicker_checkin.TabIndex = 17;
            // 
            // datePicker_checkout
            // 
            this.datePicker_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_checkout.Location = new System.Drawing.Point(103, 181);
            this.datePicker_checkout.Name = "datePicker_checkout";
            this.datePicker_checkout.Size = new System.Drawing.Size(121, 20);
            this.datePicker_checkout.TabIndex = 19;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(103, 207);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(122, 25);
            this.btn_insert.TabIndex = 21;
            this.btn_insert.Text = "เพิ่มข้อมูล";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(18, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ลบข้อมูลการจองพัก";
            // 
            // comboBox_reserveID
            // 
            this.comboBox_reserveID.FormattingEnabled = true;
            this.comboBox_reserveID.Location = new System.Drawing.Point(103, 270);
            this.comboBox_reserveID.Name = "comboBox_reserveID";
            this.comboBox_reserveID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_reserveID.TabIndex = 29;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(102, 297);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 25);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "ลบข้อมูล";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(104, 505);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 25);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "เปลี่ยนข้อมูล";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // datePicker_update_checkout
            // 
            this.datePicker_update_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_update_checkout.Location = new System.Drawing.Point(104, 479);
            this.datePicker_update_checkout.Name = "datePicker_update_checkout";
            this.datePicker_update_checkout.Size = new System.Drawing.Size(121, 20);
            this.datePicker_update_checkout.TabIndex = 39;
            // 
            // datePicker_update_checkin
            // 
            this.datePicker_update_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_update_checkin.Location = new System.Drawing.Point(104, 453);
            this.datePicker_update_checkin.Name = "datePicker_update_checkin";
            this.datePicker_update_checkin.Size = new System.Drawing.Size(121, 20);
            this.datePicker_update_checkin.TabIndex = 37;
            // 
            // comboBox_update_room
            // 
            this.comboBox_update_room.FormattingEnabled = true;
            this.comboBox_update_room.Location = new System.Drawing.Point(104, 426);
            this.comboBox_update_room.Name = "comboBox_update_room";
            this.comboBox_update_room.Size = new System.Drawing.Size(121, 21);
            this.comboBox_update_room.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label10.Location = new System.Drawing.Point(19, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "ค้นหา/เปลี่ยนแปลงข้อมูลการจองพัก";
            // 
            // comboBox_update_user
            // 
            this.comboBox_update_user.FormattingEnabled = true;
            this.comboBox_update_user.Location = new System.Drawing.Point(104, 399);
            this.comboBox_update_user.Name = "comboBox_update_user";
            this.comboBox_update_user.Size = new System.Drawing.Size(121, 21);
            this.comboBox_update_user.TabIndex = 33;
            // 
            // comboBox_update_reserveID
            // 
            this.comboBox_update_reserveID.FormattingEnabled = true;
            this.comboBox_update_reserveID.Location = new System.Drawing.Point(104, 372);
            this.comboBox_update_reserveID.Name = "comboBox_update_reserveID";
            this.comboBox_update_reserveID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_update_reserveID.TabIndex = 42;
            this.comboBox_update_reserveID.SelectedIndexChanged += new System.EventHandler(this.comboBox_update_reserveID_SelectedIndexChanged);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(666, 539);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 25);
            this.btn_home.TabIndex = 44;
            this.btn_home.Text = "กลับสู่หน้าหลัก";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(538, 539);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 45;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(label12);
            this.Controls.Add(this.comboBox_update_reserveID);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(label7);
            this.Controls.Add(this.datePicker_update_checkout);
            this.Controls.Add(label8);
            this.Controls.Add(this.datePicker_update_checkin);
            this.Controls.Add(this.comboBox_update_room);
            this.Controls.Add(label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_update_user);
            this.Controls.Add(label11);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(label6);
            this.Controls.Add(this.comboBox_reserveID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(label4);
            this.Controls.Add(this.datePicker_checkout);
            this.Controls.Add(label3);
            this.Controls.Add(this.datePicker_checkin);
            this.Controls.Add(this.comboBox_room);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.reservationsDataGridView);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private HotelDBDataSetTableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reservationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.DateTimePicker datePicker_checkin;
        private System.Windows.Forms.DateTimePicker datePicker_checkout;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_reserveID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DateTimePicker datePicker_update_checkout;
        private System.Windows.Forms.DateTimePicker datePicker_update_checkin;
        private System.Windows.Forms.ComboBox comboBox_update_room;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_update_user;
        private System.Windows.Forms.ComboBox comboBox_update_reserveID;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
    }
}