<%@ Page Title="" Language="C#" MasterPageFile="~/page/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="QuaTrucTuyen247.page.Admin.Product.UpdateProduct" %>

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
                <td colspan="2" align="center">
                    <asp:Button ID="btXacNhan" runat="server" OnClick="btXacNhan_Click" Text="Xác nhận" />
                    <asp:Button ID="btHuy" runat="server" OnClick="btnHuy_Click" Text="Hủy bỏ" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
