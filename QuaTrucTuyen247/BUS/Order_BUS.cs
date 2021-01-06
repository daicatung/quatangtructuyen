using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Net;
using System.Net.Http;
namespace BUS
{
   public class Order_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        public DataTable ShowOrders()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT OrderID,Users.UserName,OrderDate,ReceiverPhone FROM Orders INNER JOIN Users ON Orders.UserID= Users.UserID WHERE Status=1 ORDER BY OrderID DESC";
            dt = dal.GetTable(sql);
            return dt;
        }
        public void DeleteOrder(int orderid)
        {
            string sql = "DELETE FROM Orders WHERE OrderID=" + orderid;
            dal.ExecuteNonQuery(sql);
        }
        public void DeleteOrderDetail(int orderid)
        {
            string sql = "DELETE FROM OrderDetail WHERE ProductID=" + orderid;
            dal.ExecuteNonQuery(sql);
        }
        public DataTable ShowPendingOrders()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT OrderID,Users.UserName,OrderDate,ReceiverPhone FROM Orders INNER JOIN Users ON Orders.UserID= Users.UserID WHERE Status=2";
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable GetOrderDetail(int orderid)
        {
            string sql = "SELECT OrderID,OrderDate,ReceiverName,ReceiverPhone,ReceiverAddress,ReceiverEmail,TotalMoney,Users.UserName,PaymentName FROM Orders INNER JOIN Users ON Orders.UserID= Users.UserID INNER JOIN Payment ON Orders.PaymentID=Payment.PaymentID WHERE Orders.OrderID=" + orderid;
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable GetProductInOrder(int orderid)
        {
            string sql = "SELECT Orders.OrderID,OrderDate,ProductName,Cost,Amount,sum(Cost*Amount) as 'TongTien' FROM Orders INNER JOIN OrderDetail ON Orders.UserID= OrderDetail.UserID INNER JOIN Product ON OrderDetail.ProductID=Product.ProductID WHERE Orders.OrderID =" + orderid + " GROUP BY Orders.OrderID,OrderDate,ProductName,Cost,Amount";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable showorderid(int orderid)
        {
            string sql = "SELECT * FROM Orders where OrderID = '" + orderid + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void UpdateStatusOrder(int orderid, int status)
        {
            string sql = "UPDATE Orders SET Status='" + status + "' WHERE OrderID=" + orderid;
            dal.ExecuteNonQuery(sql);
        }
        public DataTable ShowPendedOrders()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT OrderID,Users.UserName,OrderDate,ReceiverPhone FROM Orders INNER JOIN Users ON Orders.UserID= Users.UserID WHERE Status=3";
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SerchDateOrder(int status, string orderdate)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT OrderID, Users.UserName,OrderDate,ReceiverPhone FROM Orders INNER JOIN Users ON Orders.UserID = Users.UserID WHERE OrderDate='" + orderdate + "' AND Status=" + status;
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
