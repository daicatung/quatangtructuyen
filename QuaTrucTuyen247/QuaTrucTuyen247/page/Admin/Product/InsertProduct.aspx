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
                        <asp:TextBox ID="TextBox4" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tiêu đề:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 1:</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 1:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 1:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload3" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 2:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 2:</td>
                    <td>
                        <asp:TextBox ID="TextBox9" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 2:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload4" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 3:</td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 3:</td>
                    <td>
                        <asp:TextBox ID="TextBox11" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 3:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload5" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 4:</td>
                    <td>
                        <asp:TextBox ID="TextBox12" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 4:</td>
                    <td>
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ảnh 4:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload6" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tiêu đề 5:</td>
                    <td>
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả 5:</td>
                    <td>
                        <asp:TextBox ID="TextBox15" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ảnh 5:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload7" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btthem" runat="server" OnClick="btnThem1_Click" Text="Thêm" />
        <asp:Button ID="bthuy" runat="server" Text="Hủy" />
    </div>
</asp:Content>
