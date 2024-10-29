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
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
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
