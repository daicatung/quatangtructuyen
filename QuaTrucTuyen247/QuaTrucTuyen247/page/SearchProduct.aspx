<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="SearchProduct.aspx.cs" Inherits="QuaTrucTuyen247.page.SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: auto; width:1210px;">
        <h1 align="center">Món quà tặng thích hợp với: '
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>'
        </h1>
        <asp:DataList ID="DataList1" align="center" runat="server" RepeatColumns="4" Width="1200px" OnItemCommand="DataList_ItemCommand">
            <ItemTemplate>
                <asp:Label ID="txtProductID" Visible="false" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                <table class="myBox">
                    <tr>
                        <td style="width: 97px">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "DetailProducts.aspx?ProductID=" + Eval("ProductID").ToString() %>' ImageUrl='<%# Eval("Photo") %>'
                                ImageWidth="240" ImageHeight="280">
                            </asp:HyperLink>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="font-size: 16px; font-weight: 500; margin-top: 15px; margin-bottom: 15px">
                                <asp:Literal ID="Literal1" Text='<%# Eval("ProductName") %>' runat="server"></asp:Literal>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="font-size: 16px; color: red; margin-left: 80px">
                                <asp:Literal ID="Literal2" Text='<%# Eval("Cost") %>' runat="server"></asp:Literal>
                                đ
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="margin-top: 15px; margin-bottom: 15px; color: red">
                                <asp:Button ID="ButCart" runat="server" CommandName="addCart" Text="Chọn Quà này" Width="240px" Height="40px" />
                            </p>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
