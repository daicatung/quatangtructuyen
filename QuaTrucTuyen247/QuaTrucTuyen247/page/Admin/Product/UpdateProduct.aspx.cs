using System;
using BUS;
using DTO;
using System.Data;

namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        Product_BUS L = new Product_BUS();
        DetailsProduct_BUS Ld = new DetailsProduct_BUS();

        protected void Page_Load(object sender, EventArgs e)
        {
            Showcb();
            if (!IsPostBack)
            {
                ShowData();
            }
        }

        void Showcb()
        {
            DropDownList1.DataSource = L.ShowCategory();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryID";
            DataBind();
        }

        void ShowData()
        {
            string ID = Request.QueryString["id"].ToString();
            DataTable dt = new DataTable();
            dt = Ld.ShowProductWithID(ID);

            foreach (DataRow dr in dt.Rows)
            {
                DropDownList1.Text = dr["CategoryID"].ToString().Trim();
                txtTen.Text = dr["ProductName"].ToString().Trim();
                txtQuantity.Text = dr["Quantity"].ToString().Trim();
                txtGia.Text = dr["Cost"].ToString().Trim();
            }
        }

        protected void btXacNhan_Click(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"].ToString();
            L.UpdateProduct(ID, DropDownList1.SelectedValue.ToString(), txtTen.Text, FileUpload1.FileName, txtQuantity.Text, txtGia.Text);
            string alert = "Sửa thành công";
            Response.Redirect("~/Page/Admin/Product/Product.aspx?alert="+alert);
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Page/Admin/Product/Product.aspx?");
        }
    }
}