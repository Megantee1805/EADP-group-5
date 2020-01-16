<%@ Page Language="C#"  MasterPageFile="~/Touristation.Master" 
    AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Touristation.Resgiter" %>

<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">

<html>
<body>
    <form id="form1" runat="server">
        <div>
            
            Username <asp:TextBox ID="tbUsername"  CssClass="form-control" runat="server"></asp:TextBox><br />
            Email <asp:TextBox ID="tbEmail" CssClass="form-control" runat="server"></asp:TextBox> <br /> 
            Password <asp:TextBox ID="tbPass" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox><br /> 
            Confirm Password <asp:TextBox ID="tbConfirm" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" CssClass="btn btn-primary btn-group-xs" Text="Register" OnClick="btnRegister_Click" />
           
        </div>
    </form> 
    <asp:Label ID="errorMsg" runat="server"></asp:Label>
</body>
</html>
    
</asp:Content> 
