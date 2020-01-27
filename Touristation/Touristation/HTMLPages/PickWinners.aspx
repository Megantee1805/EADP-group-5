<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="PickWinners.aspx.cs" Inherits="Touristation.HTMLPages.PickWinners" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <!DOCTYPE html>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1> Running Competitons </h1>
             <asp:GridView
             ID="gvViewCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvViewCompetitions_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" />
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="endDate" HeaderText="Competition End" />
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                    <asp:ButtonField CommandName="Edit" Text="Edit" />
                    <asp:ButtonField CommandName="Delete" Text="Delete" /> 
                </Columns>
                 </asp:GridView> 
            <h1>Ended Competitions </h1>
            <asp:GridView
             ID="gvEndedCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEndedCompetitions_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" />
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="endDate" HeaderText="Competition End" />
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                    <asp:ButtonField CommandName="Finish" Text="Pick Winner" /> 
                </Columns>
                 </asp:GridView> 
        </div>
    </form>
</body>
</html>
</asp:Content>