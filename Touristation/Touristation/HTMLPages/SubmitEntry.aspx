<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master" 
    CodeBehind="SubmitEntry.aspx.cs" Inherits="Touristation.HTMLPages.SubmitEntry" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <html>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="LblComName" runat="server"><h3></h3></asp:Label>
            <h4>Title:</h4> <br />
            <asp:TextBox ID="tbEntryName" CssClass="form-control" runat="server"></asp:TextBox>
            <h4> Description:</h4> <br />
            <asp:TextBox CssClass="form-control" ID="tbEntryDescription" runat="server"></asp:TextBox>
            <h4>Upload Your File:</h4> <br />
            <asp:FileUpload CssClass="form-control" ID="entryFile" runat="server" />
            <br />
            <asp:Button CssClass="btn btn-primary" ID="btnEntrySubmit" runat="server" Text="Submit" OnClick="btnEntrySubmit_Click" />
            <asp:Label ID="LblMsg" runat="server"><h3></h3></asp:Label>
        </div>
    </form>
</body>
</html>
</asp:Content>
