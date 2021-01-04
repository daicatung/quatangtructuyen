using System;
using BUS;
using DTO;

namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        Product_BUS L = new Product_BUS();
        DetailsProduct_BUS Ld = new DetailsProduct_BUS();
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

        protected void btnThem1_Click(object sender, EventArgs e)
        {
            L.InsertProduct(DropDownList1.SelectedValue.ToString(), txtTenSP.Text, FileUpload1.FileName, txtQuantity.Text, txtGia.Text);
            Ld.InsertDetailProduct(txtTitle.Text, txtDescription.Text, txtPhoto.FileName, txtTit1.Text, txtDes1.Text, txtPhoto1.FileName, txtTit2.Text, txtDes2.Text, txtPhoto2.FileName, txtTit3.Text, txtDes3.Text, txtPhoto3.FileName, txtTit4.Text, txtDes4.Text, txtPhoto4.FileName, txtTit5.Text, txtDes5.Text, txtPhoto5.FileName);
            string alert = "Thêm thành công";
            Response.Redirect("~/Page/Admin/Product/Product.aspx?alert=" + alert);
        }

        protected void btbHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Page/Admin/Product/Product.aspx?");
        }
    }
}