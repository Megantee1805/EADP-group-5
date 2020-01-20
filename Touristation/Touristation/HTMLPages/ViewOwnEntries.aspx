<%@ Page Language="C#" AutoEventWireup="true"
    MasterPageFile="~/Touristation.Master"CodeBehind="ViewOwnEntries.aspx.cs" Inherits="Touristation.HTMLPages.ViewOwnEntries" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <body>
    <form id="form1" runat="server">
        
                    
             <asp:GridView
             ID="gvViewOwnEntries" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False" OnRowCommand="gvViewOwnEntries_RowCommand">
                 <Columns>
                     <asp:BoundField DataField="Id" />
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:BoundField DataField="votes" />
                     <asp:ButtonField CommandName="View" Text="Edit" />
                     <asp:ButtonField CommandName="Delete" Text="Delete" />
                 </Columns>
                </asp:GridView> 
    </form>
</body>
</html>
</asp:Content>