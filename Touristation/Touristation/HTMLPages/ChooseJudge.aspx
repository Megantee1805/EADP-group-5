<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="ChooseJudge.aspx.cs" Inherits="Touristation.HTMLPages.ChooseJudge" %>

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
            <br />
             Choose A Judge 
            <asp:DropDownList ID="ddJudges" CssClass="dropdown form-control" runat="server" AutoPostBack="false"></asp:DropDownList>
            Prize Picture <br />
            <asp:FileUpload ID="prizeLink" CssClass="form-control col-xs-12" runat="server" />
            <asp:Button ID="btnUpload" CssClass="btn btn-default" runat="server" Text="SUbmit" />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary col-xs-5" OnClick="btnComCreate_Click" />
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
    </asp:Content>