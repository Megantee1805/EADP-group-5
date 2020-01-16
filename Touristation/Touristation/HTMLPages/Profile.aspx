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
            <asp:Label runat="server" CssClass="text-info" ID="uname"></asp:Label>
            <br />  
            
            
            <asp:Button ID="editPage" CssClass="btn btn-info" runat="server" Text="Edit Profile" OnClick="editPage_Click" />
            <br /> 
            <asp:Panel runat="server" CssClass="panel-body" ID="editPanel" Visible="false">
                Username: 
                <asp:TextBox runat="server" CssClass="form-control" ID="tbEditName"> 
                </asp:TextBox>
                <br />
                Email: 
                <asp:TextBox runat="server" CssClass="form-control" ID="tbEditEmail"> 
                </asp:TextBox>
                <br /> 
                
                     <asp:TextBox runat="server" Visible="false" CssClass="form-control" TextMode="Password" ID="tbEditPass"> 
                </asp:TextBox>
                <br /> 
                
                 <asp:TextBox runat="server" Visible="false" CssClass="form-control" TextMode="Password" ID="tbEditConfirm"> 
                </asp:TextBox>
                <br />
               
                <asp:DropDownList ID="DDCountry" CssClass="form-control" runat="server" Width="100"></asp:DropDownList>
                <br /> 
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnEditProfile" Text="Edit" OnClick="btnEditProfile_Click">
                </asp:Button>
                <asp:Label runat="server" ID="LblMsg"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
    </asp:Content>