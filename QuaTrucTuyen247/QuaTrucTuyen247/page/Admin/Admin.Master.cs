using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuaTrucTuyen247.page.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbNameAdmin.Text = "Admin : "+Session["admin"].ToString();
        }
        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session["admin"] = "";
            Response.Redirect("~/Page/Admin/Login.aspx");
        }
    }
}