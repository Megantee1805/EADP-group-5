<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Touristation.Master" 
    CodeBehind="ViewEntries.aspx.cs" Inherits="Touristation.HTMLPages.ViewEntries" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="userView" runat="server">
             <asp:GridView
             ID="gvViewEntries" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvViewEntries_RowCommand">
                 <Columns>
                     <asp:BoundField DataField="Id" />
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:BoundField DataField="votes" />
                     <asp:ButtonField CommandName="View" Text="Vote" />
                 </Columns>
                </asp:GridView>

            </asp:Panel>

            <asp:Panel ID="adminView" runat="server">
                <asp:GridView
             ID="gvAdminEntries" CssClass="col-xs-12" runat="server" Visible="false" AutoGenerateColumns="False" OnRowCommand="gvViewEntries_RowCommand">
                 <Columns>
                     <asp:BoundField DataField="Id" />
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:BoundField DataField="votes" />
                     <asp:ButtonField CommandName="Pick" Text="Pick Winner" />
                 </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
</asp:Content>
