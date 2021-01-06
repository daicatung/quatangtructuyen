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
    }
}