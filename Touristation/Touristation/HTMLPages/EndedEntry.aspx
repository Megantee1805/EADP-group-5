<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master" CodeBehind="EndedEntry.aspx.cs" Inherits="Touristation.HTMLPages.EndedEntry" %>


  <asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="container">
                <div class="container">
                     <asp:GridView
             ID="gvViewEntries" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="Id" />
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:BoundField DataField="rank" HeaderText="Ranking" />
                 </Columns>
                </asp:GridView>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
</asp:Content>