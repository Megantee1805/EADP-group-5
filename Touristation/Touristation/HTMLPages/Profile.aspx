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
            <br />  
            
            
            <asp:Button ID="editPage" runat="server" Text="Edit Profile" OnClick="editPage_Click" />
            <br /> 
            <asp:Panel runat="server" ID="editPanel" Visible="false">
                Username: 
                <asp:TextBox runat="server" ID="tbEditName"> 
                </asp:TextBox>
                <br />
                Email: 
                <asp:TextBox runat="server" ID="tbEditEmail"> 
                </asp:TextBox>
                <br /> 
                Password: 
                     <asp:TextBox runat="server" TextMode="Password" ID="tbEditPass"> 
                </asp:TextBox>
                <br /> 
                Confirm Password
                 <asp:TextBox runat="server" TextMode="Password" ID="tbEditConfirm"> 
                </asp:TextBox>
                <br />
               
                <asp:DropDownList ID="DDCountry" runat="server" Width="100"></asp:DropDownList>
                <br /> 
                <asp:Button runat="server" ID="btnEditProfile" Text="Edit" OnClick="btnEditProfile_Click">
                </asp:Button>
                <asp:Label runat="server" ID="LblMsg"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
    </asp:Content>