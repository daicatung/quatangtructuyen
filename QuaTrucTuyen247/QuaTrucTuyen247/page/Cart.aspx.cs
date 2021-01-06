using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace QuaTrucTuyen247.page
{
    public partial class Cart : System.Web.UI.Page
    {
        OrderDetail_BUS L = new OrderDetail_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = L.ShowCart(Login.UserID, "0");
                GridView1.DataBind();
            }
        }

        protected void btnSua(object sender, EventArgs e)
        {
            Button btnSua = sender as Button;
            GridViewRow grvr = btnSua.NamingContainer as GridViewRow;
            string productId = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            TextBox SL = grvr.FindControl("txtAmount") as TextBox;
            if (SL.Text == "0" || SL.Text == "")
            {
                L.DeleteOrder(Login.UserID, productId);
            }
            L.UpdateOrder(Login.UserID, productId, SL.Text);
            Response.Redirect("~/page/Cart.aspx?");
        }

        protected void btnXoa(object sender, EventArgs e)
        {
            Button btnXoa = sender as Button;
            GridViewRow grvr = btnXoa.NamingContainer as GridViewRow;
            string productId = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            L.DeleteOrder(Login.UserID, productId);
            Response.Redirect("~/page/Cart.aspx");
        }

        protected void btnDatHang(object sender, EventArgs e)
        {
            foreach(GridViewRow grvr in GridView1.Rows)
            {
                string productId = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
                TextBox OrderID = grvr.FindControl("txtOrderID") as TextBox;
                L.UpdateStateofOrder(OrderID.Text, Login.UserID, productId, "1");
            }
            Response.Redirect("~/page/Cart.aspx?");
        }

        protected void Trove_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/page/Home.aspx");
        }
    }
}