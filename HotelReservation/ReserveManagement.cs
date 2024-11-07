using System;
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

namespace HotelReservation
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            UpdatePanel();
        }

        //ชุดข่อมูลชั่วคราวเพื่อเก็บชื่อจริง (ชื่อ + นามสกุล) ให้ match กับ userID โดยที่ไม่ต้องเรียกฐานข้อมูลหลายรอบ
        struct UserStruct
        {
            public UserStruct(int userID, string fullName)
            {
                this.userID = userID;
                this.fullName = fullName;
            }

            public int userID { get; set; }
            public string fullName { get; set; }
        }
        List<UserStruct> users = new List<UserStruct>();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True");

        private void UpdatePanel()
        {
            this.reservationsTableAdapter.Fill(this.hotelDBDataSet.Reservations);
            InitializeUserComboBox();
            InitializeRoomComboBox();
            InitializeReservationComboBox();
            InitializeUpdateBox();
        }

        //กำหนดให้ dropdown ที่เลือก user สามารถดึงข้อมูลมาจากฐานข้อมูลมาใช้แสดงและเลือกได้
        private void InitializeUserComboBox()
        {
            users.Clear();
            comboBox_user.Items.Clear();
            String user_query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(user_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    String fullName = reader["name"].ToString() + " " + reader["surname"].ToString();
                    UserStruct user = new UserStruct((int)reader["userID"], fullName);
                    users.Add(user);
                    comboBox_user.Items.Add(fullName);
                }
                conn.Close();
            }
        }

        //กำหนดให้ dropdown ที่เลือกห้อง สามารถดึงข้อมูลมาจากฐานข้อมูลมาใช้แสดงและเลือกได้
        private void InitializeRoomComboBox()
        {
            comboBox_room.Items.Clear();
            String room_query = "SELECT * FROM Rooms";
            SqlCommand command = new SqlCommand(room_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_room.Items.Add(reader["roomID"].ToString());
                }
                conn.Close();
            }
        }

        //กำหนดให้ dropdown ที่เลือกรายการจองพัก สามารถดึงข้อมูลมาจากฐานข้อมูลมาใช้แสดงและเลือกได้
        private void InitializeReservationComboBox()
        {
            comboBox_reserveID.Items.Clear();
            String reserve_query = "SELECT * FROM Reservations";
            SqlCommand reserve_command = new SqlCommand(reserve_query, conn);
            conn.Open();
            using (SqlDataReader reader = reserve_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_reserveID.Items.Add(reader["reserveID"].ToString());
                }
                conn.Close();
            }
        }

        //กำหนดค่าในแต่ละ dropdown ในฟีทเจอร์การอัพเดทข้อมูล แต่ละ field จะดึงมาจากฐานข้อมูล 
        private void InitializeUpdateBox()
        {
            comboBox_update_reserveID.Items.Clear();
            String reserve_query = "SELECT * FROM Reservations";
            SqlCommand reserve_command = new SqlCommand(reserve_query, conn);
            conn.Open();
            using (SqlDataReader reader = reserve_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_update_reserveID.Items.Add(reader["reserveID"].ToString());
                }
                conn.Close();
            }

            comboBox_update_user.Items.Clear();
            String user_query = "SELECT * FROM Users";
            SqlCommand user_command = new SqlCommand(user_query, conn);
            conn.Open();
            using (SqlDataReader reader = user_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    String fullName = reader["name"].ToString() + " " + reader["surname"].ToString();
                    comboBox_update_user.Items.Add(fullName);
                }
                conn.Close();
            }

            comboBox_update_room.Items.Clear();
            String room_query = "SELECT * FROM Rooms";
            SqlCommand room_command = new SqlCommand(room_query, conn);
            conn.Open();
            using (SqlDataReader reader = room_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_update_room.Items.Add(reader["roomID"].ToString());
                }
                conn.Close();
            }
        }

        private void reservationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotelDBDataSet.Reservations);

        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            string startDate = datePicker_checkin.Value.ToShortDateString(); 
            string endDate = datePicker_checkout.Value.ToShortDateString();

            //ตรวจสอบว่าห้องดังกล่าวมีข้อมูลซ้ำกันหรือไม่ เช่น ช่วงเวลาพักทับซ้อนกัน
            try
            {
                String query = "SELECT * FROM Reservations WHERE reserveRoomID = '"+comboBox_room.SelectedItem.ToString() + "' AND startDate <= '" + startDate + "' AND endDate >= '" + endDate + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dTable = new DataTable();
                sqlDataAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("ห้องดังกล่าวถูกจองไว้แล้ว กรุณาลบข้อมูลดังการจองห้องนั้นก่อนเพิ่มใหม่", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error");;
            }

            //เพิ่มข้อมูลโดยอิง userID ที่เก็บชั่วคราวเอาไว้ และเทียบกับ input ของผู้ใช้
            IReserveRepository repository = new ReservationRepository();
            bool result = await repository.Insert(new Reservation()
            {
                ReserveUserID = users.Find(u => u.fullName == comboBox_user.SelectedItem.ToString()).userID,
                ReserveRoomId = Int32.Parse(comboBox_room.SelectedItem.ToString()),
                StartDate = datePicker_checkin.Value,
                EndDate = datePicker_checkout.Value
            });
            if (result) {
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อย!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลการจองดังกล่าวได้ กรุณาติดต่อผู้ดูแลระบบ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdatePanel();
        }

        //ลบข้อมูลจากฐานข้อมูล
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าได้เลือกข้อมูลที่จะลบหรือไม่
            if (comboBox_reserveID.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกรายการจองพักก่อนที่จะทำการลบข้อมูล", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.Open();
            SqlCommand deleteCmd = conn.CreateCommand();

            //ลบฐานข้อมูลที่มีรายการจองพักตรงกับที่เลือก
            deleteCmd.CommandText = "DELETE FROM Reservations WHERE reserveID = '"+comboBox_reserveID.SelectedItem.ToString()+"'";
            deleteCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdatePanel();
        }

        //อัพเดทข้อมูลของแต่ละรายการจองพัก
        private void btn_update_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าได้เลือกข้อมูลที่จะอัพเดทหรือไม่
            if (comboBox_update_reserveID.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกรายการจองพักก่อนที่จะทำการอัพเดท", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reserveID = Int32.Parse(comboBox_update_reserveID.SelectedItem.ToString());
            int userID = users.Find(u => u.fullName == comboBox_update_user.SelectedItem.ToString()).userID;
            int roomID = Int32.Parse(comboBox_update_room.SelectedItem.ToString());
            string startDate = datePicker_update_checkin.Value.ToShortDateString();
            string endDate = datePicker_update_checkout.Value.ToShortDateString();

            //ตรวจสอบว่าข้อมูลที่อัพเดทของแต่ละรายการจองพัก ทับซ้อนกับข้อมูลที่มีอยู่หรือไม่
            try
            {
                String query = "SELECT * FROM Reservations WHERE reserveRoomID = '" + comboBox_update_reserveID.SelectedItem.ToString() + "' AND startDate <= '" + startDate + "' AND endDate >= '" + endDate + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dTable = new DataTable();
                sqlDataAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("ห้องดังกล่าวถูกจองไว้แล้ว กรุณาลบข้อมูลดังการจองห้องนั้นก่อนอัพเดทข้อมูลใหม่", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            conn.Open();
            SqlCommand updateCmd = conn.CreateCommand();

            //สั่งอัพเดทฐานข้อมูลตามข้อมูลที่รับเข้ามา
            updateCmd.CommandText = "UPDATE Reservations SET reserveUserID = @reserveUserID, reserveRoomID = @reserveRoomID, startDate = @startDate, endDate = @endDate WHERE reserveID = @reserveID";
            updateCmd.Parameters.AddWithValue("@reserveUserID", userID);
            updateCmd.Parameters.AddWithValue("@reserveRoomID", roomID);
            updateCmd.Parameters.AddWithValue("@startDate", startDate);
            updateCmd.Parameters.AddWithValue("@endDate", endDate);
            updateCmd.Parameters.AddWithValue("@reserveID", reserveID);
            updateCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("อัพเดทข้อมูลเรียบร้อย!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdatePanel();
        }

        //แสดงข้อมูลที่เกี่ยวข้องกันในแต่ละรายการจองให้สอดคล้องกัน
        private void comboBox_update_reserveID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reserveID = Int32.Parse(comboBox_update_reserveID.SelectedItem.ToString());
            int currentUser = 0;
            int currentRoom = 0;
            DateTime currentCheckin = DateTime.Now;
            DateTime currentCheckout   = DateTime.Now;

            //ดึงข้อมูลอื่น ๆ ที่เป็น field เดียวกับรายการจองนั้นจากฐานข้อมูลและนำมาแสดงให้ตรงกัน
            String reserve_query = "SELECT * FROM Reservations WHERE reserveID = '"+reserveID+"'";
            SqlCommand command = new SqlCommand(reserve_query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentUser = Int32.Parse(reader["reserveUserID"].ToString());
                    currentRoom = Int32.Parse(reader["reserveRoomID"].ToString());
                    currentCheckin = DateTime.Parse(reader["startDate"].ToString());
                    currentCheckout = DateTime.Parse(reader["endDate"].ToString());
                }
                conn.Close();
            }

            comboBox_update_user.Text = users.Find(u => u.userID == currentUser).fullName;
            comboBox_update_room.Text = currentRoom.ToString();
            datePicker_update_checkin.Value = currentCheckin;
            datePicker_update_checkout.Value = currentCheckout;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
