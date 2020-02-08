<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="ChooseJudge.aspx.cs" Inherits="Touristation.HTMLPages.ChooseJudge" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblTitle" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="LblDesc" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="LblStart" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="LblEnd" runat="server" Text="Label"></asp:Label>
             Choose A Judge 
            <asp:DropDownList ID="ddJudges" Visible="false" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
    </asp:Content>