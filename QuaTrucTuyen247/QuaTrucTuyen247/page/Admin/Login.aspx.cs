using BUS;
using System;
using System.Data;
namespace QuaTrucTuyen247.page.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        Login_BUS bus = new Login_BUS();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            DataTable dt = new DataTable();
            dt = bus.CheckLoginAdmin();
            if (dt.Rows.Count > 0)
            {
                int dem = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (username == dr["UserName"].ToString().Trim() && password == dr["Password"].ToString().Trim())
                    {
                        dem++;
                        break;
                    }
                }
                if (dem != 0)
                {
                    Session["admin"] = username;
                    Response.Redirect("~/Page/Admin/index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không chính xác!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Hệ thống kiểm tra không thấy tài khoản dành cho quản lý!')</script>");
            }

        }
    }
}