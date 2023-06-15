<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function handleClick(element) {
            var albumId = element.getAttribute('data-album-id');
            window.location.href = 'AlbumDetail.aspx?id=' + albumId;
        }
    </script>
    <div>
        <div>
            <img class="h-32 w-full object-cover lg:h-48" src="https://images.unsplash.com/photo-1444628838545-ac4016a5418a?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1950&q=80" alt="">
        </div>
        <div class="max-w-5xl mx-auto px-4 sm:px-6 lg:px-8">
            <div class="-mt-12 sm:-mt-16 sm:flex sm:items-end sm:space-x-5">
                <div class="flex">
                    <img class="h-24 w-24 rounded-full ring-4 ring-white sm:h-32 sm:w-32" src="<%=Artist.ArtistImage %>" alt="">
                </div>
                <div class="mt-6 sm:flex-1 sm:min-w-0 sm:flex sm:items-center sm:justify-end sm:space-x-6 sm:pb-1">
                    <div class="sm:hidden 2xl:block mt-6 min-w-0 flex-1">
                        <h1 class="text-2xl font-bold text-gray-900 truncate"><%=Artist.ArtistName %>
                        </h1>
                    </div>
                    <div class="mt-6 flex flex-col justify-stretch space-y-3 sm:flex-row sm:space-y-0 sm:space-x-4">
                        <button type="button" class="inline-flex justify-center px-4 py-2 border border-gray-300 shadow-sm text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-pink-500">
                            <!-- Heroicon name: solid/mail -->
                            <svg class="-ml-1 mr-2 h-5 w-5 text-gray-400" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                                <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                                <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
                            </svg>
                            <span>Message</span>
                        </button>
                        <button type="button" class="inline-flex justify-center px-4 py-2 border border-gray-300 shadow-sm text-sm font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-pink-500">
                            <!-- Heroicon name: solid/phone -->
                            <svg class="-ml-1 mr-2 h-5 w-5 text-gray-400" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                                <path d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
                            </svg>
                            <span>Call</span>
                        </button>
                    </div>
                </div>
            </div>
            <div class="hidden sm:block 2xl:hidden mt-6 min-w-0 flex-1">
                <h1 class="text-2xl font-bold text-gray-900 truncate"><%=Artist.ArtistName %>
                </h1>
            </div>
        </div>

        <div class="flex flex-col gap-4">
            <div></div>
            <div class="flex justify-end">

                <% if (User != null && User.CustomerRole == "Admin")
                    {%>
                <asp:Button
                    CssClass="bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded"
                    ID="InsertAlbumButton"
                    runat="server"
                    OnClick="InsertAlbumButton_Click"
                    Text="Insert" />
                <%} %>
            </div>


            <asp:Repeater ID="AlbumRepeater" runat="server">
                <HeaderTemplate>
                    <table class="min-w-full divide-y divide-gray-200">
                        <thead class="bg-gray-50">
                            <tr>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Name
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Price
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album description
                                </th>
                                <th scope="col" colspan="3" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Action
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody class="bg-white divide-y divide-gray-200">
                        <tr onclick="handleClick(this)" class="" data-album-id='<%# Eval("AlbumID") %>'>
                            <td class="px-6 py-4 whitespace-nowrap">
                                <div class="flex justify-center items-center">
                                    <div class="flex-shrink-0 h-10 w-10">
                                        <img class="h-10 w-10 rounded-full" src=" <%# Eval("AlbumImage") %>" alt="">
                                    </div>
                                    <div class="ml-4">
                                        <div class="text-sm font-medium text-gray-900">
                                            <%# Eval("AlbumName") %>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%# Eval("AlbumPrice") %>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%# Eval("AlbumDescription") %>
                                </div>
                            </td>
                            <% if (User != null && User.CustomerRole == "Admin")
                                {%>

                            <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                                <a href="/Frontend/View/Admin/AlbumUpdate.aspx?id=<%#Eval("AlbumID") %>" class="text-indigo-600 hover:text-indigo-900">Edit</a>
                            </td>

                            <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                                <asp:LinkButton OnClick="DeleteAlbumButton_Click" CommandArgument='<%# Eval("AlbumID") %>' runat="server" CssClass="text-indigo-600 hover:text-indigo-900">Remove</asp:LinkButton>
                            </td>
                            <%} %>
                        </tr>
                    </tbody>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
