using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace QuaTrucTuyen247.page.Admin.Product
{
    public partial class DetailManger : System.Web.UI.Page
    {
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        DetailsProduct_BUS L = new DetailsProduct_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"].ToString();
            DataList1.DataSource = L.ShowProductWithID(ID);
            DataList1.DataBind();
            DataList2.DataSource = L.ShowDetailsProduct(ID);
            DataList2.DataBind();
        }

        protected void Sua_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            Response.Redirect("~/Page/Admin/Product/UpdateDetail.aspx?id=" + id);
        }

        protected void TroVe_click(object sender, EventArgs e)
        {
            Response.Redirect("~/Page/Admin/Product/Product.aspx?");
        }
    }
}