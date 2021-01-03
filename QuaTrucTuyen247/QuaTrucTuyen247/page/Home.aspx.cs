using BUS;
using System;
using System.Data;
namespace QuaTrucTuyen247.page
{

    public partial class Home : System.Web.UI.Page
    {
        Product_BUS bus = new Product_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 1;
            DataTable dt = new DataTable();
            dt = bus.Show8AProduct(id);
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            dt2 = bus.Show8AProduct(2);
            dt3 = bus.Show8AProduct(3);
            DataList1.DataSource = dt;
            DataList1.DataBind();
            DataList2.DataSource = dt2;
            DataList2.DataBind();

            DataList3.DataSource = dt3;
            DataList3.DataBind();
        }
    }
}