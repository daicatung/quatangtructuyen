﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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