using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BUS
{
   public class Search_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        public DataTable SearchProduct(string content)
        {
            string sql = "SELECT * FROM Product WHERE ProductName LIKE N'%" + content + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
