using BUS;
using DTO;
using System;
using System.Data;

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
            bool isexited = false;
            if (a == "0")
            {
                Response.Write("<script>alert('Bạn cần đăng nhập để mua hàng!')</script>");
                Response.Redirect("~/page/Login.aspx");
            }
            else
            {
                DataTable dt = Lo.ShowCartWithProductID(a, ID, "0");
                foreach (DataRow dr in dt.Rows)
                {
                    int SL = Int32.Parse(dr["Amount"].ToString().Trim()) + 1;
                    Lo.UpdateOrder(a, ID, SL.ToString());
                    isexited = true;
                    break;
                }
                if (!isexited)
                {
                    Lo.InserOrder(a, ID, "1", "0");
                }

                Response.Redirect("~/page/home.aspx");
            }
        }
    }
}