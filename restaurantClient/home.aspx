<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="restaurantClient.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    &nbsp;<table class="w-100">
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <center>
    <asp:GridView ID="itemsList" runat="server" CellSpacing="5" CellPadding="10" OnSelectedIndexChanged="itemsList_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView> </center>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
                <br />
    Item&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtItemName" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDec" runat="server" OnClick="btnDec_Click" Text="-" />
    <asp:Label ID="lblQuantity" runat="server" Text="0"></asp:Label>
    <asp:Button ID="btnInc" runat="server" OnClick="btnInc_Click" Text="+" />
&nbsp;&nbsp;<br />
                <br />
    Amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAddToBill" runat="server" OnClick="btnAddToBill_Click" Text="Add to Bill" />
    <br />
    <br />
            </td>
            <td>
                <br />
    Customer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcust" runat="server" TextMode="Phone"></asp:TextBox>
    <br />
    <br />
    <asp:ListBox ID="lbBillItems" runat="server" Width="296px">
    </asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnGenerateBill" runat="server" Text="Generate Bill" OnClick="btnGenerateBill_Click" />
    
<br />
<br />
<asp:Label ID="lblBill" runat="server" Font-Bold="True" ForeColor="#0066FF"></asp:Label>
    
    &nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
        
</asp:Content>
