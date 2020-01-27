<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewItinerary.aspx.cs" Inherits="Touristation.ViewItinerary" %>

<!DOCTYPE html>

<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
        <div>
        </div>
          <asp:GridView ID="GVItinerary" runat="server" AutoGenerateColumns="False" Width="878px">
            <Columns>
                <asp:BoundField DataField="Date" HeaderText="Date" ReadOnly="True" />
                <asp:BoundField DataField="Time" HeaderText="Time" ReadOnly="True" />
                <asp:BoundField DataField="NOP" HeaderText="Name of Place" ReadOnly="True" />
                <asp:BoundField DataField="Location" HeaderText="Location" ReadOnly="True" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
</asp:Content>