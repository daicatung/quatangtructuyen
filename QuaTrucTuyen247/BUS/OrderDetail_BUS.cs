using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class OrderDetail_BUS
    {
        Lop_DAL da = new Lop_DAL();
        public DataTable ShowCart(string ID, string state)
        {
            string sql = "select OrderDetail.OrderID, Product.ProductID, OrderDetail.UserID, Product.Photo, Product.ProductName, Product.Cost, OrderDetail.Amount, OrderDetail.Amount*Product.Cost as Total from Product inner join OrderDetail on Product.ProductID = OrderDetail.ProductID where OrderDetail.UserID ='" + ID + "'and OrderDetail.State='"+state+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowCartWithProductID(string UserID, string ProductID, string state)
        {
            string sql = "select Amount from OrderDetail where UserID='"+UserID+"' and ProductID='"+ProductID+"' and State='"+state+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable show()
        {
            string sql = "select Product.ProductID, OrderDetail.UserID, Product.Photo, Product.ProductName, Product.Cost, OrderDetail.Amount, OrderDetail.Amount*Product.Cost as Total from Product inner join OrderDetail on Product.ProductID = OrderDetail.ProductID";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InserOrder(string UserID, string ProductID, string Amount, string State)
        {
            string sql = "insert OrderDetail values(N'" + UserID + "',N'" + ProductID + "',N'" + Amount + "',N'" + State + "')";
            da.ExecuteNonQuery(sql);
        }
        public void UpdateOrder(string UserID, string ProductID, string Amount)
        {
            string sql = "update OrderDetail set Amount='" + Amount + "' where UserID='" + UserID + "' and ProductID='" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }

        public void UpdateStateofOrder(string OrderID, string UserID, string ProductID, string State)
        {
            string sql = "update OrderDetail set State='" + State + "' where UserID='" + UserID + "' and ProductID='" + ProductID + "' and OrderID='"+OrderID+"'";
            da.ExecuteNonQuery(sql);
        }

        public void DeleteOrder(string UserID, string ProductID)
        {
            string sql = "delete from OrderDetail where UserID='" + UserID + "' and ProductID='" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
