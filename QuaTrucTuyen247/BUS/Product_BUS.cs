using DAL;
using DTO;
using System.Data;

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
            string sql = "SELECT * FROM   Product WHERE CategoryID='" + id + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowAProduct(int id)
        {
            string sql = "SELECT * FROM   Product WHERE ProductID='" + id + "'";
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

        public void InsertProduct(string CategoryID, string ProductName, string Photo, string Quantity, string Cost)
        {
            string sql = "Insert Product values(N'" + CategoryID + "',N'" + ProductName + "',N'" + Photo + "',N'" + Quantity + "',N'" + Cost + "')";
            da.ExecuteNonQuery(sql);
        }
        
        public void UpdateProduct(string ProductID, string CategoryID, string ProductName, string Photo, string Quantity, string Cost)
        {
            string sql = "update Product set CategoryID=N'" + CategoryID + "', ProductName=N'" + ProductName + "', Photo=N'" + Photo + "', Quantity=N'" + Quantity + "', Cost=N'" + Cost + "' where ProductID =N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }

        public void DeleteProduct(string ProductID)
        {
            string sql = "Delete Product where ProductID=N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
