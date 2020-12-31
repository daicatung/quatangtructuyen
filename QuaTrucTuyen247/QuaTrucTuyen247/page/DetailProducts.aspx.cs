using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace QuaTrucTuyen247.page
{
    public partial class DetailProducts : System.Web.UI.Page
    {
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        DetailsProduct_BUS L = new DetailsProduct_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ProductID"].ToString());
            DataList1.DataSource = L.ShowProductWithID(ID);
            DataList1.DataBind();
            DataList2.DataSource = L.ShowDetailsProduct(ID);
            DataList2.DataBind();
        }
    }
}