<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="KpopZtation.Frontend.View.Client.CartView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <div class="flex flex-col gap-4">
            <asp:Repeater ID="CartRepeater" runat="server">
                <HeaderTemplate>
                    <table class="min-w-full divide-y divide-gray-200">
                        <thead class="bg-gray-50">
                            <tr>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Name
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Quantity
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Price
                                </th>
                                <th scope="col" colspan="3" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Action
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody class="bg-white divide-y divide-gray-200">
                        <tr>
                            <td class="px-6 py-4 whitespace-nowrap">
                                <div class="flex justify-center items-center">
                                    <div class="flex-shrink-0 h-10 w-10">
                                        <img class="h-10 w-10 rounded-full" src=" <%# Eval("Album.AlbumImage") %>" alt="">
                                    </div>
                                    <div class="ml-4">
                                        <div class="text-sm font-medium text-gray-900">
                                            <%# Eval("Album.AlbumName") %>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%# Eval("Qty") %>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%# Eval("Album.AlbumPrice") %>
                                </div>
                            </td>
                            <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                                <a href="/Frontend/View/Admin/AlbumUpdate.aspx?id=<%#Eval("AlbumID") %>" class="text-indigo-600 hover:text-indigo-900">Checkout</a>
                            </td>

                            <td class="px-6 py-4 whitespace-nowrap text-center text-sm font-medium">
                                <asp:LinkButton OnClick="DeleteCartButton_Click" CommandArgument='<%# Eval("AlbumID") %>' runat="server" CssClass="text-indigo-600 hover:text-indigo-900">Remove</asp:LinkButton>
                            </td>
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
