<%@ Page Language="C#" 
    MasterPageFile="~/Touristation.Master" 
    AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Touristation.Login" %>

<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">

<html>
<body>
    <form id="form1" runat="server">
        <div>
            Username <asp:TextBox ID="TbUsername" runat="server"></asp:TextBox>
            <br />
            
            Password <asp:TextBox ID="TbPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>

    <asp:Label ID="errorMsg" runat="server"></asp:Label>
</body>
</html>

</asp:Content>
