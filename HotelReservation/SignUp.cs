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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toprn\source\repos\HotelReservation\HotelReservation\HotelDB.mdf;Integrated Security=True");

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Users' table. You can move, or remove it, as needed.
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_username.Text) || 
                string.IsNullOrEmpty(txtbox_password.Text) || 
                string.IsNullOrEmpty(txtbox_confirm_password.Text))
            {
                MessageBox.Show("กรุณาใส่ข้อมูลบัญชีให้ครบ!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_name.Focus();
                return;
            }

            if (txtbox_password.Text.Length < 8)
            {
                MessageBox.Show("รหัสผ่านต้องมีความยาวอย่างน้อย 8 ตัวอักษร", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtbox_password.Text != txtbox_confirm_password.Text)
            {
                MessageBox.Show("รหัสผ่านยืนยันไม่ตรงกัน!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User()
            {
                Username = txtbox_username.Text,
                Password = txtbox_password.Text,
                IsAdmin = 0,
                Name = txtbox_name.Text,
                Surname = txtbox_surname.Text,
                Email = txtbox_email.Text,
                Phone = txtbox_phone.Text,
                IdentificationNumber = txtbox_idno.Text,
                Address = txtbox_address.Text
            });

            if (result)
            {
                MessageBox.Show("สมัครสมาชิกสำเร็จ! กรุณาล็อกอินก่อนเข้าใช้งาน", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignInUser signInUser = new SignInUser();
                signInUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่อีกครั้ง", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home_window = new Home();
            home_window.Show();
            this.Hide();
        }
    }
}
