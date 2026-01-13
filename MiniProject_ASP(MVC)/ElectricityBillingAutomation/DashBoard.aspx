<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ElectricityBillingAutomation.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="text-center mb-4">
            <h2 class="text-primary">Welcome to Electricity Billing System</h2>
            <p class="lead">Select an option below to manage bills efficiently.</p>
        </div>

        <div class="row justify-content-center">
            <div class="col-md-5 mb-4">
                <div class="card shadow border-0">
                    <div class="card-header bg-primary text-white text-center">
                        <h4 class="mb-0">Add Bill</h4>
                    </div>
                    <div class="card-body">
                        <p class="card-text">Create a new electricity bill for a consumer.</p>
                        <a href="AddBill.aspx" class="btn btn-outline-primary w-100">Go to Add Bill</a>
                    </div>
                </div>
            </div>

            <div class="col-md-5 mb-4">
                <div class="card shadow border-0">
                    <div class="card-header bg-success text-white text-center">
                        <h4 class="mb-0">View Bills</h4>
                    </div>
                    <div class="card-body">
                        <p class="card-text">See all bills generated in the system.</p>
                        <a href="ViewBills.aspx" class="btn btn-outline-success w-100">Go to View Bills</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
