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
    public class DetailsProduct_BUS
    {
        Lop_DAL da = new Lop_DAL();
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        public DataTable ShowProductWithID(int id)
        {
            string sql = "SELECT * FROM   Product WHERE ProductID='" + id+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowDetailsProduct(int id)
        {
            string sql = "SELECT * FROM   DetailProduct WHERE ProductID='" + id+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
