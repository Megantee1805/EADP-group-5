<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addcomment.aspx.cs" Inherits="Touristation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
    background-image: url("E:/School/EADP/Project1/Touristation/Touristation/photo/bk3.jpg");
    background-attachment: fixed;
}

#loca {
    font-family: "Comic Sans MS", cursive, sans-serif;
    text-align: center;
    font-size: 64px;
    color: black;
}
.com {
    font-family: "Comic Sans MS", cursive, sans-serif;
    text-align: left;
    font-size: 28px;
    color: white;
}
#idn{    font-family: "Comic Sans MS", cursive, sans-serif;
    text-align: left;
    font-size: 28px;
    color: white;
}
#Button2{
    float:right;
}
#Button1{
    float:right;
}
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p id="loca">\zoo/</p>
        </div>
        <div>
            <asp:TextBox ID="comen" runat="server" Height="220px" Width="1360px"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Leave" OnClick="Button3_Click" />
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
