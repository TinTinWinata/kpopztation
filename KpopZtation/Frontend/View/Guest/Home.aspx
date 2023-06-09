﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtation.Frontend.View.Guest.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function handleClick(element) {
            var artistID = element.getAttribute('data-artist-id');
            window.location.href = 'Detail.aspx?id=' + artistID;
        }
    </script>


    <% if (User != null && User.CustomerRole == "Admin")
        {
    %>

    <asp:Button ID="InsertButton" CssClass="bg-red-300" OnClick="InsertButton_Click" runat="server" Text="Insert" />
    <%} %>
    <asp:Repeater ID="ArtistRepeater" runat="server">
        <HeaderTemplate>
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
        </HeaderTemplate>
        <ItemTemplate>
            <tbody class="bg-white divide-y divide-gray-200">
                <tr onclick="handleClick(this)" class="" data-artist-id='<%# Eval("ArtistID") %>'>
                    <td class="px-6 py-4 whitespace-nowrap">
                        <div class="flex items-center">
                            <div class="flex-shrink-0 h-10 w-10">
                                <img class="h-10 w-10 rounded-full" src=" <%# Eval("ArtistImage") %>" alt="">
                            </div>
                            <div class="ml-4">
                                <div class="text-sm font-medium text-gray-900">
                                    <%# Eval("ArtistName") %>
                                </div>
                            </div>
                        </div>
                    </td>
                    <% if (User != null && User.CustomerRole == "Admin")
                        {%>
                    <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                        <a href="/Frontend/View/Admin/ArtistUpdate.aspx?id=<%#Eval("ArtistID") %>" class="text-indigo-600 hover:text-indigo-900">Edit</a>
                    </td>

                    <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                        <asp:LinkButton OnClick="DeleteButton_Click" ID="LinkButton1" CommandArgument='<%# Eval("ArtistID") %>' runat="server">Delete</asp:LinkButton>
                    </td>
                    <%} %>
                </tr>
            </tbody>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Label
        CssClass="block text-sm font-medium text-red-400"
        ID="ErrorLabel"
        runat="server"
        Text=""></asp:Label>
</asp:Content>
