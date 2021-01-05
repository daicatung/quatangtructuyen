<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="QuaTrucTuyen247.page.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Width="100px" Height="100px" BorderStyle="Dashed" Text="Label"></asp:Label>
    <h1 style="font-size: 25px; line-height: 25px; font-weight: bold;">CÁC MÓN QUÀ BẠN ĐÃ CHỌN</h1>
    <asp:GridView ID="GridView1" DataKeyNames="ProductID" AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="632px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ProductID" Visible="false" HeaderText="ProductID" ReadOnly="True" />
            <asp:BoundField DataField="UserID" Visible="false" HeaderText="UserID" ReadOnly="True" />
            <asp:ImageField DataImageUrlField="Photo" ControlStyle-Width="80">
            </asp:ImageField>
            <asp:BoundField DataField="ProductName" HeaderText="Tên món quà" ReadOnly="True" />
            <asp:BoundField DataField="Cost" HeaderText="Giá" ReadOnly="True" SortExpression="Cost" />
            <asp:BoundField DataField="Amount" HeaderText="Số Lượng" ReadOnly="True" SortExpression="Amount" />
            <asp:BoundField DataField="Total" HeaderText="Tổng cộng" ReadOnly="True" SortExpression="Total" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnX" runat="server" Text="X" OnClick="btnDatHang" BackColor="#FFFFFF" BorderStyle="None" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFFFFF" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFFFF" ForeColor="#333333" />
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Đặt quà" />
</asp:Content>
