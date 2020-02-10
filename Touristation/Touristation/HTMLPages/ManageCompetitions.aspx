<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master"
    CodeBehind="ManageCompetitions.aspx.cs" Inherits="Touristation.HTMLPages.AdminCompetitions" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <html>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="container">
                <div class="container">
                    <asp:GridView
             ID="gvViewCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvViewCompetitions_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" />
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="endDate" HeaderText="Competition End" />
                    <asp:ImageField DataImageUrlField="prize" HeaderText="Prizes">
                    </asp:ImageField>
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                    <asp:BoundField DataField="isDeleted" HeaderText="" />
                    <asp:ButtonField CommandName="Edit" Text="Edit" />
                    <asp:ButtonField CommandName="Delete" Text="Remove" />
                  
                </Columns>
            </asp:GridView>
             
                </div>
            </div>
        </div>
    </form>
</body>
</html>
    </asp:Content>
