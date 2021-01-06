using BUS;
using System;
using System.Data;
using System.Web.UI.WebControls;
namespace QuaTrucTuyen247.page
{
    public partial class Home : System.Web.UI.Page
    {
        Product_BUS bus = new Product_BUS();
        OrderDetail_BUS L = new OrderDetail_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = 1;
                DataTable dt = new DataTable();
                dt = bus.Show8AProduct(id);
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                dt2 = bus.Show8AProduct(2);
                dt3 = bus.Show8AProduct(3);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                DataList2.DataSource = dt2;
                DataList2.DataBind();
                DataList3.DataSource = dt3;
                DataList3.DataBind();
            }    
        }

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if ((e.CommandName == "addCart") && (e.CommandArgument != null))
            {
                string a = Login.UserID;
                if (a == "0")
                {
                    Response.Write("<script>alert('Bạn cần đăng nhập để mua hàng!')</script>");
                    Response.Redirect("~/page/Login.aspx");
                }
                else
                {
                    Label lbl = (Label)e.Item.FindControl("txtProductID");
                    L.InserOrder(a, lbl.Text, "1", "0");
                    Response.Write("<script>alert('Thêm sản phẩm vào giỏ hàng thành công!')</script>");
                }
            }
        }
    }
}