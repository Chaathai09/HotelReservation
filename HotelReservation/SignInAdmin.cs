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
    public partial class SignInAdmin : Form
    {
        public SignInAdmin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toprn\source\repos\HotelReservation\HotelReservation\HotelDB.mdf;Integrated Security=True");

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtbox_user.Text;
            password = txtbox_password.Text;

                bool isMatched = false;
                String admin_query = "SELECT * FROM Users WHERE isAdmin = 1";
                SqlCommand command = new SqlCommand(admin_query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        if (reader["username"].ToString() == username && reader["password"].ToString() == password) { 
                            isMatched = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    conn.Close();
                }

                if (isMatched)
                {
                    username = txtbox_user.Text;
                    password = txtbox_password.Text;

                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลแอดมินดังกล่าวหรือรหัสผ่านผิด", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_user.Focus();
                    return;
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
