<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10">

                <%-- Email Input --%>
                <div>
                    <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="EmailLabel" runat="server" Text="Email"></asp:Label>
                  <div class="mt-1">
                     <asp:TextBox 
                         CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                         ID="EmailInput" 
                         runat="server"></asp:TextBox>
                  </div>
                </div>

                <%-- Password Input --%>
                <div class="mt-2">
                  <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
                  <div class="mt-1">
                     <asp:TextBox 
                         CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                         ID="PasswordInput" 
                         runat="server">
                     </asp:TextBox>
                  </div>
                </div>

                <%-- Name Input --%>
                <div class="mt-2">
                  <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="NameLabel" runat="server" Text="Name"></asp:Label>
                  <div class="mt-1">
                     <asp:TextBox 
                         CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                         ID="NameInput" 
                         runat="server">
                     </asp:TextBox>
                  </div>
                </div>

                <%-- Gender Input --%>
                <div class="mt-2">
                  <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
                  <div class="mt-1">
                     <asp:TextBox 
                         CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                         ID="GenderInput" 
                         runat="server">
                     </asp:TextBox>
                  </div>
                </div>

                <%-- Address Input --%>
                <div class="mt-2">
                  <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AddressLabel" runat="server" Text="Address"></asp:Label>
                  <div class="mt-1">
                     <asp:TextBox 
                         CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                         ID="AddressInput" 
                         runat="server">
                     </asp:TextBox>
                  </div>
                </div>

            <div>

                <%-- Register BUtton --%>
              <asp:Button 
                  OnClick="SubmitButton_Click"
                  ID="SubmitButton" 
                  runat="server" 
                  Text="Sign In" 
                  CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" />
            </div>
              <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="ErrorLabel" runat="server" Text="Error"></asp:Label>
        </div>


</asp:Content>
