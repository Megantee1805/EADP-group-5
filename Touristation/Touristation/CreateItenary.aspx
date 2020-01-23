<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateItenary.aspx.cs" Inherits="Itenary.AddItenary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 159px;
        }
        .auto-style3 {
            width: 1176px;
        }
        .auto-style4 {
            width: 159px;
            height: 26px;
        }
        .auto-style5 {
            width: 1176px;
            height: 26px;
        }
        .auto-style6 {
            width: 159px;
            height: 29px;
        }
        .auto-style7 {
            width: 1176px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="NOPlbl" runat="server" Text="Name of place:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="NOPTB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="timeLB" runat="server" Text="Time:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TimeTB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="DateLB" runat="server" Text="Date:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="DateTB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="LCLB" runat="server" Text="Location:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="LocationTB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
       
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnRfrsh" runat="server" Text="Refresh" OnClick="BtnRfrsh_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
      
            </tr>
        
            
    </form>
        </table>
   
</body>
</html>
