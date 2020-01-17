﻿<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Touristation.Master" 
    CodeBehind="ViewEntries.aspx.cs" Inherits="Touristation.HTMLPages.ViewEntries" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView
             ID="gvViewEntries" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:CommandField HeaderText="Select" />
                 </Columns>
                </asp:GridView>
        </div>
    </form>
</body>
</html>
</asp:Content>
