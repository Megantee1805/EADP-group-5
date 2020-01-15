<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="ViewCompetitions.aspx.cs" Inherits="Touristation.HTMLPages.ViewCompetitions" %>



    <asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
        <body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:GridView
             ID="gvViewCompetitions" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvViewCompetitions_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Title" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="startDate" HeaderText="Competition Start" />
                    <asp:BoundField DataField="entriesNo" HeaderText="No of Entries" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
       
        </div>
    </form>
        </body>
    </asp:Content>

