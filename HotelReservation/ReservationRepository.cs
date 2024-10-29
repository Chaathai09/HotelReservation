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
    public class ReservationRepository : IReserveRepository
    {
        public async Task<bool> Insert(Reservation reservation)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
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
