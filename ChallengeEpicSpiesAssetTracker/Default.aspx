﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <h2>Asset Performance Tracker</h2>
        <br />
        Asset Name:&nbsp; <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged: <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge Performed:&nbsp;
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
