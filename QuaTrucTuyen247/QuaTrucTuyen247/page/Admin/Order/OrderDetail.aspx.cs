using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using System.Data;

namespace QuaTrucTuyen247.page.Admin.Order
{
    public partial class OrderDetail : System.Web.UI.Page
    {
        Order_BUS bus = new Order_BUS();
        int orderid;
        protected void Page_Load(object sender, EventArgs e)
        {
            orderid = int.Parse(Request.QueryString["orderid"]);

            DataTable dt = new DataTable();
            dt = bus.showorderid(orderid);
            DataList1.DataSource = dt;
            DataList1.DataBind();
           // ShowOrderDetail();
            //ShowProductInOrderDetail();
        }

        public void ShowOrderDetail()
        {
            DataTable dt = new DataTable();
            dt = bus.GetOrderDetail(orderid);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        public void ShowProductInOrderDetail()
        {
            DataTable dt = new DataTable();
            dt = bus.GetProductInOrder(orderid);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnUpdateStateOrder_Click(object sender, EventArgs e)
        {
            int status = int.Parse(DropDownList1.SelectedValue);
            bus.UpdateStatusOrder(orderid, status);
            Response.Redirect("~/Page/Admin/Order/Order.aspx");
        }
    }
}