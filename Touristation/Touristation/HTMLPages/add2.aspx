<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add2.aspx.cs" Inherits="Touristation.add2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel = "stylesheet"
   type = "text/css"
   href = "style/style3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="loca">\Sentosa/</p>
        </div>
        <div>
            <asp:TextBox ID="commen" runat="server" Height="155px" Width="1180px"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
        </div>
    </form>
</body>
</html>
