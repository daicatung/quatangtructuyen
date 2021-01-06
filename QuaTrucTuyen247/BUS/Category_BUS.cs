using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BUS
{
   public class Category_BUS
    {
        Lop_DAL da = new Lop_DAL();
        public DataTable ShowCategory()
        {
            string sql = "SELECT * FROM   Category";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
