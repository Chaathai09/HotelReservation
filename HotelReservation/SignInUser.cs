﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace HotelReservation
{
    public partial class SignInUser : Form
    {
        public int currentUserID { get; set;  }
        public string currentUserName { get; set; }
        public static SignInUser instance;
        public SignInUser()
        {
            InitializeComponent();
            instance = this;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toprn\source\repos\HotelReservation\HotelReservation\HotelDB.mdf;Integrated Security=True");

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signup_window = new SignUp();
            signup_window.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home_window = new Home();
            home_window.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtbox_user.Text;
            password = txtbox_password.Text;

            int matchedUser = 0;
            String user_query = "SELECT COUNT(*) FROM Users WHERE username = '" + username + "' AND password = '" + password + "' AND isAdmin = 0";
            using (SqlCommand cmdCount = new SqlCommand(user_query, conn))
            {
                conn.Open();
                matchedUser = (int)cmdCount.ExecuteScalar();
            }
            conn.Close();

            if (matchedUser > 0)
            {
                String current_user_query = "SELECT * FROM Users WHERE username = '" + username + "' AND password = '" + password + "' AND isAdmin = 0";
                SqlCommand command = new SqlCommand(current_user_query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        currentUserID = Int32.Parse(reader["userID"].ToString());
                        currentUserName = reader["name"].ToString();
                        break;
                    }
                    conn.Close();
                }
                Reservation_Room reservation_Room = new Reservation_Room();
                reservation_Room.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลผู้ใช้งานดังกล่าวหรือรหัสผ่านผิด", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_user.Focus();
                return;
            }
        }

        private void SignInUser_Load(object sender, EventArgs e)
        {

        }

        /*private void test_btn_Click(object sender, EventArgs e)
        {
            test_label.Text = "";

            String admin_query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(admin_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    test_label.Text += reader["username"].ToString() + " ";
                }
                conn.Close();
            }
        }*/
    }
}