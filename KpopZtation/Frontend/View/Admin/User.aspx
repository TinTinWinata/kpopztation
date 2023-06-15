
<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="KpopZtation.Frontend.View.Admin.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="UserRepeater" runat="server">
        <HeaderTemplate>
            <table class="min-w-full divide-y divide-gray-200">
                <thead class="bg-gray-50">
                    <tr>
                        <th scope="col" class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Name
                        </th>
                        <th scope="col" class="relative px-6 py-3">
                            <span class="sr-only">Customer Name</span>
                        </th>
                        <th scope="col" class="relative px-6 py-3">
                            <span class="sr-only">Customer Email</span>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody class="bg-white divide-y divide-gray-200">
                <tr class="">
                    <td class="px-6 py-4 whitespace-nowrap">
                        <div class="flex items-center">
                            <%--                            <div class="flex-shrink-0 h-10 w-10">
                                <img class="h-10 w-10 rounded-full" src=" <%# Eval("ArtistImage") %>" alt="">
                            </div>--%>
                            <div class="ml-4">
                                <div class="text-sm font-medium text-gray-900">
                                    <%# Eval("CustomerName") %>
                                </div>
                            </div>
                        </div>
                    </td>
                    <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                        <div class="ml-4">
                            <div class="text-sm font-medium text-gray-900">
                                <%# Eval("CustomerEmail") %>
                            </div>
                        </div>
                    </td>
                    <td class="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                        <asp:LinkButton OnClick="HandleDeleteBtn" CommandArgument='<%# Eval("CustomerID") %>' runat="server" CssClass="text-indigo-600 hover:text-indigo-900">Remove</asp:LinkButton>
                    </td>
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
