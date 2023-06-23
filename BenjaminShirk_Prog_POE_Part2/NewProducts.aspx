<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProducts.aspx.cs" Inherits="BenjaminShirk_Prog_POE_Part2.NewProducts" %>

<!DOCTYPE html>
<! -- Refrences, This UI was alterd/Cretaed using ChatGPT  --> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NewProducts</title>
    <style>
        body {
            background-image: url('Images/newproducts.jpg');
            background-size: cover;
            background-color: #F5F5F5F5;
        }

        .NewProduct-container {
            text-align: center;
            max-width: 300px;
            margin: 0 auto;
            padding: 20px;
            border-radius: 4px;
        }

        .form-container {
            background-color: #e0f4e8;
            padding: 10px;
            border-radius: 4px;
            border: 2px solid;
            font-weight: bold;
        }

        .NewProduct-container h1 {
            margin-bottom: 20px;
        }

        .NewProduct-container .label {
            display: block;
            margin-bottom: 10px;
            text-align: left;
            font-family: Arial, sans-serif;
            font-size: 18px;
            font-weight: bold;
        }

        .NewProduct-container .textbox {
            width: 80%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .NewProduct-container .button {
            width: 100%;
            margin-top: 10px;
            padding: 15px;
            font-size: 18px;
            font-family: Arial, sans-serif;
            font-weight: bold;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .NewProduct-container .button:hover {
            background-color: #45a049;
        }

        .NewProduct-container .error-message {
            color: #ff0000;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="NewProduct-container">
            <div>
                <h1>Farm Central Products</h1>
                <h1>Add New Product</h1>
                <div class="form-container">
                    <div>
                        <asp:Label runat="server" Text="Product ID:" CssClass="label" AssociatedControlID="txtProductID"></asp:Label>
                        <asp:TextBox runat="server" ID="txtProductID" CssClass="textbox"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Product Name:" CssClass="label" AssociatedControlID="txtProductName"></asp:Label>
                        <asp:TextBox runat="server" ID="txtProductName" CssClass="textbox"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Product Description:" CssClass="label" AssociatedControlID="txtProductDescription"></asp:Label>
                        <asp:TextBox runat="server" ID="txtProductDescription" CssClass="textbox"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Date Added:" CssClass="label" AssociatedControlID="txtDateAdded"></asp:Label>
                        <asp:TextBox runat="server" ID="txtDateAdded" CssClass="textbox"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label runat="server" Text="Quantity Added:" CssClass="label" AssociatedControlID="txtQuantityAdded"></asp:Label>
                        <asp:TextBox runat="server" ID="txtQuantityAdded" CssClass="textbox"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Button runat="server" Text="Add Product" OnClick="AddProduct_Click" CssClass="button" AssociatedControlID="btnAddProduct"/>
                    </div>
                    <div>
                        <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>