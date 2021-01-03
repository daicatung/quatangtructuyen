﻿<%@ Page Title="" Language="C#" MasterPageFile="~/page/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="QuaTrucTuyen247.page.Admin.User.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
        <div class="row" style="padding: 0 10px;">
            <div class="col-md-12">
                <h3>SỬA THÔNG TIN NGƯỜI DÙNG</h3>
                <hr style="width: 100%" />
            </div>
            <div class="col-md-12">
                <table class="table table-bordered">
                    <tr>
                        <th>User ID</th>
                        <th>
                             <asp:TextBox ID="txtuserid" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Tên người dùng</th>
                        <th>
                            <asp:TextBox ID="txtusername" runat="server" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Mật khẩu</th>
                        <th>
                            <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Email</th>
                        <th>
                            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Điện thoại</th>
                        <th>
                            <asp:TextBox ID="txtphone" runat="server" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Địa chỉ</th>
                        <th>
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>Quyền</th>
                        <th> <asp:TextBox ID="txtrole" runat="server" CssClass="form-control"></asp:TextBox></th>
                    </tr>
                    <tr>
                        <th>Trạng thái</th>
                        <th> <asp:CheckBox ID="chbUserstate" runat="server"/>&nbsp; Active</th>
                    </tr>
                   
                    <tr>
                        <th colspan="2" style="text-align:center;">
                            <asp:Button ID="btnSave" runat="server" Text="Lưu lại" CssClass="btn btn-warning" OnClick="btnSave_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Hủy bỏ" CssClass="btn btn-danger" OnClick="btnCancel_Click" />
                        </th>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
