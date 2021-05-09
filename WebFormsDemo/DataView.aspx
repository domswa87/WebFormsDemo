<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataView.aspx.cs" Inherits="WebFormsDemo.WebForm1" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewDS" runat="server" OnInit="GridViewDS_Init">
        </asp:GridView>
        <asp:Button ID="ButtonDs" OnClick="ButtonClick" Text="ClickMe" runat="server"/>
    </form>
</asp:Content>
