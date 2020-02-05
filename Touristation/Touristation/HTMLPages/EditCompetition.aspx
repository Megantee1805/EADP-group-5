<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Touristation.Master" CodeBehind="EditCompetition.aspx.cs" Inherits="Touristation.HTMLPages.EditCompetition" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>


<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server"> 
    <form id="form1" runat="server">
        <div class="container">
            <div class="container">
                <div class="container">
                    
                    Name 
                    <asp:TextBox ID="tbComName" CssClass="form-control" Enabled="true" runat="server"></asp:TextBox>
                    Description 
                    <asp:TextBox ID="tbComDesc" CssClass="form-control" Enabled="true" runat="server"></asp:TextBox>
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                       <p class="text-left"> Start Date </p> 
            <p class="text-right"> End Date</p>   
            
                <asp:UpdatePanel ID="UpdateCalender" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="row">
           <div class="col-xs-5">
            <asp:TextBox ID="tbStart" CssClass="form-control col-xs-6" runat="server" AutoPostBack="True"></asp:TextBox>
              
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
            </div>

             <div class="col-xs-5">

               
             <asp:TextBox ID="tbEnd" class="form-control" runat="server" AutoPostBack="True"></asp:TextBox>
             <ajaxToolkit:PopupControlExtender ID="tbEnd_PopupControlExtender" runat="server" BehaviorID="tbEnd_PopupControlExtender" DynamicServicePath="" ExtenderControlID="" TargetControlID="tbEnd" PopupControlID="ComEnd" Position="Bottom">
            </ajaxToolkit:PopupControlExtender>
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
            </ContentTemplate>
            </asp:UpdatePanel>
           
               <div></div>
                    <br />
                    
                    <asp:Button CssClass="btn btn-primary col-xs-5" ID="btnSave" Visible="true" runat="server" Text="Save" OnClick="btnSave_Click" />
                    
                    <asp:Button CssClass="btn btn-danger col-xs-5" ID="btnCancel" runat="server" Visible="false" Text="Cancel" OnClick="btnCancel_Click" />
                </div>
            </div>
        </div>
    </form>

    </asp:Content>
