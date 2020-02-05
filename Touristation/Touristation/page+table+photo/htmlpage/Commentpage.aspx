<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Commentpage.aspx.cs" Inherits="Touristation.Comment_page" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel = "stylesheet"
   type = "text/css"
   href = "style/style.css" />
    </head>
<body>
    <form id="form1" runat="server" >
        <p id="loca">\zoo/</p>
        <br />
        <div class="image">
            <img alt="" class="auto-style1" src="file:///E:/School/EADP/Project1/Touristation/Touristation/photo/4.jpg" /><br />
        </div>
        <div class="pri">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    <asp:BoundField DataField="PriceforKid" HeaderText="PriceforKid" SortExpression="PriceforKid" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Location], [PriceforKid], [Price] FROM [Price] WHERE ([Loca] = @Loca)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="zoo" Name="Loca" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            </div>
        <br />
        <p class="com">Top comments:</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Rate" HeaderText="Upvotes" SortExpression="Rate" />
                    <asp:BoundField DataField="Com" HeaderText="Comment" ReadOnly="True" SortExpression="Com" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Rate], [Com] FROM [comment] WHERE (([Rate] &gt;= @Rate) AND ([Loca] = @Loca)) ORDER BY [Rate] DESC">
                <SelectParameters>
                    <asp:Parameter DefaultValue="50" Name="Rate" Type="Int32" />
                    <asp:Parameter DefaultValue="zoo" Name="Loca" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
        <br />
        <asp:Button ID="Button1" runat="server" Text="ShowAll" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="AddNewComments" OnClick="Button2_Click" />
        
    </form>
    </body>
</html>
