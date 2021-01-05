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
            if(!IsPostBack)
            {
                Label1.Text = Login.UserID;
                GridView1.DataSource = L.ShowCart(Login.UserID, "0");
                GridView1.DataBind();
            }
        }

        protected void btnDatHang(object sender, EventArgs e)
        {
            Button btnXoa = sender as Button;
            GridViewRow grvr = btnXoa.NamingContainer as GridViewRow;
            string productId = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            L.DeleteOrder(Login.UserID, productId);
            Response.Redirect("~/page/cart.aspx");
        }
    }
}