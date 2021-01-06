<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="QuaTrucTuyen247.page.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="font-size: 25px; line-height: 25px; font-weight: bold;">CÁC MÓN QUÀ BẠN ĐÃ CHỌN</h1>
    <div style="width:634px; margin:auto;">
        <asp:GridView ID="GridView1" DataKeyNames="ProductID" AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="632px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="OrderID" Visible="false">
                <ItemTemplate>
                    <asp:TextBox ID="txtOrderID" Text='<%# Eval("OrderID") %>' Visible="false" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:BoundField DataField="OrderID" Visible="false" HeaderText="OrderID" ReadOnly="True" />--%>
            <asp:BoundField DataField="ProductID" Visible="false" HeaderText="ProductID" ReadOnly="True" />
            <asp:BoundField DataField="UserID" Visible="false" HeaderText="UserID" ReadOnly="True" />
            <asp:ImageField DataImageUrlField="Photo" ControlStyle-Width="80">
            </asp:ImageField>
            <asp:BoundField DataField="ProductName" HeaderText="Tên món quà" ReadOnly="True" />
            <asp:BoundField DataField="Cost" HeaderText="Giá" ReadOnly="True" SortExpression="Cost" />
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <asp:TextBox ID="txtAmount" Text='<%# Eval("Amount") %>' runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Total" HeaderText="Tổng cộng" ReadOnly="True" SortExpression="Total" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnX" runat="server" Text="X" OnClick="btnXoa" BackColor="#FFFFFF" BorderStyle="None" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFFFFF" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFFFF" ForeColor="#333333" />
    </asp:GridView>
    </div><br /><br /><br /><br />
    <div style="height:50px;margin:auto; width:26%;">
        <asp:Button ID="Trove" OnClick="Trove_Click" runat="server" Width="150px" Height="40" Font-Size="15px" BackColor="#ff9999" Text="Tiếp tục mua hàng" />
        <asp:Button Width="150px" Height="40px" Font-Size="15px" BackColor="#00ffff" ID="Button1" runat="server" OnClick="btnDatHang" Text="Đặt quà" />
    </div>
</asp:Content>
