<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="QuaTrucTuyen247.page.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="Home.aspx" style="font-size:16px">Trang Chủ</a>
    <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <div align="center">
                    <b style="font-size:30px;align-content:center; margin-left:150px"><asp:Label ID="Label1" runat="server" Text='<%# Eval("CategoryName") %>' ></asp:Label></b>
                </div>
                
                <br />
                <div align="center">
               <p style="font-size:18px; width:1000px; margin-left:200px; margin-bottom:50px"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("Desciption") %>' ></asp:Label></p>
                </div>

            </ItemTemplate>
        </asp:DataList>
    <div align="center">
        
                <asp:DataList ID="DataList1" DataKeyField="ProductID" align="center" runat="server" RepeatColumns="3" Width="1200px">
            <ItemTemplate>
                
                <asp:Label ID="txtProductID" Visible="false" runat="server" Text='<%# Eval("ProductID") %>' ></asp:Label>
                <table class="myBox" align="center">
                    <tr>
                        <td style="width: 97px; align-items:center">
                            <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="280" ImageUrl='<%# Eval("Photo") %>' ImageWidth="240" NavigateUrl='<%# "DetailProducts.aspx?ProductID=" + Eval("ProductID").ToString() %>'>
                            </asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="font-size: 16px; font-weight: 500; margin-top: 15px; margin-bottom: 15px">
                                <asp:Literal ID="Literal1" Text='<%# Eval("ProductName") %>' runat="server"></asp:Literal></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="font-size: 16px; color: red; margin-left: 80px">
                                <asp:Literal ID="Literal2" Text='<%# Eval("Cost") %>' runat="server"></asp:Literal>
                                đ</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style="margin-top: 15px; margin-bottom: 15px; color: red">
                                </p>
                        </td>
                    </tr>
                </table>
                <asp:Button ID="ButCart" runat="server" CommandName="addCart" Text="Chọn Quà này" Width="240px" Height="40px" />
                <p style="margin-bottom:30px"></p>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
