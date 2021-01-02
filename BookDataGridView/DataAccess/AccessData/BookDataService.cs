using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AccessData
{
    public class BookDataService
    {
        DataAccess da = new DataAccess();
        public BookDataService()
        {

        }
        public DataTable GetBookInfo(string bname)
        {
            return da.SqlDataTable("spGetBookInfo","@bn",bname);
        }

        public DataTable GetAllBooksInfo()
        {
            return da.SqlDataTable("spGetAllBooksInfo");
        }
    }
}
