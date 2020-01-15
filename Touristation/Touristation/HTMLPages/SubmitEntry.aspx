<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master" 
    CodeBehind="SubmitEntry.aspx.cs" Inherits="Touristation.HTMLPages.SubmitEntry" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblComName" runat="server"></asp:Label>
            Title: <br />
            <asp:TextBox ID="tbEntryName" runat="server"></asp:TextBox>
            Description: <br />
            <asp:TextBox ID="tbEntryDescription" runat="server"></asp:TextBox>
            Upload Your File: <br />
            <asp:FileUpload ID="entryFile" runat="server" />
            <asp:Button ID="btnEntrySubmit" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
</asp:Content>
