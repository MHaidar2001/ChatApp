<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ChatApp.Views.Chat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
      <h1>Chat App</h1>
    <br /> 
    <div class="form-group">
         <label class="control-label" for="inputDefault">Empfänger adresse(URL)</label>

        <asp:TextBox  class="form-control"  ID="urltxt" runat="server"></asp:TextBox><br />
        <label class="control-label" for="inputDefault">Nachricht</label><br />
        <asp:TextBox class="form-control"  ID="chattxt" runat="server"></asp:TextBox><br />
        <asp:Button class="btn btn-success" ID="submitbtn" runat="server" Text="Senden" OnClick="submitbtn_Click" /><br />

        <label class="control-label" for="inputDefault">Nachricht</label><br />
  


        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            
                    <ContentTemplate>
                         <asp:Timer ID="Timer2" runat="server" Interval="2500" OnTick="Timer1_Tick"></asp:Timer>
                         <br />
                         <asp:ListBox class="form-control"  ID="ListBox1" runat="server" Height="153px" Width="363px"></asp:ListBox>
                    </ContentTemplate>
        </asp:UpdatePanel>

   </div>

</asp:Content>
