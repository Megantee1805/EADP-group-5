<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Touristation.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel = "stylesheet"
   type = "text/css"
   href = "style/style2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <p id="loca">\Welcome to Singapore/</p>
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" src="E:/School/EADP/Project1/Touristation/Touristation/photo/a1.jpg" OnClick="ImageButton1_Click" Height="325px" Width="529px" /><p id="wo">Sentosa</p>
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" src="E:/School/EADP/Project1/Touristation/Touristation/photo/4.jpg" Height="334px" Width="595px"  OnClick="ImageButton2_Click"/><p id="woo">Singapore zoo</p>
        </form>
</body>
</html>
