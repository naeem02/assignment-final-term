using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    public static class GlobalConfig
    {
        static GlobalConfig()
        {

        }

        public static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
            return connectionString;
        }
    }
}
