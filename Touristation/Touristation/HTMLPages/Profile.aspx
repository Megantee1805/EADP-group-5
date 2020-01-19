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
            <br />  
            <asp:Panel ID="profilePanel" runat="server">
                Username: 
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="tbEditName"> 
                </asp:TextBox>
                <br />
                Email: 
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="tbEditEmail"> 
                </asp:TextBox>
                <br />
                Country 
                <asp:DropDownList ID="DDCountry" CssClass="form-control" runat="server" Width="100" Enabled="False"></asp:DropDownList>
                <br /> 
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnEditProfile" Text="Edit" OnClick="btnEditProfile_Click">
                </asp:Button> 
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnSaveChanges" Text="Save" OnClick="btnSaveChanges_Click" />
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnChangePassword" Text="Change Password" OnClick="btnChangePassword_Click" />
                </asp:Panel>
                <asp:Label runat="server" ID="LblMsg"></asp:Label>
            <asp:Panel ID="passwordPanel" Visible = "false" runat="server">
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="tbEditPass"> 
                </asp:TextBox>
                Password
                <br /> 
                
                 <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="tbEditConfirm"> 
                </asp:TextBox>
                Confirm Password 
                <br />
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnSavePassword" Text="Save Password" OnClick="btnSavePassword_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
    </asp:Content>