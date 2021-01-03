using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class DetailsProduct_BUS
    {
        Lop_DAL da = new Lop_DAL();
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        public DataTable ShowProductWithID(int id)
        {
            string sql = "SELECT * FROM   Product WHERE ProductID='" + id + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowDetailsProduct(int id)
        {
            string sql = "SELECT * FROM   DetailProduct WHERE ProductID='" + id + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
