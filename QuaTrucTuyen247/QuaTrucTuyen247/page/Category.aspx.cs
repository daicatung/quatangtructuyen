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
    public partial class Category : System.Web.UI.Page
    {
        Product_BUS bus = new Product_BUS();
        OrderDetail_BUS L = new OrderDetail_BUS();
        public int categoryid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryid = Convert.ToInt32(Request.QueryString["CategoryID"]);
            //categoryid = 1;
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt = bus.ShowProductCategory(categoryid);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                DataTable dt1 = new DataTable();
                dt1 = bus.ShowCategoryy(categoryid);
                DataList2.DataSource = dt1;
                DataList2.DataBind();
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
                    DataTable dt = L.ShowCartWithProductID(a, lbl.Text, "0");
                    foreach (DataRow dr in dt.Rows)
                    {
                        int SL = Int32.Parse(dr["Amount"].ToString().Trim()) + 1;
                        L.UpdateOrder(a, lbl.Text, SL.ToString());
                        isexited = true;
                        break;
                    }
                    if (!isexited)
                    {
                        L.InserOrder(a, lbl.Text, "1", "0");
                    }

                    Response.Redirect("~/page/home.aspx");
                }

            }
        }
    }
}