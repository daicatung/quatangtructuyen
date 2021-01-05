using BUS;
using DTO;
using System;

namespace QuaTrucTuyen247.page
{
    public partial class DetailProducts : System.Web.UI.Page
    {
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        DetailsProduct_BUS L = new DetailsProduct_BUS();
        OrderDetail_BUS Lo = new OrderDetail_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string ID = Request.QueryString["ProductID"].ToString();
                DataList1.DataSource = L.ShowProductWithID(ID);
                DataList1.DataBind();
                DataList2.DataSource = L.ShowDetailsProduct(ID);
                DataList2.DataBind();
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
                Lo.InserOrder(a, ID, "1","0");
                Response.Write("<script>alert('Thêm sản phẩm vào giỏ hàng thành công!')</script>");
            }
        }
    }
}