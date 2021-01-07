using System;
using BUS;
using System.Data;
namespace QuaTrucTuyen247.page
{
    public partial class FontEnd : System.Web.UI.MasterPage
    {
        OrderDetail_BUS Lo = new OrderDetail_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {
                Label1.Text = ShowAmount().ToString();
        }

        int ShowAmount()
        {
            DataTable dt = Lo.ShowAmount(Login.UserID, "0");
            foreach (DataRow dr in dt.Rows)
            {
                int SL = Int32.Parse(dr["Tong"].ToString().Trim());
                return SL;
            }
            return 0;
        }
    }
}