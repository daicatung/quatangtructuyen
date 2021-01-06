using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
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

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if ((e.CommandName == "addCart") && (e.CommandArgument != null))
            {
                string a = Login.UserID;
                bool isexited = false;
                if (a == "0")
                {
                    Response.Write("<script>alert('Bạn cần đăng nhập để mua hàng!')</script>");
                    Response.Redirect("~/page/Login.aspx");
                }
                else
                {
                    Label lbl = (Label)e.Item.FindControl("txtProductID");
                    DataTable dt = Lo.ShowCartWithProductID(a, lbl.Text, "0");
                    foreach (DataRow dr in dt.Rows)
                    {
                        int SL = Int32.Parse(dr["Amount"].ToString().Trim()) + 1;
                        Lo.UpdateOrder(a, lbl.Text, SL.ToString());
                        isexited = true;
                        break;
                    }
                    if (!isexited)
                    {
                        Lo.InserOrder(a, lbl.Text, "1", "0");
                    }

                    Response.Write("<script>alert('Thêm sản phẩm vào giỏ hàng thành công!')</script>");
                }

            }
        }
    }
}