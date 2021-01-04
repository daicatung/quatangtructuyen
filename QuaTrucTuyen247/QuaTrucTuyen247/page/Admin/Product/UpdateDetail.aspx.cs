using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
using System.Data;

namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class UpdateDetail : System.Web.UI.Page
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

            foreach (DataRow i in dt.Rows)
            {
                DropDownList1.Text = i["CategoryID"].ToString().Trim();
                txtTen.Text = i["ProductName"].ToString().Trim();
                txtQuantity.Text = i["Quantity"].ToString().Trim();
                txtGia.Text = i["Cost"].ToString().Trim();
            }

            dt = Ld.ShowDetailsProduct(ID);
            foreach (DataRow i in dt.Rows)
            {
                txtTitle.Text = i["Title"].ToString().Trim();
                txtDescription.Text = i["Desciption"].ToString().Trim();
                txtTit1.Text = i["Tit1"].ToString().Trim();
                txtDes1.Text = i["Des1"].ToString().Trim();
                txtTit2.Text = i["Tit2"].ToString().Trim();
                txtDes2.Text = i["Des2"].ToString().Trim();
                txtTit3.Text = i["Tit3"].ToString().Trim();
                txtDes3.Text = i["Des3"].ToString().Trim();
                txtTit4.Text = i["Tit4"].ToString().Trim();
                txtDes4.Text = i["Des4"].ToString().Trim();
                txtTit5.Text = i["Tit5"].ToString().Trim();
                txtDes5.Text = i["Des5"].ToString().Trim();
            }
        }

        protected void btHuyBo_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            Response.Redirect("~/Page/Admin/Product/DetailManger.aspx?id=" + id);
        }

        protected void btXacNhan_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            L.UpdateProduct(ID, DropDownList1.SelectedValue.ToString(), txtTen.Text, FileUpload1.FileName, txtQuantity.Text, txtGia.Text);
            Ld.UpdateDetailProduct(id,txtTitle.Text, txtDescription.Text, txtPhoto.FileName, txtTit1.Text, txtDes1.Text, txtPhoto1.FileName, txtTit2.Text, txtDes2.Text, txtPhoto2.FileName, txtTit3.Text, txtDes3.Text, txtPhoto3.FileName, txtTit4.Text, txtDes4.Text, txtPhoto4.FileName, txtTit5.Text, txtDes5.Text, txtPhoto5.FileName);
            Response.Redirect("~/Page/Admin/Product/DetailManger.aspx?id=" + id);
        }
    }
}