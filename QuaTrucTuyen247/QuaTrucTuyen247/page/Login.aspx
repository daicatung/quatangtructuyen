<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuaTrucTuyen247.page.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đăng nhập</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="align-content: center; margin-top: 50px; margin-bottom: 40px; color: cadetblue; font-size: 23px" align="center">ĐĂNG NHẬP</h1>
    <table style="width: 1300px; height: 700px; border: 4px; align-items: center" border="1" align="center">
        <tr>
            <td style="width: 500px" align="center">
                <b>
                    <p style="align-items: normal; font-size: 18px; color: gray; margin: auto; margin-bottom: 20px">ĐĂNG NHẬP TÀI KHOẢN CỦA BẠN</p>
                </b>
                <p style="align-items: normal; font-size: 16px; color: gray; margin: auto; margin-bottom: 30px">
                    Đăng nhập tài khoản của bạn để khám phá tất
                    <br />
                    cả các tính năng tuyệt vời trong cửa hàng của<br />
                    chúng tôi.
                </p>

                <p style="align-items: normal; font-size: 16px; color: gray; margin: auto; margin-bottom: 30px">
                    <label for="txtUsername"><b>Địa Chỉ Email</b></label>
                    &nbsp;
                        <asp:TextBox ID="txtUsername" runat="server" TabIndex="1"></asp:TextBox>
                </p>
                <p style="align-items: normal; font-size: 16px; color: gray; margin: auto; margin-bottom: 30px">
                    <label for="txtPassword"><b>Mật khẩu</b></label>
                    &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" TabIndex="2"></asp:TextBox>
                    &nbsp;
                </p>
                <asp:Button Style="width: 150px; height: 50px; background-color: deeppink; color: white" ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
                <p style="margin-bottom: 300px; font-size: 15px; margin-top: 20px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page/Register.aspx">Chưa có tài khoản ?</asp:HyperLink>
                </p>
            </td>
        </tr>

    </table>
</asp:Content>
