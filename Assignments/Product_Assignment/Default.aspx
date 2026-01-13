<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Product_Assignment.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Makeup Product Selector</title>
    <style>
        body {
            font-family: Arial, sans-serif;
<<<<<<< HEAD
            background-color: #fdf2f8; 
=======
            background-color: lavenderblush;
>>>>>>> d05a64eed85ef8bf96b222a01a2d8cfc15812acb
            margin: 0;
            padding: 0;
        }
        form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .container {
            background: white;
            padding: 25px;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.2);
            text-align: center;
            width: 340px;
        }
        h2 {
            margin-bottom: 20px;
<<<<<<< HEAD
            color: #d63384;
=======
            color: deeppink;
>>>>>>> d05a64eed85ef8bf96b222a01a2d8cfc15812acb
        }
        #ddl_Product {
            width: 100%;
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid gray;
            border-radius: 5px;
        }
        #img_Product {
            border: 1px solid lightgray;
            border-radius: 6px;
            margin-bottom: 15px;
        }
        #btnGetPrice {
            background-color: hotpink;
            color: white;
            border: none;
            padding: 10px 18px;
            border-radius: 6px;
            cursor: pointer;
            font-size: 15px;
            display: block;
            margin: 0 auto;
        }
        #btnGetPrice:hover {
            background-color: crimson;
        }
        #lblPrice {
            display: block;
            margin-top: 12px;
            font-size: 16px;
            color: dimgray;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Select Your Makeup Product</h2>

            <asp:DropDownList ID="ddl_Product" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddl_Product_SelectedIndexChanged">
                <asp:ListItem Text="Lipstick" Value="Lipstick"></asp:ListItem>
                <asp:ListItem Text="Foundation" Value="Foundation"></asp:ListItem>
                <asp:ListItem Text="Mascara" Value="Mascara"></asp:ListItem>
                <asp:ListItem Text="Eyeliner" Value="Eyeliner"></asp:ListItem>
                <asp:ListItem Text="Blush" Value="Blush"></asp:ListItem>
                <asp:ListItem Text="Compact Powder" Value="Compact Powder"></asp:ListItem>
                <asp:ListItem Text="Makeup Kit" Value="Makeup Kit"></asp:ListItem>
            </asp:DropDownList>

            <asp:Image ID="img_Product" runat="server" Width="200px" Height="200px" />

            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />

            <asp:Label ID="lblPrice" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
