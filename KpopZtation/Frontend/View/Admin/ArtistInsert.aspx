<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="ArtistInsert.aspx.cs" Inherits="KpopZtation.Frontend.View.Admin.ArtistInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10">
        <div>
            <asp:Label
                CssClass="block text-sm font-medium text-gray-700"
                ID="NameLabel"
                runat="server"
                Text="Name"></asp:Label>
            <div class="mt-1">
                <asp:TextBox
                    CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    ID="NameInput"
                    runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="mt-2">
            <asp:Label
                CssClass="block text-sm font-medium text-gray-700"
                ID="ImageLabel"
                runat="server"
                Text="Image"></asp:Label>
            <div class="mt-1">
                <asp:FileUpload runat="server" ID="FileImage"></asp:FileUpload>
                <%--        <asp:TextBox
          CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
          ID="ImageInput"
          runat="server"
        >
        </asp:TextBox>--%>
            </div>
        </div>

        <div>
            <asp:Button
                OnClick="SubmitButton_Click"
                ID="SubmitButton"
                runat="server"
                Text="Insert Artist"
                CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" />
        </div>
        <asp:Label
            CssClass="block text-sm font-medium text-red-400"
            ID="ErrorLabel"
            runat="server"
            Text=""></asp:Label>
    </div>
</asp:Content>
