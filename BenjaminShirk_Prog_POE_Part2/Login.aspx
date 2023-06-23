<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BenjaminShirk_Prog_POE_Part2.Login" %>

<!DOCTYPE html>
<! -- Refrences, This UI was alterd/Cretaed using ChatGPT  --> 
     
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
        <style>
        body {
            background-image: url('Images/FarmLogin.jpg');
            background-size: cover;
            background-color: #F5F5F5F5;
        }

        .login-container {
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

        .login-container h1 {
            margin-bottom: 20px;
        }

        .login-container .label {
            display: block;
            margin-bottom: 10px;
            text-align: left;
            font-family: Arial, sans-serif;
            font-size: 18px;
            font-weight: bold;
        }

        .login-container .textbox {
            width: 80%;
            padding: 10px;
            margin-left: 0;
            margin-right: 0;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .login-container .button {
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

        .login-container .button:hover {
            background-color: #45a049;
        }

        .login-container .error-message {
            color: #ff0000;
            margin-top: 10px;
        }
        </style>
        </head>
        <body>
        <form id="form1" runat="server">
        <div class="login-container">
            <h1>Farm Central</h1>
            <h1>Login</h1>
            <div class="form-container">
                <div>
                    <asp:Label ID="lblUsername" runat="server" AssociatedControlID="txtUsername" CssClass="label">Username:</asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" CssClass="label">Password:</asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnLogin" runat="server" Text="Enter" OnClick="btnLogin_Click" CssClass="button"  AssociatedControlID="btnLogin"/>
                </div>
                <div>
                    <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
               </div>
            </div>
        </div>
    </form>
</body>
</html>
