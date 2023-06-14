<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="InsertButton" CssClass="bg-red-300" OnClick="InsertButton_Click" runat="server" Text="Insert" />
    <asp:Button ID="InsertAlbum" CssClass="bg-blue-300" OnClick="InsertAlbumButton_Click" runat="server" Text="Insert Album" />
    <table class="min-w-full divide-y divide-gray-200">
        <thead class="bg-gray-50">
            <tr>
                <th scope="col" class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Name
                </th>
                <th scope="col" class="relative px-6 py-3">
                    <span class="sr-only">Edit</span>
                </th>
                <th scope="col" class="relative px-6 py-3">
                    <span class="sr-only">Delete</span>
                </th>
            </tr>
        </thead>
        <tbody class="bg-white divide-y divide-gray-200">
            <%foreach (var Artist in ArtistList)
                {
            %>
            <tr>
                <td class="px-6 py-4 whitespace-nowrap">
                    <div class="flex items-center">
                        <div class="flex-shrink-0 h-10 w-10">
                            <img class="h-10 w-10 rounded-full" src=" <%= Artist.ArtistImage %>" alt="">
                        </div>
                        <div class="ml-4">
                            <div class="text-sm font-medium text-gray-900">
                                <%= Artist.ArtistName %>
                            </div>
                        </div>
                    </div>
                </td>

                <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                    <a href="#" class="text-indigo-600 hover:text-indigo-900">Edit</a>
                </td>
                <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                    <a href="#" class="text-indigo-600 hover:text-indigo-900">Remove</a>
                </td>
            </tr>
            <%} %>
        </tbody>
    </table>

    <table class="min-w-full divide-y divide-gray-200">
        <thead class="bg-gray-50">
            <tr>
                <th scope="col" class="px-6 py-3 text-xs text-center font-medium text-gray-500 uppercase tracking-wider">Album Image</th>
                <th scope="col" class="px-6 py-3 text-xs text-center font-medium text-gray-500 uppercase tracking-wider">Album Price</th>
                <th scope="col" class="px-6 py-3 text-xs text-center font-medium text-gray-500 uppercase tracking-wider">Album Description</th>
                <th scope="col" colspan="2" class="relative px-6 py-3">Action</th>
            </tr>
        </thead>
        <tbody class="bg-white divide-y divide-gray-200">
            <%foreach (var Album in AlbumList)
                {
            %>
            <tr>
                <td class="px-6 py-4 whitespace-nowrap">
                    <div class="flex justify-center items-center w-full">
                        <div class="text-sm font-medium text-gray-900">
                            <img class="h-10 w-10 rounded-full" src=" <%= Album.AlbumImage %>" alt="">
                        </div>
                        <div class="ml-4">
                            <div class="text-sm font-medium text-gray-900">
                                <%= Album.AlbumName %>
                            </div>
                        </div>
                    </div>
                </td>
                <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                    <div class="text-sm font-medium text-gray-900">
                        <%= Album.AlbumPrice %>
                    </div>
                </td>
                <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                    <div class="text-sm font-medium text-gray-900">
                        <%= Album.AlbumDescription %>
                    </div>
                </td>
                <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                    <a href="#" class="text-indigo-600">Edit</a>
                </td>
                <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                    <a href="#" class="text-indigo-600">Remove</a>
                </td>
            </tr>
            <%} %>
        </tbody>
    </table>
</asp:Content>
