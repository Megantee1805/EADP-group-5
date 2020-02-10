<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master" 
    CodeBehind="PickPrize.aspx.cs" Inherits="Touristation.HTMLPages.PickPrize" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div>
            Title: 
            <asp:Label ID="LblTitle" CssClass="text-center" runat="server"></asp:Label>
            <br /> 
            Description: 
            <asp:Label ID="LblDesc" CssClass="text-center" runat="server"></asp:Label>
            <br />
            Start Date: 
            <asp:Label ID="LblStart" CssClass="text-center" runat="server"></asp:Label>
            <br /> 
            End Date: 
            <asp:Label ID="LblEnd" CssClass="text-center" runat="server"></asp:Label>
            <br /> 
            Method of Judging: 
            <asp:Label ID="LblMethod" CssClass="text-center" runat="server"></asp:Label>
            <br />
            Prize Picture <br />
            <asp:FileUpload ID="prizeLink" CssClass="form-control col-xs-12" runat="server" />
            <asp:Button ID="btnUpload" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="btnUpload_Click" />
        </div>
    </form>
</body>
</html>

    </asp:Content>
