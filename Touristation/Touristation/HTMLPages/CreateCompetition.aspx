<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Touristation.Master"  CodeBehind="CreateCompetition.aspx.cs" Inherits="Touristation.HTMLPages.CreateCompetition" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
    <body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
        <div class="container">
            <div class="container">
            Title 
            <asp:TextBox ID="tbTitle" CssClass="form-control" runat="server"></asp:TextBox>
        
            Description
            <asp:TextBox ID="tbComDesc" CssClass="form-control" runat="server"></asp:TextBox>
           
            Judging Method 
                <asp:RadioButtonList AutoPostBack="true" ID="rgroupJudgingMethod" runat="server" CssClass="radio" OnSelectedIndexChanged="rgroupJudgingMethod_SelectedIndexChanged"> 
                    <asp:ListItem Value="1"> Judging </asp:ListItem>
                    <asp:ListItem Value="2"> Votes </asp:ListItem>
                </asp:RadioButtonList>
            <br /> 
           
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

                         <asp:Button ID="btnComCreate" runat="server" Text="Submit" class="btn btn-primary col-xs-5" OnClick="btnComCreate_Click" />
                        <asp:Button ID="btnChooseNext" runat="server" Text="Pick Judge" Visible="false" class="btn btn-primary col-xs-5" OnClick="btnChooseNext_Click" />
                        <br />
                        <br /> 
                        <br /> 
    <asp:Label runat="server" CssClass="h5" ID="LblMsg"></asp:Label>
            </ContentTemplate>
                        </asp:UpdatePanel>
                
            
            </div> 
       </div>
            </div> 
        </div> 
   
    </form>

    </body>
    </asp:Content>
