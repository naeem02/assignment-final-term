using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AccessData
{
    class DataAccess : IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataAccess()
        {
            con = new SqlConnection(GlobalConfig.GetConnectionString());
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        #region Open Close Connection
        public void OpenConnection()
        {
            this.con.Open();
        }
        public void Dispose()
        {
            this.con.Close();
        }
        #endregion

        public DataTable SqlDataTable(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            SqlDataReader result = this.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if (result.HasRows)
            {
                dt.Load(result);
            }
            this.Dispose();
            return dt;
        }

        public SqlDataReader SqlExecuteReader(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            SqlDataReader sdr = this.cmd.ExecuteReader();
            return sdr;
        }
    }
}
