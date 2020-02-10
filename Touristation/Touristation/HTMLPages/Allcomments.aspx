<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Allcomments.aspx.cs" Inherits="Touristation.All_comments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel = "stylesheet"
   type = "text/css"
   href = "style/style.css" />
    </head>
<body>
    <form id="form1" runat="server">
        <p id="loca">\zoo/</p>
        <p class="com">All Comments:</p>
        <br />
        <div class="pri">
        <asp:GridView ID="Allcom" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Rate" HeaderText="Upvote" SortExpression="Rate" />
                <asp:BoundField DataField="Com" HeaderText="Comment" ReadOnly="True" SortExpression="Com" />
                <asp:ButtonField Text="Like" CommandName="LIKE" ButtonType="Button" />
                <asp:ButtonField Text="dislike" CommandName="DISLIKE" ButtonType="Button" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Rate], [Com] FROM [comment] WHERE ([Loca] = @Loca) ORDER BY [Rate] DESC">
            <SelectParameters>
                <asp:Parameter DefaultValue="zoo" Name="Loca" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
            </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back" align="right" OnClick="Button1_Click" />
        <br />
        
    </form>
</body>
</html>
