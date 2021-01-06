<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuaTrucTuyen247.page.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="Images/anhheader.PNG" />
    <div align="center">
        <p style="background-color: deeppink; color: white; width: 1200px; height: 50px; line-height: 50px; font-size: 20px; margin-top: 30px; margin-bottom: 30px">Quà tặng giáng sinh 2020</p>
        <asp:DataList ID="DataList1" DataKeyField="ProductID" align="center" runat="server" RepeatColumns="4" Width="1200px" OnItemCommand="DataList_ItemCommand">
            <ItemTemplate>
                <asp:Label ID="txtProductID" Visible="false" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                <table class="myBox">
                    <tr>
                        <td style="width: 97px">
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

        <p style="background-color: deeppink; color: white; width: 1200px; height: 50px; line-height: 50px; font-size: 20px; margin-top: 30px; margin-bottom: 30px">Quà tặng LuvGift</p>
        <asp:DataList ID="DataList2" OnItemCommand="DataList_ItemCommand" DataKeyField="ProductID" align="center" runat="server" RepeatColumns="4" Width="1200px">
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
                                <asp:Button ID="ButCart" runat="server" CommandName="addCart" Text="Chọn Quà này" Width="240px" Height="40px" /></p>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <p style="background-color: deeppink; color: white; width: 1200px; height: 50px; line-height: 50px; font-size: 20px; margin-top: 30px; margin-bottom: 30px">Quà tặng giáng sinh cho bé</p>
        <asp:DataList ID="DataList3" OnItemCommand="DataList_ItemCommand" DataKeyField="ProductID" align="center" runat="server" RepeatColumns="4" Width="1200px">
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
                                <asp:Button ID="ButCart" CommandName="addCart" runat="server" Text="Chọn Quà này" Width="240px" Height="40px" /></p>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
