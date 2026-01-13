<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ViewBills.aspx.cs" Inherits="ElectricityBillingAutomation.ViewBills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="card shadow">
            <div class="card-header bg-success text-white text-center">
                <h4>View Last N Bills</h4>
            </div>
            <div class="card-body">
                <div class="form-group row mb-4">
                    <label class="col-sm-2 col-form-label">Enter N:</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtN" runat="server" CssClass="form-control" />
                    </div>
                    <div class="col-sm-4">
                        <asp:Button ID="btnView" runat="server" Text="View Bills" CssClass="btn btn-success w-100" OnClick="btnView_Click" />
                    </div>
                </div>

                <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-striped" />
            </div>
        </div>
    </div>
</asp:Content>
