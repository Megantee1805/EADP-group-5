<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master"
    CodeBehind="Homepage.aspx.cs" Inherits="Touristation.Homepage" %>

<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="userPage" Visible="false" runat="server">
            <asp:LinkButton ID="LbCompetition" CssClass="h3" runat="server" PostBackUrl="~/HTMLPages/ViewCompetitions.aspx">Enter Competitions </asp:LinkButton>
            <br />
            <asp:LinkButton ID="LbOwnEntries" CssClass="h3"  runat="server" OnClick="LbOwnEntries_Click">View Own Entries</asp:LinkButton>
        </asp:Panel>
                </div>
    </form>
</body>
</html>

    </asp:Content>
