using BUS;
using System;
using System.Web.UI.WebControls;
namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class Product : System.Web.UI.Page
    {
        Product_BUS bus = new Product_BUS();
        DetailsProduct_BUS L = new DetailsProduct_BUS();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = bus.ShowProduct();
                GridView1.DataBind();
            }
            //string alert = Request.QueryString["alert"].ToString();
            //if (alert != null)
            //{
            //    Response.Write("<script>alert('" + alert + "')</script>");
            //}
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Page/Admin/Product/InsertProduct.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            Button btnXoa = sender as Button;
            GridViewRow grvr = btnXoa.NamingContainer as GridViewRow;
            string productId = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            bus.DeleteProduct(productId);
            L.DeleteDetailProduct(productId);
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

        protected void btnChiTiet_Click(object sender , EventArgs e)
        {
            Button btnChitiet = sender as Button;
            GridViewRow grvr = btnChitiet.NamingContainer as GridViewRow;
            string id = GridView1.DataKeys[grvr.RowIndex].Value.ToString();
            Response.Redirect("~/Page/Admin/Product/DetailManger.aspx?id=" + id);
        }

        protected void btTK_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = bus.SearchProduct(txtTK.Text);
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = bus.ShowProduct();
            GridView1.DataBind();
        }
    }
}