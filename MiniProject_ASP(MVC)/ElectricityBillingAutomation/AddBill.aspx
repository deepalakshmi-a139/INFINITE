<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="AddBill.aspx.cs" Inherits="ElectricityBillingAutomation.AddBill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center mt-5">
        <div class="col-md-6">
            <div class="card shadow">
                <div class="card-header bg-primary text-white text-center">
                    <h4>Add Electricity Bill</h4>
                </div>
                <div class="card-body">
                    <div class="form-group mb-3">
                        <asp:TextBox ID="txtConsumerNumber" runat="server" CssClass="form-control" placeholder="Consumer Number" />
                    </div>
                    <div class="form-group mb-3">
                        <asp:TextBox ID="txtConsumerName" runat="server" CssClass="form-control" placeholder="Consumer Name" />
                    </div>
                    <div class="form-group mb-4">
                        <asp:TextBox ID="txtUnits" runat="server" CssClass="form-control" placeholder="Units Consumed" />
                    </div>
                    <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" CssClass="btn btn-primary w-100" OnClick="btnAddBill_Click" />
                    <asp:Label ID="lblResult" runat="server" CssClass="mt-3 d-block text-center" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
