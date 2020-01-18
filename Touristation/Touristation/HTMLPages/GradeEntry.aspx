<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/Touristation.Master"     
    CodeBehind="GradeEntry.aspx.cs" Inherits="Touristation.HTMLPages.ViewSingleEntry" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<html>
<body>
    <form id="form1" runat="server">
        <div>
            Title: 
            <asp:TextBox ID="tbEntryTitle" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
            Description
            <asp:TextBox ID="tbEntryDesc" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
            Photo: 
            <asp:Image ID="imgEntry" CssClass="img-thumbnail" runat="server" />
            <br />
            <asp:Button ID="btnVote" runat="server" CssClass="btn btn-primary" Text="Vote" OnClick="btnVote_Click" />
        </div>
    </form>
</body>
</html>
</asp:Content>