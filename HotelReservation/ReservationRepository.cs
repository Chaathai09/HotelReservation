using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HotelReservation
{
    //Class ช่วยสำหรับการเพิ่มข้อมูลรายการจองพักโดยไม่ต้องเขียนโค้ดหลายรอบ
    public class ReservationRepository : IReserveRepository
    {
        public async Task<bool> Insert(Reservation reservation)
        {
            //เชื่อมต่อกับฐานข้อมูล
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                //ใช้ SQL command ที่บันทึกไว้ใน properties ของ solution แทนการเขียนตรง ๆ ผ่านโค้ด
                var result = await db.ExecuteAsync(HotelReservation.Properties.Resources.InsertReservation, new
                {
                    reserveUserID = reservation.ReserveUserID,
                    reserveRoomID = reservation.ReserveRoomId,
                    startDate = reservation.StartDate.ToShortDateString(),
                    endDate = reservation.EndDate.ToShortDateString(),
                });
                return result > 0;
            }
        }
    }
}
