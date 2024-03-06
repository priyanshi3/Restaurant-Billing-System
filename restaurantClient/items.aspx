<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="restaurantClient.items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButtonList ID="rblAction" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblAction_SelectedIndexChanged" RepeatDirection="Horizontal" CellPadding="10" CellSpacing="5" CssClass="rblSpace" RepeatLayout="Flow">
                        <asp:ListItem Selected="True">Insert</asp:ListItem> 
                        <asp:ListItem>Update</asp:ListItem>
                    </asp:RadioButtonList>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
                </p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>
                </p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </p>
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
                    &nbsp;</p>
            </td>
            <td>
                <asp:GridView ID="gvItemsData" runat="server" CellPadding="10" CellSpacing="5" OnSelectedIndexChanged="gvItemsData_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
   
</asp:Content>
