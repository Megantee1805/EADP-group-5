<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Touristation.Master"
    CodeBehind="JudgeEntry.aspx.cs" Inherits="Touristation.HTMLPages.JudgeEntry" %>


<asp:Content
    ID="Content1"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="container"> 
                <div class="container">
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    
            <asp:DataList ID="dataScore" runat="server" CssClass="auto-style3">
                <ItemTemplate>
                  <ajaxToolkit:ModalPopupExtender PopupControlID="judgingPanel"
                        popupdraghandlecontrolid="PopupHeader" drag="true"
                        BackgroundCssClass="modal-backdrop"
                        TargetControlID="btnJudge"
                        CancelControlID="btnCancel"
                         OkControlID="btnSubmit"
                        ID="ModalPopupExtenderJudge" runat="server">
                        
                    </ajaxToolkit:ModalPopupExtender>
                    <div class="row"> 
                        <div class="col-xs-5">
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbName" Text='<%#Bind("name") %>' />
                        </div>
                        <div class="col-xs-5">
                    <asp:Image ID="entryImg" CssClass="img-responsive" ImageUrl='<%#Bind("fileLink") %>' runat="server" />     
                            </div>  
                   <asp:Button runat="server" CssClass="btn btn-primary" ID="btnJudge" CommandName="Judge" Text="Judge" />
                    </div>
                        
                </ItemTemplate>
                
            </asp:DataList>
                    
                    <asp:Panel runat="server" ID="judgingPanel"> 
                        <asp:Label runat="server" ID="LblEntry"></asp:Label>
                        <asp:TextBox TextMode="Number" CssClass="form-control" ID="tbScore" runat="server" /> 
                        <asp:Button runat="server" CssClass="btn btn-success" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click"/> 
                        <asp:Button runat="server" CssClass="btn btn-danger" ID="btnCancel" Text="Cancel"/> 
                     </asp:Panel> 
        </div>
                </div>
            </div>
    </form>
</body>
</html>
    </asp:Content>