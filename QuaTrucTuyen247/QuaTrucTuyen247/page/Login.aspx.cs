using BUS;
using System;
using System.Data;
namespace QuaTrucTuyen247.page
{
    public partial class Login : System.Web.UI.Page
    {
        public static string username;
        Login_BUS bus = new Login_BUS();
        public static string UserID="0";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            DataTable dt = new DataTable();
            dt = bus.CheckLogin();
            if (dt.Rows.Count > 0)
            {
                int dem = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (username == dr["UserName"].ToString().Trim() && password == dr["Password"].ToString().Trim())
                    {
                        dem++;
                        UserID = dr["UserID"].ToString();
                        break;
                    }
                }
                if (dem != 0)
                {
                    Session["login"] = username;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không chính xác!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Hệ thống kiểm tra không thấy tài khoản dành cho người dùng, hãy đăng ký nếu chưa có!')</script>");
            }
        }
    }
}