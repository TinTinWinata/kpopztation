<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
        <input id="emailTF" type="text" />
    </div>
    <div>
         <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
        <input id="passwordTF" type="password" />
    </div>

</asp:Content>
