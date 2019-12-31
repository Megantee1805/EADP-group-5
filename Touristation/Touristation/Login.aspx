<%@ Page Language="C#" 
    MasterPageFile="~/Touristation.Master" 
    AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Touristation.Login" %>

<!DOCTYPE html>
<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username <asp:TextBox ID="TbUsername" runat="server"></asp:TextBox>
            <br />
            
            Password <asp:TextBox ID="TbPassword" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>

    </form>

</asp:Content>
