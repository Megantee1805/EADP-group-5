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
                <asp:DropDownList ID="DDCountry" CssClass="col-xs-12 form-control" runat="server" Enabled="False"></asp:DropDownList>
                <br /> 
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnEditProfile" Text="Edit" OnClick="btnEditProfile_Click">
                </asp:Button> 
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnSaveChanges" Text="Save" OnClick="btnSaveChanges_Click" />
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnChangePassword" Text="Change Password" OnClick="btnChangePassword_Click" />
                <br />
                <asp:Button ID="btnDeleteUser" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDeleteUser_Click" />
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

            <asp:GridView
             ID="gvViewOwnEntries" CssClass="col-xs-12" runat="server" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="Id" />
                     <asp:BoundField DataField="name" HeaderText="Name" />
                     <asp:BoundField DataField="description" HeaderText="Description" />
                     <asp:ImageField DataImageUrlField="fileLink" ControlStyle-CssClass="img-thumbnail">
<ControlStyle CssClass="img-thumbnail"></ControlStyle>
                     </asp:ImageField>
                     <asp:BoundField DataField="votes" />
                     
                 </Columns>
                </asp:GridView>
        </div>
    </form>
</body>
    </asp:Content>