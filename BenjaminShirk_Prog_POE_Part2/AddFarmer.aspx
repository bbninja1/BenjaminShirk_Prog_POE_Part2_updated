<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFarmer.aspx.cs" Inherits="BenjaminShirk_Prog_POE_Part2.AddFarmer" %>

<!DOCTYPE html>
<! -- Refrences, This UI was alterd/Cretaed using ChatGPT  --> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AddFarmer</title>
    <style>
        body {
            background-image: url('Images/AddFarmer.jpg');
            background-size: cover;
            background-color: #F5F5F5F5;
        }

        .NewFarmer-container {
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

        .NewFarmer-container h1 {
            margin-bottom: 20px;
        }

        .NewFarmer-container .label {
            display: block;
            margin-bottom: 10px;
            text-align: left;
            font-family: Arial, sans-serif;
            font-size: 18px;
            font-weight: bold;
        }

        .NewFarmer-container .textbox {
            width: 80%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .NewFarmer-container .button {
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

        .NewFarmer-container .button:hover {
            background-color: #45a049;
        }

        .NewFarmer-container .error-message {
            color: #ff0000;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="NewFarmer-container">
            <h1>Farm Central Farmers</h1>
            <h1>Add New Farmer</h1>
            <div class="form-container">
                <div>
                    <asp:Label ID="lblFarmerID" runat="server" Text="Farmer ID:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtFarmerID" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblFirstname" runat="server" Text="First Name:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtFirstname" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblSurname" runat="server" Text="Surname:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtSurname" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblEmail" runat="server" Text="Email:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblAddress" runat="server" Text="Address:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblCity" runat="server" Text="City:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtCity" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblUsername" runat="server" Text="Username:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblPassword" runat="server" Text="Password:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="button" />
                </div>
                <div>
                    <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
               </div>
            </div>
        </div>
    </form>
</body>
</html>