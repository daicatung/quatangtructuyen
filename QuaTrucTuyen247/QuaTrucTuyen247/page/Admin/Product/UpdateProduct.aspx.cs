using System;
using BUS;
using DTO;

namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        Product_BUS L = new Product_BUS();

        protected void Page_Load(object sender, EventArgs e)
        {
            Showcb();
        }

        void Showcb()
        {
            DropDownList1.DataSource = L.ShowCategory();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryID";
            DataBind();
        }

        protected void btXacNhan_Click(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"].ToString();
            L.UpdateProduct(ID, DropDownList1.SelectedValue.ToString(), txtTen.Text, FileUpload1.ToString(), txtQuantity.Text, txtGia.Text);
            string alert = "Sửa thành công";
            Response.Redirect("~/Page/Admin/Product/Product.aspx?alert="+alert);
        }
    }
}