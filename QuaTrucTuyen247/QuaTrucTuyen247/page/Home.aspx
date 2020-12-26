<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuaTrucTuyen247.page.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <img src="Images/anhheader.PNG" />
    <div align="center">
        <p style="background-color:deeppink; color:white; width:1200px; height:50px; line-height:50px; font-size:20px; margin-top:30px; margin-bottom:30px">Quà tặng giáng sinh 2020</p>
    <asp:DataList ID="DataList1" align="center" runat="server" RepeatColumns="4" Width="1200px">
        <ItemTemplate >
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
                        <p style="font-size:16px; font-weight:500; margin-top:15px; margin-bottom:15px"><asp:Literal ID="Literal1" text='<%# Eval("ProductName") %>' runat="server"></asp:Literal></p>
                    </td>
                </tr>
                <tr>
                    <td>
                       <p style="font-size:16px; color:red; margin-left:80px"> <asp:Literal ID="Literal2" text='<%# Eval("Cost") %>' runat="server"></asp:Literal> đ</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p style="margin-top:15px; margin-bottom:15px;color:red"><asp:Button ID="ButCart" runat="server" Text="Chọn Quà này" Width="240px" Height="40px" /></p>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>

        <p style="background-color:deeppink; color:white; width:1200px; height:50px; line-height:50px; font-size:20px; margin-top:30px; margin-bottom:30px">Quà tặng LuvGift</p>
    <asp:DataList ID="DataList2" align="center" runat="server" RepeatColumns="4" Width="1200px">
          <ItemTemplate >
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
                        <p style="font-size:16px; font-weight:500; margin-top:15px; margin-bottom:15px"><asp:Literal ID="Literal1" text='<%# Eval("ProductName") %>' runat="server"></asp:Literal></p>
                    </td>
                </tr>
                <tr>
                    <td>
                       <p style="font-size:16px; color:red; margin-left:80px"> <asp:Literal ID="Literal2" text='<%# Eval("Cost") %>' runat="server"></asp:Literal> đ</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p style="margin-top:15px; margin-bottom:15px;color:red"><asp:Button ID="ButCart" runat="server" Text="Chọn Quà này" Width="240px" Height="40px" /></p>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
        <p style="background-color:deeppink; color:white; width:1200px; height:50px; line-height:50px; font-size:20px; margin-top:30px; margin-bottom:30px">Quà tặng giáng sinh cho bé</p>
        <asp:DataList ID="DataList3" align="center" runat="server" RepeatColumns="4" Width="1200px">
          <ItemTemplate >
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
                        <p style="font-size:16px; font-weight:500; margin-top:15px; margin-bottom:15px"><asp:Literal ID="Literal1" text='<%# Eval("ProductName") %>' runat="server"></asp:Literal></p>
                    </td>
                </tr>
                <tr>
                    <td>
                       <p style="font-size:16px; color:red; margin-left:80px"> <asp:Literal ID="Literal2" text='<%# Eval("Cost") %>' runat="server"></asp:Literal> đ</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p style="margin-top:15px; margin-bottom:15px;color:red"><asp:Button ID="ButCart" runat="server" Text="Chọn Quà này" Width="240px" Height="40px" /></p>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
        </div>
</asp:Content>
