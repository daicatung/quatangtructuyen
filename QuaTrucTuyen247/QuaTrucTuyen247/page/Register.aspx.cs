using BUS;
using System;
using System.Data;
namespace QuaTrucTuyen247.page
{
    public partial class Register : System.Web.UI.Page
    {
        DataTable dtUsers = new DataTable();
        Register__BUS bus = new Register__BUS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            int dem = 0;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
            {
                Response.Write("<script>alert('Bạn chưa nhập đủ thông tin, nhập lại!')</script>");
            }
            else
            {


                foreach (DataRow dr in dtUsers.Rows)
                {
                    if (dr["UserName"].ToString().Trim() == username.Trim())
                    {
                        dem++;
                        break;
                    }
                }
                if (dem == 0)
                {
                    if (password != confirm)
                    {
                        Response.Write("<script>alert('Mật khẩu không khớp, nhập lại!')</script>");
                        txtPassword.Focus();
                    }
                    else
                    {
                        bus.RegisterUser(username, password, email, phone, address);
                        Response.Write("<script>alert('Đăng ký thành công!')</script>");
                        Response.Redirect(@"~\Page\Login.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Tên người dùng đã tồn tại, nhập lại!')</script>");
                    txtUsername.Focus();
                }
            }
        }
    }
}