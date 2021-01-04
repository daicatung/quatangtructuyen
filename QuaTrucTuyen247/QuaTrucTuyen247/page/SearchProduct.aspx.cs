using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace QuaTrucTuyen247.page
{
    public partial class SearchProduct : System.Web.UI.Page
    {
        Product_BUS L = new Product_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["txtTK"].ToString();
            Label1.Text = name;
            DataList1.DataSource = L.SearchProduct(name);
            DataList1.DataBind();
        }
    }
}