<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master"
    CodeBehind="Profile.aspx.cs" Inherits="Touristation.Profile" %>


<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">


<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="uname"></asp:Label>

            <asp:Button ID="editPage" runat="server" Text="Edit Profile" />
        </div>
    </form>
</body>
    </asp:Content>