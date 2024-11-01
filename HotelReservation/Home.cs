﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Text = "ระบบการจองห้องพักโรงแรม";
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
            DisplayAvailableRoom(DateTime.Today, DateTime.Today);
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True");

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            SignInUser login_window = new SignInUser();
            login_window.Show();
            this.Hide();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            SignInAdmin signInAdmin_window = new SignInAdmin();
            signInAdmin_window.Show();
            this.Hide();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            listView_available.Items.Clear();
            DisplayAvailableRoom(calendar_checkin.SelectionRange.Start,calendar_checkout.SelectionRange.Start);
        }

        
        private void DisplayAvailableRoom(DateTime startDate, DateTime endDate)
        {
            string startDateQ = startDate.ToShortDateString();
            string endDateQ = endDate.ToShortDateString();

            //แสดงห้องที่ไม่ได้มีการจองเกิดขึ้นในช่วงเวลาดังกล่าว โดยใช้ foreign key ที่เชื่อมกันระหว่าง 2 table และเปรียบเทียบช่วงเวลา
            String room_query = "SELECT roomID from Rooms EXCEPT SELECT reserveRoomID FROM Reservations WHERE ('" + startDateQ+"' >= startDate OR '"+endDateQ+"' >= startDate) AND ('"+startDateQ+"' <= endDate OR '"+endDateQ+"' <= endDate)";
            
            //เพิ่มรายชื่อห้องแล้วแสดงออกมา
            SqlCommand command = new SqlCommand(room_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listView_available.Items.Add(reader["roomID"].ToString());
                }
                conn.Close();
            }
        }

        private void calendar_checkout_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
        }

        private void calendar_checkin_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("https://docs.google.com/document/d/1xaGmFLggQC3XbPXzfPvV4FqVbuiWB53j0eWQSOrsB7c/edit?usp=sharing");
            Process.Start(processStartInfo);
        }
    }
}
