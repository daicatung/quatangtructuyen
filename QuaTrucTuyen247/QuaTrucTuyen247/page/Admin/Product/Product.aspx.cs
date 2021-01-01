using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class Product : System.Web.UI.Page
    {
        Product_BUS bus = new Product_BUS();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = bus.ShowProduct();
            GridView1.DataBind();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            
            Button btnXoa = sender as Button;
            GridViewRow grvr = btnXoa.NamingContainer as GridViewRow;
            int proid = int.Parse(GridView1.DataKeys[grvr.RowIndex].Value.ToString());
            //bus.DeleteProduct(proid);
            string alert = "Xóa thành công";
            Response.Redirect("~/Page/Admin/Product/Product.aspx?alert=" + alert);
            
        }
        
        protected void btnSua_Click(object sender, EventArgs e)
        {
        
            Button btnUpdate = sender as Button;
            GridViewRow grvr = btnUpdate.NamingContainer as GridViewRow;
            string id = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            Response.Redirect("~/Page/Admin/Product/UpdateProduct.aspx?id=" + id);
            
        }
         
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = bus.ShowProduct();
            GridView1.DataBind();
        }

        protected void btnSua_Click1(object sender, EventArgs e)
        {
            Button btnUpdate = sender as Button;
            GridViewRow grvr = btnUpdate.NamingContainer as GridViewRow;
            string id = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            Response.Redirect("~/Page/Admin/Product/UpdateProduct.aspx?id=" + id);
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            Button btnXoa = sender as Button;
            GridViewRow grvr = btnXoa.NamingContainer as GridViewRow;
            int proid = int.Parse(GridView1.DataKeys[grvr.RowIndex].Value.ToString());
            //bus.DeleteProduct(proid);
            string alert = "Xóa thành công";
            Response.Redirect("~/Page/Admin/Product/Product.aspx?alert=" + alert);
        }
    }
}