using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            UpdatePanel();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True");


        private void UpdatePanel()
        {
            this.usersTableAdapter.Fill(this.hotelDBDataSet.Users);
            InitializeUserInsert();
            InitializeUserUpdate();
            InitializeUserDeleteComboBox();
        }

        private void InitializeUserInsert()
        {
            txtbox_username.Clear();
            txtbox_password.Clear();
            txtbox_name.Clear();
            txtbox_surname.Clear();
            txtbox_email.Clear();
            txtbox_phone.Clear();
            txtbox_idno.Clear();
            txtbox_address.Clear();
            checkBox_admin.Checked = false;
        }

        //นำข้อมูลจากฐานข้อมูล Users ให้มาแสดงและใช้งานผ่าน dropdown ได้
        private void InitializeUserDeleteComboBox()
        {
            comboBox_user.Items.Clear();
            String user_query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(user_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    comboBox_user.Items.Add(username);
                }
                conn.Close();
            }
        }

        //นำข้อมูลจากฐานข้อมูล Users ให้มาแสดงและใช้งานผ่าน dropdown ของการอัพเดทได้
        private void InitializeUserUpdate()
        {
            comboBox_update_user.Items.Clear();
            txtbox_update_password.Clear();
            txtbox_update_name.Clear();
            txtbox_update_surname.Clear();
            txtbox_update_email.Clear();
            txtbox_update_phone.Clear();
            txtbox_update_idno.Clear();
            txtbox_update_address.Clear();
            checkBox_update_admin.Checked = false;

            String user_query = "SELECT * FROM Users";
            SqlCommand user_command = new SqlCommand(user_query, conn);
            conn.Open();
            using (SqlDataReader reader = user_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    comboBox_update_user.Items.Add(username);
                }
                conn.Close();
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.hotelDBDataSet.Users);
            UpdatePanel();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        //แสดงข้อมูลที่เกี่ยวข้องจาก user ที่เลือกให้ตรงกับข้อมูลในฐานข้อมูล
        private void comboBox_update_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = comboBox_update_user.SelectedItem.ToString();
            string password = "";
            string name = "";
            string surname = "";
            string email = "";
            string phone = "";
            string identificationNo = "";
            string address = "";
            bool isAdmin = false;

            //เลือกข้อมูลจาก Users ที่มี username ตรงกับที่เลือก
            String user_query = "SELECT * FROM Users WHERE username = '" + username + "'";
            SqlCommand command = new SqlCommand(user_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    name = reader["name"].ToString();
                    surname = reader["surname"].ToString();
                    email = reader["email"].ToString();
                    phone = reader["phone"].ToString();
                    identificationNo = reader["identification_no"].ToString();
                    address = reader["address"].ToString();
                    if (reader["isAdmin"].ToString() == "False")
                        isAdmin = false;
                    else
                        isAdmin = true;
                }
                conn.Close();
            }

            comboBox_update_user.Text = username;
            txtbox_update_password.Text = password;
            txtbox_update_name.Text = name;
            txtbox_update_surname.Text = surname;
            txtbox_update_email.Text = email;
            txtbox_update_phone.Text = phone;
            txtbox_update_idno.Text = identificationNo;
            txtbox_update_address.Text = address;
            checkBox_update_admin.Checked = isAdmin;
        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
            if (string.IsNullOrEmpty(txtbox_username.Text) ||
                string.IsNullOrEmpty(txtbox_password.Text))
            {
                MessageBox.Show("กรุณาใส่ข้อมูลบัญชีให้ครบ!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_name.Focus();
                return;
            }

            //ตรวจสอบว่ามี username ที่ซ้ำกันหรือไม่
            try
            {
                String query = "SELECT * FROM Users WHERE username = '" + txtbox_username.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dTable = new DataTable();
                sqlDataAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("ชื่อผู้ใช้งานนี้ถูกใช้งานแล้ว กรุณาเปลี่ยนใหม่", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            //เพิ่มข้อมูลไปยัง database จาก input ที่กรอกเข้ามา
            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User()
            {
                Username = txtbox_username.Text,
                Password = txtbox_password.Text,
                IsAdmin = checkBox_admin.Checked ? 1 : 0,
                Name = txtbox_name.Text,
                Surname = txtbox_surname.Text,
                Email = txtbox_email.Text,
                Phone = txtbox_phone.Text,
                IdentificationNumber = txtbox_idno.Text,
                Address = txtbox_address.Text
            });

            if (result)
            {
                MessageBox.Show("เพิ่มข้อมูลบัญชีผู้ใช้สำเร็จ!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่อีกครั้ง", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdatePanel();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าได้เลือก user ที่จะลบแล้วหรือไม่
            if (comboBox_user.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกบัญชีผู้ใช้งานก่อนทำการลบข้อมูล", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername = comboBox_user.SelectedItem.ToString();
            try
            {
                //ค้นหาว่า user ดังกล่าวได้มีการทำรายการจองพักหรือไม่ ถ้ามี จะไม่สามารถลบข้อมูลได้ เพราะตารางข้อมูลการจองพักและข้อมูลผู้ใช้ถูกเชื่อมโยงกันและกัน
                String query = "SELECT Reservations.reserveID FROM Reservations JOIN Users ON Reservations.reserveUserID = Users.userID WHERE Users.username = '"+selectedUsername+"'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dTable = new DataTable();
                sqlDataAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("บัญชีผู้ใช้งานดังกล่าว ปรากฏอยู่ในฐานข้อมูลการทำรายการจองห้องพัก จำนวน " + dTable.Rows.Count.ToString() + " รายการ\n กรุณาลบรายการจองห้องพักก่อนจะลบบัญชีผู้ใช้งานนี้", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            conn.Open();
            SqlCommand deleteCmd = conn.CreateCommand();
            deleteCmd.CommandText = "DELETE FROM Users WHERE username = '" + selectedUsername + "'";
            deleteCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdatePanel();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าได้เลือกข้อมูล user ที่จะอัพเดทแล้วหรือยัง
            if(comboBox_update_user.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกบัญชีผู้ใช้งานก่อนทำการเปลี่ยนแปลงข้อมูล", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = comboBox_update_user.SelectedItem.ToString();
            string password = txtbox_update_password.Text;
            string name = txtbox_update_name.Text;
            string surname = txtbox_update_surname.Text;
            string email = txtbox_update_email.Text;
            string phone = txtbox_update_phone.Text;
            string identification_no = txtbox_update_idno.Text;
            string address = txtbox_update_address.Text;
            bool isAdmin = checkBox_update_admin.Checked;

            conn.Open();
            //อัพเดทข้อมูลไปยังฐานข้อมูลตามข้อมูลที่กรอกใหม่ โดยบันทึกไปยังข้อมูลที่มี username ตรงกันกับที่เลือก
            SqlCommand updateCmd = conn.CreateCommand();
            updateCmd.CommandText = "UPDATE Users SET password = @password, name = @name, surname = @surname, email = @email, phone = @phone, identification_no = @identification_no, address = @address, isAdmin = @isAdmin WHERE username = @username";
            updateCmd.Parameters.AddWithValue("@username", username);
            updateCmd.Parameters.AddWithValue("@password", password);
            updateCmd.Parameters.AddWithValue("@name", name);
            updateCmd.Parameters.AddWithValue("@surname", surname);
            updateCmd.Parameters.AddWithValue("@email", email);
            updateCmd.Parameters.AddWithValue("@phone", phone);
            updateCmd.Parameters.AddWithValue("@identification_no", identification_no);
            updateCmd.Parameters.AddWithValue("@address", address);
            updateCmd.Parameters.AddWithValue("@isAdmin", isAdmin);
            updateCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("อัพเดทข้อมูลเรียบร้อย!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdatePanel();
        }
    }
}
