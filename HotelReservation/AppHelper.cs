using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["HotelReservation.Properties.Settings.HotelDBConnection"].ConnectionString;
    }
}
