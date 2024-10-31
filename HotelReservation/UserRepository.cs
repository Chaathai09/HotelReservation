using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HotelReservation
{
    //Class ช่วยสำหรับการเพิ่มข้อมูลผู้ใช้งานโดยไม่ต้องเขียนโค้ดหลายรอบ
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            //เชื่อมต่อกับฐานข้อมูล
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                //ใช้ SQL command ที่บันทึกไว้ใน properties ของ solution แทนการเขียนตรง ๆ ผ่านโค้ด
                var result = await db.ExecuteAsync(HotelReservation.Properties.Resources.InsertUser, new
                {
                    username = user.Username,
                    password = user.Password,
                    isAdmin = user.IsAdmin,
                    name = user.Name,
                    surname = user.Surname,
                    email = user.Email,
                    phone = user.Phone,
                    identification_no = user.IdentificationNumber,
                    address = user.Address
                });
                return result > 0;
            }
        }
    }
}
