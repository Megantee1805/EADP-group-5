<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commentpage2.aspx.cs" Inherits="Touristation.WebForm4" %>

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
        <p id="loca">\Sentosa/</p>
        <br />
        <div class="image">
            <img alt="" class="auto-style1" src="file:///E:/School/EADP/Project1/Touristation/Touristation/photo/a1.jpg" /><br />
        </div>
        <div class="pri">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="PriceforKid" HeaderText="PriceforKid" SortExpression="PriceforKid" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Location], [Price], [PriceforKid] FROM [Price] WHERE ([Loca] = @Loca)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="sen" Name="Loca" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            </div>
        <br/>
        <p class="com">Top comments:</p>
        <div class="comu">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Com" HeaderText="Com" SortExpression="Com" />
                    <asp:BoundField DataField="Rate" HeaderText="Rate" SortExpression="Rate" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Com], [Rate] FROM [comment] WHERE (([Loca] = @Loca) AND ([Rate] &gt;= @Rate)) ORDER BY [Rate] DESC">
                <SelectParameters>
                    <asp:Parameter DefaultValue="sen" Name="Loca" Type="String" />
                    <asp:Parameter DefaultValue="50" Name="Rate" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Addcomment" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Allcomments" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
