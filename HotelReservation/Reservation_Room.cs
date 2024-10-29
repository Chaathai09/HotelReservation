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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelReservation
{
    public partial class Reservation_Room : Form
    {
        public Reservation_Room()
        {
            InitializeComponent();
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
            lbl_user.Text = "ยินดีต้อนรับ, คุณ " + SignInUser.instance.currentUserName;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toprn\source\repos\HotelReservation\HotelReservation\HotelDB.mdf;Integrated Security=True");
        private struct ReservationOrder
        {
            public ReservationOrder(string roomID, int cost, DateTime startDate, DateTime endDate)
            {
                this.roomID = roomID;
                this.cost = cost;
                this.startDate = startDate;
                this.endDate = endDate;
            }

            public string roomID { get; set; }
            public int cost { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
        }
        List<ReservationOrder> orders = new List<ReservationOrder>();

        private void ClearOrders()
        {
            orders.Clear();
            listbox_reserved.Items.Clear();
            lbl_total.Text = "ยอดชำระทั้งหมด : 0 บาท";
        }

        private void AddOrder(string roomID)
        {
            int cost = comboBox_floor.Text.ToString()[0] == '4' ? 3000 : 2000;
            DateTime startDate = calendar_checkin.SelectionRange.Start;
            DateTime endDate = calendar_checkout.SelectionRange.Start;

            if (orders.Where(o => o.roomID == roomID && (startDate >= o.startDate || endDate <= o.endDate)).ToList().Count > 0)
            {
                MessageBox.Show("คุณได้ทำการจองห้องนี้ในช่วงเวลาดังกล่าวแล้ว! \nกรุณาลองทำการจองใหม่อีกครั้ง", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReservationOrder order = new ReservationOrder(roomID, cost, startDate, endDate);

            orders.Add(order);
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            listbox_reserved.Items.Clear();
            listbox_reserved.ItemHeight = 26;
            int totalCost = 0;
            foreach (ReservationOrder order in orders) {
                totalCost += order.cost;
                string orderText = "ห้อง " + order.roomID + " | ราคา " + order.cost.ToString("#,###") + " บาท"
                                   + " | " + "วันที่ " + order.startDate.ToShortDateString() + " ถึง " + order.endDate.ToShortDateString();
                listbox_reserved.Items.Add(orderText);
            }
            lbl_total.Text = "ยอดชำระทั้งหมด : " + totalCost.ToString("#,###") + " บาท";
        }

        private void Reservation_Room_Load(object sender, EventArgs e)
        {
            ClearOrders();
            comboBox_floor.SelectedIndex = 0;
        }

        private void InitializeRoomButton()
        {
            btn_room1.Enabled = true;
            btn_room2.Enabled = true;
            btn_room3.Enabled = true;
            btn_room4.Enabled = true;
            btn_room5.Enabled = true;
        }

        private void ChangeRoomButton(string floor)
        {
            InitializeRoomButton();
            btn_room1.Text = floor + "01";
            btn_room2.Text = floor + "02";
            btn_room3.Text = floor + "03";
            btn_room4.Text = floor + "04";
            btn_room5.Text = floor + "05";

            string startDate = calendar_checkin.SelectionRange.Start.ToShortDateString();
            string endDate = calendar_checkout.SelectionRange.Start.ToShortDateString();
            String room_query = "SELECT * FROM Reservations WHERE ('"+startDate+"' >= startDate OR '"+endDate+"' >= startDate) AND ('"+startDate+"' <= endDate OR '"+endDate+"' <= endDate)";
            SqlCommand command = new SqlCommand(room_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string currentRoom = reader["reserveRoomID"].ToString();
                    if (currentRoom == btn_room1.Text)
                    {
                        btn_room1.Enabled = false;
                    }
                    if (currentRoom == btn_room2.Text)
                    {
                        btn_room2.Enabled = false;
                    }
                    if (currentRoom == btn_room3.Text)
                    {
                        btn_room3.Enabled = false;
                    }
                    if (currentRoom == btn_room4.Text)
                    {
                        btn_room4.Enabled = false;
                    }
                    if (currentRoom == btn_room5.Text)
                    {
                        btn_room5.Enabled = false;
                    }
                }
                conn.Close();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home_window = new Home();
            home_window.Show();
            this.Hide();
        }

        private void comboBox_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRoomButton(comboBox_floor.Text);
        }

        private void calendar_checkin_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
            ChangeRoomButton(comboBox_floor.Text);
        }

        private void calendar_checkout_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_checkout.MinDate = calendar_checkin.SelectionRange.Start;
            ChangeRoomButton(comboBox_floor.Text);
        }

        private void btn_room1_Click(object sender, EventArgs e)
        {
            AddOrder(btn_room1.Text);
        }

        private void btn_room2_Click(object sender, EventArgs e)
        {
            AddOrder(btn_room2.Text);
        }

        private void btn_room3_Click(object sender, EventArgs e)
        {
            AddOrder(btn_room3.Text);
        }

        private void btn_room4_Click(object sender, EventArgs e)
        {
            AddOrder(btn_room4.Text);
        }

        private void btn_room5_Click(object sender, EventArgs e)
        {
            AddOrder(btn_room5.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearOrders();
        }

        private async void btn_submit_Click_1(object sender, EventArgs e)
        {
            int totalOrder = orders.Count;
            if(totalOrder == 0)
            {
                MessageBox.Show("กรุณาทำรายการจองอย่างน้อย 1 รายการ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool reserveStatus = false;
            foreach (ReservationOrder order in orders)
            {
                IReserveRepository repository = new ReservationRepository();
                bool result = await repository.Insert(new Reservation()
                {
                    ReserveUserID = SignInUser.instance.currentUserID,
                    ReserveRoomId = Int32.Parse(order.roomID),
                    StartDate = order.startDate,
                    EndDate = order.endDate
                });

                if (!result)
                {
                    break;
                }
                reserveStatus = true;
            }
            if (reserveStatus)
            {
                MessageBox.Show("ทำการจองเสร็จสิ้น!\nรายการจองทั้งหมด " + totalOrder.ToString() + " ครั้ง\n" + lbl_total.Text.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("การจองล้มเหลว กรุณาติดต่อเจ้าหน้าที่", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
