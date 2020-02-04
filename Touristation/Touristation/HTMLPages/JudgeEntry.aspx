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
                    
                    
            <asp:DataList ID="dataScore" runat="server" CssClass="auto-style3" OnItemCommand="dataScore_ItemCommand">
                <ItemTemplate>
                    <div class="row"> 
                        <div class="col-xs-3">
                    <asp:TextBox runat="server" Enabled="false" CssClass="form-control" ID="tbName" Text='<%#Bind("name") %>' />
                        </div>
                        <div class="col-xs-3">
                    <asp:Image ID="entryImg" CssClass="img-responsive" ImageUrl='<%#Bind("fileLink") %>' runat="server" />     
                            </div> 
                        <div class="col-xs-3">
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbScore" Text='<%#Bind("score") %>' TextMode="Number" />
                        </div>
                   <asp:HiddenField runat="server" ID="entryNo" Value='<%#Bind("Id") %>' />
                   <asp:Button runat="server" CausesValidation="false" CssClass="btn btn-primary" ID="btnJudge" CommandName="Judge" Text="Judge" />
                    </div>
                        
                </ItemTemplate>
                
            </asp:DataList>
                    
        </div>
                </div>
            </div>
    </form>
    </body>
    </asp:Content>