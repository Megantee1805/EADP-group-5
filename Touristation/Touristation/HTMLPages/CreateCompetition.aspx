<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCompetition.aspx.cs" Inherits="Touristation.HTMLPages.CreateCompetition" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            
            Title 
            <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
            <br />
            Description 
            <asp:TextBox ID="tbComDesc" runat="server"></asp:TextBox>
            <br />
            Start Date
            <asp:TextBox ID="tbStart" runat="server"></asp:TextBox>
            <ajaxToolkit:PopupControlExtender ID="tbStart_PopupControlExtender" runat="server" BehaviorID="tbStart_PopupControlExtender" DynamicServicePath="" ExtenderControlID="" TargetControlID="tbStart" PopupControlID="ComStart" Position="Bottom">
            </ajaxToolkit:PopupControlExtender>
            
            <asp:Calendar ID="ComStart" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="ComStart_SelectionChanged">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            End Date 
            <asp:TextBox ID="tbEnd" runat="server"></asp:TextBox>
             <ajaxToolkit:PopupControlExtender ID="tbEnd_PopupControlExtender" runat="server" BehaviorID="tbEnd_PopupControlExtender" DynamicServicePath="" ExtenderControlID="" TargetControlID="tbEnd" PopupControlID="ComEnd" Position="Bottom">
            </ajaxToolkit:PopupControlExtender>
            
             <br />
            <asp:Calendar ID="ComEnd" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="ComEnd_SelectionChanged">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
