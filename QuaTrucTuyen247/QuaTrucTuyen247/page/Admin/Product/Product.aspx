<%@ Page Title="" Language="C#" MasterPageFile="~/page/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="QuaTrucTuyen247.page.Admin.Product.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="4px" CellPadding="3" Width="1010px" AutoGenerateColumns="False" CellSpacing="2" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" CssClass="auto-style1">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" >
            <ControlStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField DataField="DetailProductID" HeaderText="DetailProductID" />
            <asp:ImageField DataImageUrlField="Photo" HeaderText="Photo"  ControlStyle-Width="80">
<ControlStyle Width="80px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Cost" HeaderText="Cost" />
            <asp:TemplateField>
                <ItemTemplate>
                   <asp:Button ID="btnSua1" runat="server" CssClass="btn btn-primary" Text="Sửa" OnClick="btnSua_Click1" Width="39px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                     <asp:Button ID="btnDelete1" runat="server" CssClass="btn btn-danger"  Text="Xóa" OnClick="btnDelete_Click1" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />

    </asp:GridView>
</asp:Content>
