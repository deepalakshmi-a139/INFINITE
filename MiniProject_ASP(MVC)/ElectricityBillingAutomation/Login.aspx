<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectricityBillingAutomation.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center mt-5">
        <div class="col-md-5">
            <div class="card shadow">
                <div class="card-header bg-primary text-white text-center">
                    <h4>Admin Login</h4>
                </div>
                <div class="card-body">
                    <asp:Label ID="lblMsg" runat="server" CssClass="text-danger mb-3" />

                    <div class="form-group mb-3">
                        <asp:Label AssociatedControlID="txtUser" runat="server" Text="Username" CssClass="form-label" />
                        <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder="Enter username" />
                    </div>

                    <div class="form-group mb-4">
                        <asp:Label AssociatedControlID="txtPass" runat="server" Text="Password" CssClass="form-label" />
                        <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter password" />
                    </div>

                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary w-100" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
