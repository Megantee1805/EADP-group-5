<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="ViewCompetitions.aspx.cs" Inherits="Touristation.HTMLPages.ViewCompetitions" %>



    <asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
        <body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:GridView
             ID="gvViewCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvViewCompetitions_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" />
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="endDate" HeaderText="Competition End" />
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                  
                    <asp:ButtonField CommandName="Submit" Text="Submit An Entry" />
                    <asp:ButtonField CommandName="View" Text="View Entries" />
                  
                </Columns>
            </asp:GridView>
       
        </div>
    </form>
        </body>
    </asp:Content>

