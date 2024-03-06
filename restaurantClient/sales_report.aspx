<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sales_report.aspx.cs" Inherits="restaurantClient.sales_report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <br />
    <br />
    <br />
    <br />
    <asp:GridView ID="gvBillData" runat="server" CellPadding="10" CellSpacing="5">
    </asp:GridView></center>
</asp:Content>
