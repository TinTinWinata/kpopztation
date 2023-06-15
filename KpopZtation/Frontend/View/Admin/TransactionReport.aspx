<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/View/Template/Template.Master" AutoEventWireup="true" CodeBehind="TransactionReport.aspx.cs" Inherits="KpopZtation.Frontend.View.Admin.TransactionReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="font-bold">Transaction Report</h1>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
</asp:Content>
