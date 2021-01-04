<%@ Page Title="" Language="C#" MasterPageFile="~/page/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="QuaTrucTuyen247.page.Admin.Product.InsertProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: auto;">
        <div>
            <h1 align="center">THÊM SẢN PHẨM</h1>
        </div>
        <div>
            <table>
                <tr>
                    <td>loại sản phẩm:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Tên sản phẩm:</td>
                    <td>
                        <asp:TextBox ID="txtTenSP" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ảnh:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                </tr>
                <tr>
                    <td>Quantity:</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giá:</td>
                    <td>
                        <asp:TextBox ID="txtGia" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div>
            <h2 align="center">Chi tiết sản phẩm</h2>
            <table>
                <tr>
                    <td>Giới thiệu sản phẩm:</td>
                    <td>
                        <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tiêu đề:</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 1:</td>
                    <td>
                        <asp:TextBox ID="txtTit1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 1:</td>
                    <td>
                        <asp:TextBox ID="txtDes1" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 1:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto1" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 2:</td>
                    <td>
                        <asp:TextBox ID="txtTit2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 2:</td>
                    <td>
                        <asp:TextBox ID="txtDes2" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 2:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto2" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 3:</td>
                    <td>
                        <asp:TextBox ID="txtTit3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 3:</td>
                    <td>
                        <asp:TextBox ID="txtDes3" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 3:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto3" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 4:</td>
                    <td>
                        <asp:TextBox ID="txtTit4" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 4:</td>
                    <td>
                        <asp:TextBox ID="txtDes4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 4:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto4" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 5:</td>
                    <td>
                        <asp:TextBox ID="txtTit5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 5:</td>
                    <td>
                        <asp:TextBox ID="txtDes5" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ảnh 5:</td>
                    <td>
                        <asp:FileUpload ID="txtPhoto5" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btthem" runat="server" OnClick="btnThem1_Click" Text="Thêm" />
        <asp:Button ID="bthuy" runat="server" OnClick="btbHuy_Click" Text="Hủy" />
    </div>
</asp:Content>
