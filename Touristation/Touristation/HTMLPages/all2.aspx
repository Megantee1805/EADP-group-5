<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="all2.aspx.cs" Inherits="Touristation.all2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel = "stylesheet"
   type = "text/css"
   href = "style/style3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p id="loca">\Sentosa/</p>
        </div>
        <p class="com">All Comments:</p>
        <div class="comu">

            <asp:GridView ID="allcom" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />
                    <asp:BoundField DataField="Com" HeaderText="Com" SortExpression="Com" />
                    <asp:BoundField DataField="Rate" HeaderText="Rate" SortExpression="Rate" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Com], [Rate] FROM [comment] WHERE ([Loca] = @Loca) ORDER BY [Rate] DESC">
                <SelectParameters>
                    <asp:Parameter DefaultValue="sen" Name="Loca" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Com], [Rate] FROM [comment] WHERE ([Loca] = @Loca) ORDER BY [Rate] DESC">
                <SelectParameters>
                    <asp:Parameter DefaultValue="sen" Name="Loca" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
