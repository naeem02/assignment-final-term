using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductService
    {
        DataAccess.AccessData.BookDataService bds;
        public ProductService()
        {
            bds = new DataAccess.AccessData.BookDataService();
        }
        public DataTable GetBookInfo(string bn)
        {
            return bds.GetBookInfo(bn);
        }
        public DataTable GetAllBooksInfo()
        {
            return bds.GetAllBooksInfo();
        }

    }
    
}
