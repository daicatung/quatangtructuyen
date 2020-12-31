using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class Product_BUS
    {
        Lop_DAL da = new Lop_DAL();
        Product_DTO L = new Product_DTO();

        public DataTable ShowProduct()
        {
            string sql = "SELECT * FROM   Product ORDER BY ProductID DESC";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable Show8AProduct(int id)
        {
            string sql = "SELECT * FROM   Product WHERE CategoryID='" + id+"'" ;
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowAProduct(int id)
        {
            string sql = "SELECT * FROM   Product WHERE ProductID='" + id+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowCategory()
        {
            string sql = "SELECT * FROM Categoryy";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
