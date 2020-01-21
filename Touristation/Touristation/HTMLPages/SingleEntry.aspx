<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/Touristation.Master"     
    CodeBehind="SingleEntry.aspx.cs" Inherits="Touristation.HTMLPages.ViewSingleEntry" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <html>
<body>
    <form id="form1" runat="server">
        <div>
            Title: 
            <asp:TextBox ID="tbEntryTitle" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
            Description
            <asp:TextBox ID="tbEntryDesc" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
            Photo: 
            <asp:Image Visible="true" ID="imgEntry" CssClass="img-thumbnail" runat="server" />
            <br />
            <asp:Label ID="Lblfile" Visible="false" runat="server">Change your file</asp:Label>
            <asp:FileUpload ID="editFile" Visible="false" runat="server" />
            <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnSave" runat="server" Visible="false" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnCancel" runat="server" Visible="false" CssClass="btn btn-danger" Text="Cancel" OnClick="btnCancel_Click"/>
        </div>
    </form>
</body>
</html>
</asp:Content>