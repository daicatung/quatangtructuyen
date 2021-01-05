using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace QuaTrucTuyen247.page
{
    public partial class SearchProduct : System.Web.UI.Page
    {
        Product_BUS L = new Product_BUS();
        OrderDetail_BUS Lo = new OrderDetail_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string name = Request.QueryString["txtTK"].ToString();
                Label1.Text = name;
                DataList1.DataSource = L.SearchProduct(name);
                DataList1.DataBind();
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            string a = Login.UserID;
            string ID = Request.QueryString["ProductID"].ToString();
            if (a == "0")
            {
                Response.Write("<script>alert('Bạn cần đăng nhập để mua hàng!')</script>");
                Response.Redirect("~/page/Login.aspx");
            }
            else
            {
                Lo.InserOrder(a, ID, "1", "0");
                Response.Write("<script>alert('Thêm sản phẩm vào giỏ hàng thành công!')</script>");
            }
        }
    }
}