using System;

namespace QuaTrucTuyen247.page.Admin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "")
            {
                Response.Redirect("~/Page/Admin/Login.aspx");
            }
        }
    }
}