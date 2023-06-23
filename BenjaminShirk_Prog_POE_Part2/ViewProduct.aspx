<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="BenjaminShirk_Prog_POE_Part2.ViewProduct" %>

<!DOCTYPE html>
<! -- Refrences, This UI was alterd/Cretaed using ChatGPT  --> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url('Images/ViewProduct.jpg');
            background-repeat: no-repeat;
            background-size: cover;
        }
        .custom-gridview {
        background-color: #FFFFFF; 
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            </div>
            
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White">
        </asp:GridView>
        <p>
            <asp:Button ID="btnView" runat="server" Text="View Database" OnClick="btnView_Click" />
            <asp:Button ID="btnDate" runat="server" Text="Sort by Date" OnClick="btnDate_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Go Back" OnClick="btnBack_Click"/>
            </p>
    </form>
</body>
</html>