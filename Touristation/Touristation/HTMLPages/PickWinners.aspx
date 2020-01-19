<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="PickWinners.aspx.cs" Inherits="Touristation.HTMLPages.PickWinners" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <!DOCTYPE html>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView
             ID="gvViewCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" />
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="endDate" HeaderText="Competition End" />
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                    <asp:ButtonField CommandName="View" Text="Pick Winners" />
                  
                </Columns>
                 </asp:GridView> 
        </div>
    </form>
</body>
</html>
</asp:Content>