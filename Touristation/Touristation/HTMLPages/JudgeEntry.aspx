<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master"
    CodeBehind="JudgeEntry.aspx.cs" Inherits="Touristation.HTMLPages.JudgeEntry" %>


<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:DataList ID="dataScore" runat="server">
                <ItemTemplate>
                    <asp:TextBox runat="server" CssClass="col-xs-3 form-control" ID="tbName" Text='<%#Bind("name") %>' />
                    <asp:TextBox runat="server" CssClass="col-xs-3 form-control"  ID="tbScore" Enabled="false"></asp:TextBox>
                    <asp:Button runat="server" CommandName="Give Score" Text="Judge" />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>

    </asp:Content>
