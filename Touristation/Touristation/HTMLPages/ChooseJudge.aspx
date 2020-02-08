<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="ChooseJudge.aspx.cs" Inherits="Touristation.HTMLPages.ChooseJudge" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblTitle" runat="server"></asp:Label>
            <br /> 
            <asp:Label ID="LblDesc" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblStart" runat="server"></asp:Label>
            <br /> 
            <asp:Label ID="LblEnd" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblJudge" runat="server"></asp:Label>
            <br />
             Choose A Judge 
            <asp:DropDownList ID="ddJudges" CssClass="dropdown form-control" runat="server" AutoPostBack="false" OnSelectedIndexChanged="ddJudges_SelectedIndexChanged"></asp:DropDownList>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary col-xs-5" OnClick="btnComCreate_Click" />
        </div>
    </form>
</body>
</html>
    </asp:Content>