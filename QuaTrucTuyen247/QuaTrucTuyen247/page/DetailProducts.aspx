<%@ Page Title="" Language="C#" MasterPageFile="~/page/FontEnd.Master" AutoEventWireup="true" CodeBehind="DetailProducts.aspx.cs" Inherits="QuaTrucTuyen247.page.DetailProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/DetailProduct.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--Product--%>
    <asp:DataList ID="DataList1" Width="100%" runat="server">
        <ItemTemplate>
            <br /><br /><br />
            <div style="width:100%;">
                <div style="float:left; text-align:right; width:53%;">
                    <asp:Image ImageUrl='<%# Eval("Photo") %>' Width="400px" Height="400px" runat="server"/>
                </div>
                <div style="float:left; text-align:left; width:300px;">
                    <p style="font-size:30px; font-weight:bold; line-height:35px;">
                        <asp:Literal Text='<%# Eval("ProductName") %>' runat="server" />
                    </p>
                    <br />
                    <p style="font-size:25px; font-weight:bold; line-height:30px; color:red;">
                        <asp:Literal Text='<%# Eval("Cost") %>' runat="server" />
                    </p>
                    <hr />
                    <br /><br /><br />
                    <asp:Button ID="ButCart" runat="server" Text="Chọn Quà này" Width="250px" Height="40px" ForeColor="White" BackColor="Orange" BorderStyle="Solid" BorderColor="Orange" />
                </div>  
            </div>
        </ItemTemplate>
    </asp:DataList>
    <%--Product--%>

    <%--DetailsProduct--%>
    <asp:DataList ID="DataList2" Width="100%" runat="server">
        <ItemTemplate>
            <div style="font-size:20px; line-height:20px; margin:auto; width:50%;">
                <br /><br /><br />
                <div style="color:white; background-color:salmon; line-height:50px; font-weight:bold; text-align:center;">
                    Chi tiết món quà
                </div>
                <br /><br /><br />
                <div>
                    <asp:Literal Text='<%# Eval("Desciption") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold">
                    Đặc điểm nổi bật của 
                    <asp:Literal Text='<%# Eval("Title") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold;">
                    <asp:Literal Text='<%# Eval("Tit1") %>' runat="server"/><br /><br />
                </div>
                <div>
                    <asp:Literal Text='<%# Eval("Des1") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo1") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold;">
                    <asp:Literal Text='<%# Eval("Tit2") %>' runat="server"/><br /><br />
                </div>
                <div>
                    <asp:Literal Text='<%# Eval("Des2") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo2") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold;">
                    <asp:Literal Text='<%# Eval("Tit3") %>' runat="server"/><br /><br />
                </div>
                <div>
                    <asp:Literal Text='<%# Eval("Des3") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo3") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold;">
                    <asp:Literal Text='<%# Eval("Tit4") %>' runat="server"/><br /><br />
                </div>
                <div>
                    <asp:Literal Text='<%# Eval("Des4") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo4") %>' runat="server"/><br /><br />
                </div>
                <div style="font-weight:bold;">
                    <asp:Literal Text='<%# Eval("Tit5") %>' runat="server"/><br /><br />
                </div>
                <div>
                    <asp:Literal Text='<%# Eval("Des5") %>' runat="server"/><br /><br />
                    <asp:Image ImageUrl='<%# Eval("Photo5") %>' runat="server"/><br /><br />
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <%--DetailsProduct--%>

</asp:Content>
