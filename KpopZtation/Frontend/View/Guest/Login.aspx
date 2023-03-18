<%@ Page Title="" Language="C#"
MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true"
CodeBehind="Login.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <div class="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10">
    <div>
      <asp:Label
        CssClass="block text-sm font-medium text-gray-700"
        ID="EmailLabel"
        runat="server"
        Text="Email"
      ></asp:Label>
      <div class="mt-1">
        <asp:TextBox
          CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
          ID="emailInput"
          runat="server"
        ></asp:TextBox>
      </div>
    </div>

    <div class="mt-2">
      <asp:Label
        CssClass="block text-sm font-medium text-gray-700"
        ID="PasswordLabel"
        runat="server"
        Text="Password"
      ></asp:Label>
      <div class="mt-1">
        <asp:TextBox
          CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
          ID="passwordInput"
          runat="server"
        >
        </asp:TextBox>
      </div>
    </div>
    <div class="flex items-center justify-between my-2">
      <div class=""></div>

      <div class="text-sm">
        <a href="#" class="font-medium text-indigo-600 hover:text-indigo-500">
          Forgot your password?
        </a>
      </div>
    </div>

    <div>
      <asp:Button
        OnClick="SubmitButton_Click"
        ID="SubmitButton"
        runat="server"
        Text="Sign In"
        CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
      />
    </div>
    <asp:Label
      CssClass="block text-sm font-medium text-red-400"
      ID="ErrorLabel"
      runat="server"
      Text=""
    ></asp:Label>
  </div>
</asp:Content>
