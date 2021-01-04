<%@ Page Title="" Language="C#" MasterPageFile="~/page/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateDetail.aspx.cs" Inherits="QuaTrucTuyen247.page.Admin.Product.UpdateDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: auto; width: 800px;">
        <table style="width: 100%;">
            <tr>
                <td colspan="2" align="center">SỬA SẢN PHẨM</td>
            </tr>
            <tr>
                <td style="width: 20%">loại sản phẩm:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="600px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Tên sản phẩm:</td>
                <td>
                    <asp:TextBox ID="txtTen" runat="server" Width="600px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ảnh:</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="600px" /></td>
            </tr>
            <tr>
                <td>Quantity:</td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server" Width="600px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Giá:</td>
                <td>
                    <asp:TextBox ID="txtGia" runat="server" Width="600px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center">SỬA CHI TIẾT SẢN PHẨM</td>
            </tr>
            <tr>
                <td>Tiêu đề sản phẩm</td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="600px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Giới thiệu</td>
                <td>
                    <asp:TextBox ID="txtDescription" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ảnh</td>
                <td>
                    <asp:FileUpload ID="txtPhoto" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td>Title1</td>
                <td>
                    <asp:TextBox ID="txtTit1" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description1</td>
                <td>
                    <asp:TextBox ID="txtDes1" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Photo1</td>
                <td>
                    <asp:FileUpload ID="txtPhoto1" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td>Title2</td>
                <td>
                    <asp:TextBox ID="txtTit2" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description2</td>
                <td>
                    <asp:TextBox ID="txtDes2" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Photo2</td>
                <td>
                    <asp:FileUpload ID="txtPhoto2" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td>Title3</td>
                <td>
                    <asp:TextBox ID="txtTit3" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description3</td>
                <td>
                    <asp:TextBox ID="txtDes3" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Photo3</td>
                <td>
                    <asp:FileUpload ID="txtPhoto3" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td>Title4</td>
                <td>
                    <asp:TextBox ID="txtTit4" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description4</td>
                <td>
                    <asp:TextBox ID="txtDes4" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Photo4</td>
                <td>
                    <asp:FileUpload ID="txtPhoto4" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td>Title5</td>
                <td>
                    <asp:TextBox ID="txtTit5" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description5</td>
                <td>
                    <asp:TextBox ID="txtDes5" TextMode="MultiLine" Width="600px" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Photo5</td>
                <td>
                    <asp:FileUpload ID="txtPhoto5" Width="600px" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btXacNhan" runat="server" OnClick="btXacNhan_Click" Text="Xác nhận" BackColor="#66FFFF" />
                    <asp:Button ID="btHuy" runat="server" OnClick="btHuyBo_Click" Text="Hủy bỏ" BackColor="Red" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
