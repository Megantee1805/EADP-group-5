<%@ Page Language="C#"  MasterPageFile="~/Touristation.Master" 
    AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Touristation.Resgiter" %>

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
            
            Username <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br />
            Email <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox> <br /> 
            Password <asp:TextBox ID="tbPass" runat="server"></asp:TextBox><br /> 
            Confirm Password <asp:TextBox ID="tbConfirmpass" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" />
        </div>
    </form>
</body>
</html>
    
</asp:Content> 
