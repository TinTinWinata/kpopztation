<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="KpopZtation.Frontend.View.Client.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <div class="flex flex-col gap-4">

            <%--<asp:Repeater ID="TransactionHistoryRepeater" runat="server">
                <HeaderTemplate>
                    <table class="min-w-full divide-y divide-gray-200">
                        <thead class="bg-gray-50">
                            <tr>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Transaction Id
                                </th
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Transaction Date
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Customer Name
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Name
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Quantity
                                </th>
                                <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Price
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody class="bg-white divide-y divide-gray-200">
                        <tr>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%= transactionHistory.TransactionID %>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%= transactionHistory.TransactionDate %>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%= transactionHistory.Customer.CustomerName %>
                                </div>
                            </td>
                            <td class="px-6 py-4 whitespace-nowrap">
                                <div class="flex justify-center items-center">
                                    <div class="flex-shrink-0 h-10 w-10">
                                        <img class="h-10 w-10 rounded-full" src=" <%= transactionDetail.Album.AlbumImage %>" alt="">
                                    </div>
                                    <div class="ml-4">
                                        <div class="text-sm font-medium text-gray-900">
                                            <%= transactionDetail.Album.AlbumName %>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%= transactionDetail.Qty %>
                                </div>
                            </td>
                            <td>
                                <div class="text-sm text-center font-medium text-gray-900">
                                    <%= transactionDetail.Album.AlbumPrice %>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>--%>
            <table class="min-w-full divide-y divide-gray-200">
                <thead class="bg-gray-50">
                    <tr>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Transaction Id
                        </th>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Transaction Date
                        </th>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Customer Name
                        </th>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Name
                        </th>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Quantity
                        </th>
                        <th scope="col" class="px-6 py-3 text-center text-xs font-medium text-gray-500 uppercase tracking-wider">Album Price
                        </th>
                    </tr>

                </thead>
                <tbody class="bg-white divide-y divide-gray-200">
                    <% foreach (var transactionHistory in TransactionHistoryLists)
                        {  %>
                    <tr>
                        <td>
                            <div class="text-sm text-center font-medium text-gray-900">
                                <%= transactionHistory.TransactionID %>
                            </div>
                        </td>
                        <td>
                            <div class="text-sm text-center font-medium text-gray-900">
                                <%= transactionHistory.TransactionDate %>
                            </div>
                        </td>
                        <td>
                            <div class="text-sm text-center font-medium text-gray-900">
                                <%= transactionHistory.Customer.CustomerName %>
                            </div>
                        </td>
                        <% foreach (var transactionDetail in transactionHistory.TransactionDetails)
                            {  %>
                        <td class="px-6 py-4 whitespace-nowrap">
                            <div class="flex justify-center items-center">
                                <div class="flex-shrink-0 h-10 w-10">
                                    <img class="h-10 w-10 rounded-full" src=" <%= transactionDetail.Album.AlbumImage %>" alt="">
                                </div>
                                <div class="ml-4">
                                    <div class="text-sm font-medium text-gray-900">
                                        <%= transactionDetail.Album.AlbumName %>
                                    </div>
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class="text-sm text-center font-medium text-gray-900">
                                <%= transactionDetail.Qty %>
                            </div>
                        </td>
                        <td>
                            <div class="text-sm text-center font-medium text-gray-900">
                                <%= transactionDetail.Album.AlbumPrice %>
                            </div>
                        </td>
                        <% } %>
                    </tr>
                    <% } %>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
