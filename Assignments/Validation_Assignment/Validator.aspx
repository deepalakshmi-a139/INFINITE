<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validation_Assignment.Validator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator Form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(to right, #f0f8ff, #e6f2ff);
            margin: 0;
            padding: 0;
        }
        .form-container {
            max-width: 600px;
            margin: 40px auto;
            background: #ffffff;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.1);
        }
        h1 {
            color: #0066cc;
            text-align: center;
            margin-bottom: 20px;
        }
        label {
            font-weight: bold;
            color: #333333;
        }
        input[type="text"] {
            width: 100%;
            padding: 8px;
            margin-top: 6px;
            margin-bottom: 12px;
            border: 1px solid #cccccc;
            border-radius: 6px;
            background-color: #f9f9f9;
        }
        .btn-blue {
            background-color: #0066cc;
            color: white;
            border: none;
            border-radius: 25px;
            padding: 12px 24px;
            font-size: 16px;
            cursor: pointer;
            width: 100%;
        }
        .btn-blue:hover {
            background-color: #004c99;
        }
        .error {
            color: #cc0000;
            font-weight: bold;
        }
        .summary {
            margin-top: 20px;
            color: #cc0000;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>Insert Your Details</h1>

            <label>First Name:</label>
            <asp:TextBox ID="TextBox1" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="TextBox1" ErrorMessage="Name cannot be empty" CssClass="error" /><br />

            <label>Family Name:</label>
            <asp:TextBox ID="TextBox2" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="TextBox2" ErrorMessage="Family name required" CssClass="error" />
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToValidate="TextBox2" ControlToCompare="TextBox1"
                Operator="NotEqual" ErrorMessage="Family Name must differ from First Name" CssClass="error" /><br />

            <label>Address:</label>
            <asp:TextBox ID="TextBox3" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="TextBox3" ErrorMessage="Address required" CssClass="error" />
            <asp:RegularExpressionValidator ID="RegexAddress" runat="server"
                ControlToValidate="TextBox3" ValidationExpression="^.{2,}$"
                ErrorMessage="At least 2 characters" CssClass="error" /><br />

            <label>City:</label>
            <asp:TextBox ID="TextBox4" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                ControlToValidate="TextBox4" ErrorMessage="City required" CssClass="error" />
            <asp:RegularExpressionValidator ID="RegexCity" runat="server"
                ControlToValidate="TextBox4" ValidationExpression="^.{2,}$"
                ErrorMessage="At least 2 characters" CssClass="error" /><br />

            <label>Zip Code:</label>
            <asp:TextBox ID="TextBox5" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ControlToValidate="TextBox5" ErrorMessage="Zip Code required" CssClass="error" />
            <asp:RegularExpressionValidator ID="RegexZip" runat="server"
                ControlToValidate="TextBox5" ValidationExpression="^\d{5}$"
                ErrorMessage="Zip must be 5 digits" CssClass="error" /><br />

            <label>Phone:</label>
            <asp:TextBox ID="TextBox6" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                ControlToValidate="TextBox6" ErrorMessage="Phone required" CssClass="error" />
            <asp:RegularExpressionValidator ID="RegexPhone" runat="server"
                ControlToValidate="TextBox6" ValidationExpression="^\d{2,3}-\d{7}$"
                ErrorMessage="Format: XX-XXXXXXX or XXX-XXXXXXX" CssClass="error" /><br />

            <label>Email:</label>
            <asp:TextBox ID="TextBox7" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                ControlToValidate="TextBox7" ErrorMessage="Email required" CssClass="error" />
            <asp:RegularExpressionValidator ID="RegexEmail" runat="server"
                ControlToValidate="TextBox7"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ErrorMessage="example@example.com" CssClass="error" /><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" CssClass="btn-blue" /><br /><br />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                CssClass="summary" HeaderText="Validation Summary" ShowMessageBox="True" ShowSummary="True" />
        </div>
    </form>
</body>
</html>
