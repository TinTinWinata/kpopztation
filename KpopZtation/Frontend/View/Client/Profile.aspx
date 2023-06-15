<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="KpopZtation.Frontend.View.Client.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10 flex flex-col gap-2">

        <%-- Profile Name Input --%>
        <%--<div>--%>
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AlbumLabel" runat="server" Text="Profile Name"></asp:Label>
            <div class="mt-1">
                <asp:TextBox
                    CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    ID="ProfileNameInput"
                    runat="server">
                </asp:TextBox>
            </div>
        </div>

        <%-- Profile Email Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="PasswordLabel" runat="server" Text="Profile Email"></asp:Label>
            <div class="mt-1">
                <asp:TextBox
                    CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    ID="ProfileEmailInput"
                    runat="server"
                    TextMode="MultiLine"
                    Rows="4">
                </asp:TextBox>
            </div>
        </div>

        <%-- Gender Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
            <div class="mt-1">
                <asp:RadioButtonList ID="GenderInputRadioButtonList" runat="server">
                    <asp:ListItem ID="MaleListItem" Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem ID="FemaleListItem" Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>


        <%-- Profile Address Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="Label1" runat="server" Text="Address"></asp:Label>
            <div class="mt-1">
                <asp:TextBox ID="AddressInput"
                    CssClass="wappearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    runat="server">
                </asp:TextBox>
            </div>
        </div>

        <%-- Profile Password Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="Label2" runat="server" Text="Password"></asp:Label>
            <div class="mt-1">
                <asp:TextBox 
                    ID="PasswordInput"
                    CssClass="wappearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    runat="server">
                </asp:TextBox>
            </div>
        </div>

        <%-- Submit Button --%>
        <div>
            <asp:Button
                OnClick="SubmitButton_Click"
                ID="SubmitButton"
                runat="server"
                Text="Update Profile"
                CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" />

              <asp:Button
                OnClick="Delete_Click"
                ID="Button1"
                runat="server"
                Text="Delete Account"
                CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" />

        </div>
        <asp:Label CssClass="block text-sm font-medium text-red-400" ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
