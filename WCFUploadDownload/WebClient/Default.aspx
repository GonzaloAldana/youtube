﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Download" OnClick="Button2_Click" />
    </form>
</body>
</html>
