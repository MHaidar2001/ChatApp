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

    <asp:ListBox class="form-control"  ID="ListBox1" runat="server" Height="113px" Width="265px"></asp:ListBox>
  </div>
</asp:Content>
