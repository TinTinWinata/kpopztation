<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlbumUpdate.aspx.cs" MasterPageFile="~/Frontend/View/Template/Template.Master" Inherits="KpopZtation.Frontend.View.Admin.AlbumUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10 flex flex-col gap-2">

        <%-- Album Name Input --%>
        <div>
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AlbumNameLabelUpdate" runat="server" Text="Album Name"></asp:Label>
            <div class="mt-1">
                <asp:TextBox
                    CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    ID="AlbumNameUpdate"
                    runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- Album Description Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AlbumPasswordLabelUpdate" runat="server" Text="Album Description"></asp:Label>
            <div class="mt-1">
                <asp:TextBox
                    CssClass="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                    ID="AlbumDescriptionUpdate"
                    runat="server"
                    TextMode="MultiLine"
                    Rows="4"></asp:TextBox>
            </div>
        </div>

        <%-- Album Price Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AlbumPriceLabelUpdate" runat="server" Text="Price"></asp:Label>
            <div class="mt-1">
                <asp:TextBox ID="AlbumPriceUpdate" 
                    CssClass="wappearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" 
                    runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- Album Stock Input --%>
        <div class="mt-2">
            <asp:Label CssClass="block text-sm font-medium text-gray-700" ID="AlbumStockLabelUpdate" runat="server" Text="Stock"></asp:Label>
            <div class="mt-1">
                <asp:TextBox ID="AlbumStockUpdate" 
                    CssClass="wappearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" 
                    runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- Album Image Input --%>
        <div class="mt-2">
            <asp:Label
                CssClass="block text-sm font-medium text-gray-700"
                ID="AlbumImageLabelUpdate"
                runat="server"
                Text="Image"></asp:Label>
            <div class="mt-1">
                <asp:FileUpload runat="server" ID="AlbumImageUpdate"></asp:FileUpload>
            </div>
        </div>

        <%-- Submit Button --%>
        <div>
            <asp:Button
                OnClick="UpdateAlbum_Click"
                ID="UpdateAlbum"
                runat="server"
                Text="Update Album"
                CssClass="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" />
        </div>
        <asp:Label CssClass="block text-sm font-medium text-red-400" ID="AlbumUpdateErrorLabel" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
