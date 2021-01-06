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
        public DataTable ShowProductCategory(int Categoryid)
        {
            string sql = "SELECT * FROM   Product where CategoryID = '"+Categoryid+"' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowCategory()
        {
            string sql = "SELECT * FROM   Category";
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
        public DataTable SearchProduct(string content)
        {
            string sql = "SELECT * FROM Product WHERE ProductName LIKE N'%" + content + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowCategoryy(int Categoryid)
        {
            string sql = "SELECT * FROM Category WHERE CategoryID = '" + Categoryid+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertProduct(string CategoryID, string ProductName, string Photo, string Quantity, string Cost)
        {
            string sql = "Insert Product values(N'" + CategoryID + "',N'" + ProductName + "',N'~/images/products/" + Photo + "',N'" + Quantity + "',N'" + Cost + "')";
            da.ExecuteNonQuery(sql);
        }
        
        public void UpdateProduct(string ProductID, string CategoryID, string ProductName, string Photo, string Quantity, string Cost)
        {
            string sql = "update Product set CategoryID=N'" + CategoryID + "', ProductName=N'" + ProductName + "', Photo=N'~/images/products/" + Photo + "', Quantity=N'" + Quantity + "', Cost=N'" + Cost + "' where ProductID =N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }

        public void DeleteProduct(string ProductID)
        {
            string sql = "Delete Product where ProductID=N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }
        public DataTable ShowVendor()
        {
            string sql = "SELECT * FROM Vendor";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void UpdateProduct(int proID, int venID, int cateID, string proName, string des, string photo, int quantity, decimal cost, int state)
        {
            string sql = "UPDATE Product SET VendorID='" + venID + "',CategoryID='" + cateID + "',ProductName=N'" + proName + "',Description=N'" + des + "',Photo='~/Public/images/products/" + photo + "',Quantity='" + quantity + "',Cost='" + cost + "',ProductState='" + state + "' WHERE ProductID='" + proID + "'";
            da.ExecuteNonQuery(sql);
        }

     
    }
}
